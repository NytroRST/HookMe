using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using hook.wrappers;
using Be.Windows.Forms;
using System.IO;
using System.Collections;

namespace hook.Core.ProcessFunctions
{
    class WSAsend
    {
        /*
            WSASend function http://msdn.microsoft.com/en-us/library/windows/desktop/ms742203(v=vs.85).aspx

            int WSASend(
              _In_   SOCKET s,
              _In_   LPWSABUF lpBuffers,
              _In_   DWORD dwBufferCount,
              _Out_  LPDWORD lpNumberOfBytesSent,
              _In_   DWORD dwFlags,
              _In_   LPWSAOVERLAPPED lpOverlapped,
              _In_   LPWSAOVERLAPPED_COMPLETION_ROUTINE lpCompletionRoutine
            );
        */
        /*
            typedef struct __WSABUF {
              u_long   len;
              char FAR *buf;
            } WSABUF, *LPWSABUF;
        */

        FunctionWrapper function;

        public WSAsend(FunctionWrapper function)
        {
            // ¿Quien usa esta api? Apache¿?
            this.function = function;
        }

        public byte[] GetBuffer()
        {
            Nektra.Deviare2.INktParam lpBuffers = function.callInfo.Params().GetAt(1);
            Nektra.Deviare2.INktParam dwBufferCount = function.callInfo.Params().GetAt(2);
            //Nektra.Deviare2.INktParam dwFlags = function.callInfo.Params().GetAt(4);
            //Nektra.Deviare2.INktParam lpOverlapped = function.callInfo.Params().GetAt(5);
            //Nektra.Deviare2.INktParam lpCompletionRoutine = function.callInfo.Params().GetAt(6);
            Nektra.Deviare2.INktProcessMemory Memory = lpBuffers.Memory();
            
            //Lista de estructuras WSABUF
            IntPtr WSABUFList = lpBuffers.PointerVal;
            ArrayList buffer = new ArrayList();
            //Por cada estructura WSABuf leemos sus datos
            for (int i = 0; i < (int)dwBufferCount.Value; i++)
            {
                //El primer puntero en la lista WSABUFList es la longitud
                ulong lenBytes = (ulong)Memory.Read(WSABUFList + i * 8, Nektra.Deviare2.eNktDboFundamentalType.ftUnsignedDoubleWord);

                if (lenBytes > 0)
                {
                    //El segundo puntero en la lista WSABUFList es el buffer en si
                    IntPtr intptrBuffer = new IntPtr(Memory.Read(WSABUFList + 4 + i * 8, Nektra.Deviare2.eNktDboFundamentalType.ftUnsignedDoubleWord));
                    //Leemos el buffer
                    int readedBytes = 0;
                    byte[] bufferTemp = Auxiliar.Memory.ReadMemory(function.callInfo.Process().Id, intptrBuffer, (int) lenBytes, out readedBytes);
                    buffer.AddRange(bufferTemp);
                }
                else
                {
                }
            }
            if (buffer.Count == 0)
                return new byte[0];
            else
            {
                byte[] arrBuffer = (byte[])buffer.ToArray(typeof(byte));

                // Mod de plugins
                arrBuffer = Program.data.pluginMngr.pluginsApiNotExported.SetSendBuffer(arrBuffer);
                return arrBuffer;
            }
        }

        public static FunctionWrapper PrepareFunction(FunctionWrapper f, byte[] buffer)
        {
            Nektra.Deviare2.INktParam lWsabuf = f.callInfo.Params().GetAt(1).Evaluate();
            Nektra.Deviare2.INktParam lwsaSend = f.callInfo.Params().GetAt(3).Evaluate();


            Nektra.Deviare2.INktParam len = lWsabuf.Fields().GetAt(0);
            Nektra.Deviare2.INktParam pBuff = lWsabuf.Fields().GetAt(1);

            foreach (MatchAndReplace.MatchAndReplace match in Program.data.GetReplaceList())
            {
                if (!match.enabled)
                    continue;

                if (match.replaceOutcomming)
                {
                    bool changed;
                    do
                    {
                        buffer = Searcher.Searcher.ReplaceBytes(buffer, match.match, match.replace, out changed);
                    } while (changed);
                }
            }

            len.Value = buffer.Length;
            pBuff.Value = buffer;

            return f;
        }
    }
}
