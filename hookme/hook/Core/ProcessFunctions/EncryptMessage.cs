using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using hook.wrappers;

namespace hook.Core.ProcessFunctions
{
    class EncryptMessage
    {
        // http://msdn.microsoft.com/en-us/library/windows/desktop/aa375378(v=vs.85).aspx

        FunctionWrapper function;

        public EncryptMessage(FunctionWrapper function)
        {   
            this.function = function;
        }

        public byte[] GetBuffer()
        {
            if (function.callInfo.Params() == null)
                return null;

            Nektra.Deviare2.INktParam PSecBufferDesc = function.callInfo.Params().GetAt(2);
            Nektra.Deviare2.INktProcessMemory PSecBufferMemory = PSecBufferDesc.Memory();
            /*
                typedef struct _SecBufferDesc 
                {
                  ULONG      ulVersion;
                  ULONG      cBuffers;
                  PSecBuffer pBuffers;
                } SecBufferDesc, *PSecBufferDesc;
             */
            
            Nektra.Deviare2.INktParam _SecBufferDesc  = PSecBufferDesc.Evaluate(); // estructura
            Nektra.Deviare2.INktParam cBuffers = _SecBufferDesc.Fields().GetAt(1);
            Nektra.Deviare2.INktParam pBuffers = _SecBufferDesc.Fields().GetAt(2);


            for (int i = 0; i < (int)cBuffers.Value; i++)
            {
                int offsetStructure = 12;
                int bytesLeidos;
                
                byte[] arBuffType = Auxiliar.Memory.ReadMemory(function.callInfo.Process().Id, pBuffers.PointerVal + 4 + (offsetStructure * i), (int)4, out bytesLeidos);
                int buffType = BitConverter.ToInt32(arBuffType, 0);

                if (buffType == 1) // SECBUFFER_DATA
                {
                    byte[] arCbBuffer = Auxiliar.Memory.ReadMemory(function.callInfo.Process().Id, pBuffers.PointerVal + 0 + (offsetStructure * i), (int)4, out bytesLeidos);
                    int cbBuffer = BitConverter.ToInt32(arCbBuffer, 0);

                    byte[] arBufferEntryPoint = Auxiliar.Memory.ReadMemory(function.callInfo.Process().Id, pBuffers.PointerVal + 8 + (offsetStructure * i), (int)4, out bytesLeidos);
                    int bufferEntryPoint = BitConverter.ToInt32(arBufferEntryPoint, 0);
                    IntPtr ptrBufferEntryPoint = new IntPtr(bufferEntryPoint);

                    byte[] content = Auxiliar.Memory.ReadMemory(function.callInfo.Process().Id, ptrBufferEntryPoint, (int)cbBuffer, out bytesLeidos);
                    return content;
                }

            }

            return null;
        }

        public static FunctionWrapper PrepareFunction(FunctionWrapper f, byte[] buffer)
        {
            Nektra.Deviare2.INktParam PSecBufferDesc = f.callInfo.Params().GetAt(2);
            Nektra.Deviare2.INktProcessMemory PSecBufferMemory = PSecBufferDesc.Memory();
            /*
                typedef struct _SecBufferDesc 
                {
                  ULONG      ulVersion;
                  ULONG      cBuffers;
                  PSecBuffer pBuffers;
                } SecBufferDesc, *PSecBufferDesc;
             */

            Nektra.Deviare2.INktParam _SecBufferDesc = PSecBufferDesc.Evaluate(); // estructura
            Nektra.Deviare2.INktParam cBuffers = _SecBufferDesc.Fields().GetAt(1);
            Nektra.Deviare2.INktParam pBuffers = _SecBufferDesc.Fields().GetAt(2);


            for (int i = 0; i < (int)cBuffers.Value; i++)
            {
                int offsetStructure = 12;
                int bytesLeidos;

                byte[] arBuffType = Auxiliar.Memory.ReadMemory(f.callInfo.Process().Id, pBuffers.PointerVal + 4 + (offsetStructure * i), (int)4, out bytesLeidos);
                int buffType = BitConverter.ToInt32(arBuffType, 0);

                if (buffType == 1) // SECBUFFER_DATA
                {
                    byte[] arCbBuffer = Auxiliar.Memory.ReadMemory(f.callInfo.Process().Id, pBuffers.PointerVal + 0 + (offsetStructure * i), (int)4, out bytesLeidos);
                    int cbBuffer = BitConverter.ToInt32(arCbBuffer, 0);

                    byte[] arBufferEntryPoint = Auxiliar.Memory.ReadMemory(f.callInfo.Process().Id, pBuffers.PointerVal + 8 + (offsetStructure * i), (int)4, out bytesLeidos);
                    int bufferEntryPoint = BitConverter.ToInt32(arBufferEntryPoint, 0);
                    IntPtr ptrBufferEntryPoint = new IntPtr(bufferEntryPoint);

                    // escribimos el buffer en memoria
                    Auxiliar.Memory.WriteMemory(f.callInfo.Process().Id, ptrBufferEntryPoint, buffer); 
                    // escribimos la longitud en memoria
                    Auxiliar.Memory.WriteMemory(f.callInfo.Process().Id, pBuffers.PointerVal + 0 + (offsetStructure * i), BitConverter.GetBytes(buffer.Length)); 
                    // pfffff... mas me vale no crear un buffer con mayor longitud, porque se podrían sobrescribir zonas de memoria de esta estructura y crashear
                    
                    return f;
                }

            }

            return f;
        }
    }
}
