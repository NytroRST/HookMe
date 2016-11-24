using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using hook.wrappers;
using System.Runtime.InteropServices;

namespace hook.Core.ProcessFunctions
{
    
    
    class WSArecv
    {

       /*
            http://msdn.microsoft.com/en-us/library/windows/desktop/ms741688(v=vs.85).aspx

            int (
              _In_    WSARecv SOCKET s,
              _Inout_  LPWSABUF lpBuffers,
              _In_     DWORD dwBufferCount,
              _Out_    LPDWORD lpNumberOfBytesRecvd,
              _Inout_  LPDWORD lpFlags,
              _In_     LPWSAOVERLAPPED lpOverlapped,
              _In_     LPWSAOVERLAPPED_COMPLETION_ROUTINE lpCompletionRoutine
            );
        */
        /*
            typedef struct __WSABUF {
              u_long   len;
              char FAR *buf;
            } WSABUF, *LPWSABUF;
        */

        FunctionWrapper function;

        public WSArecv(FunctionWrapper function)
        {
            // ¿Quien usa esta api? Apache2 
            this.function = function;
        }

        public byte[] GetBuffer()
        {
            Nektra.Deviare2.INktParam lpBuffers = function.callInfo.Params().GetAt(1);
            Nektra.Deviare2.INktParam dwBufferCount = function.callInfo.Params().GetAt(2);
            Nektra.Deviare2.INktParam lpNumberOfBytesRecvd = function.callInfo.Params().GetAt(3);
            Nektra.Deviare2.INktProcessMemory Memory = lpBuffers.Memory();

            IntPtr WSABUFList = lpBuffers.PointerVal;
            
            // len. No la leemos de la estructura WSABUF sino de WSARecv
            Nektra.Deviare2.INktParam NumberOfBytesRecvd = lpNumberOfBytesRecvd.Evaluate();

            // *buf
            IntPtr pBuffer = new IntPtr(Memory.Read(WSABUFList + 4, Nektra.Deviare2.eNktDboFundamentalType.ftUnsignedDoubleWord));

            int readedBytes = 0;
            byte[] buffer = Auxiliar.Memory.ReadMemory(function.callInfo.Process().Id, pBuffer, (int)NumberOfBytesRecvd.Value, out readedBytes);

            // Mod de plugins
            buffer = Program.data.pluginMngr.pluginsApiNotExported.SetRecvBuffer(buffer);

            return buffer;
        }

        public static FunctionWrapper PrepareFunction(FunctionWrapper f, byte[] buffer)
        {
            Nektra.Deviare2.INktParam lpBuffers = f.callInfo.Params().GetAt(1);
            Nektra.Deviare2.INktParam dwBufferCount = f.callInfo.Params().GetAt(2);
            Nektra.Deviare2.INktParam lpNumberOfBytesRecvd = f.callInfo.Params().GetAt(3);

            // Numero de estructuras
            ulong nStructs = dwBufferCount.Memory().Read(dwBufferCount.Address, Nektra.Deviare2.eNktDboFundamentalType.ftUnsignedWord);
            // Puntero a donde apunta la lista de estructuras
            IntPtr lpwsabuf = new IntPtr(lpBuffers.Memory().Read(lpBuffers.Address, Nektra.Deviare2.eNktDboFundamentalType.ftUnsignedDoubleWord));

            // len. No la leemos de la estructura WSABUF sino de WSARecv
            Nektra.Deviare2.INktParam NumberOfBytesRecvd = lpNumberOfBytesRecvd.Evaluate();

            // *buf
            IntPtr pBuffer = new IntPtr(lpBuffers.Memory().Read(lpwsabuf + 4, Nektra.Deviare2.eNktDboFundamentalType.ftUnsignedDoubleWord));

            // Modificamos el buffer
            Auxiliar.Memory.WriteMemory(f.callInfo.Process().Id, pBuffer, buffer);

            // Modificamos el tamaño
            lpNumberOfBytesRecvd.Value = buffer.Length;

            return f;
        }
    }
}
