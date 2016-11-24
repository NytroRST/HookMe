using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using hook.wrappers;

namespace hook.Core.ProcessFunctions
{
    class recv
    {
        /*
            http://msdn.microsoft.com/en-us/library/windows/desktop/ms740121(v=vs.85).aspx
        
            int recv(
              _In_   SOCKET s,
              _Out_  char *buf,
              _In_   int len,
              _In_   int flags
            );
        */
        FunctionWrapper function;

        public recv(FunctionWrapper function)
        {
            // ¿Quien usa esta api? xchat2

            this.function = function;
        }

        public byte[] GetBuffer()
        {
            // Numero de parámetros que trae la función
            /*
            if (function.callInfo.Params().Count == 0)
            {
                //return null; // Esto pasa cuando la funcion se hookea mal. Es case sensitive y tiene que ir en minusculas, como 'send'
                return new byte[0];
            }
            */

            if (function.callInfo.Params() == null)
                return new byte[0];
            if (function.callInfo.Params().Count == 0)
                return new byte[0];

            int lenBytes = (int)function.callInfo.Result().Value;

            if (lenBytes > 0)
            {
                byte[] tmpBuffer = (byte[])(Array)(function.callInfo.Params().GetAt(1).get_ValueArrayAt(0, lenBytes));
                byte[] buffer = new byte[lenBytes];
                System.Buffer.BlockCopy(tmpBuffer, 0, buffer, 0, lenBytes);

                // Mod de plugins
                buffer = Program.data.pluginMngr.pluginsApiNotExported.SetRecvBuffer(buffer);
              
                return buffer;
            }

            return null;
        }

        public static FunctionWrapper PrepareFunction(FunctionWrapper f, byte[] buffer)
        {
            foreach (MatchAndReplace.MatchAndReplace match in Program.data.GetReplaceList())
            {
                if (!match.enabled)
                    continue;

                if (match.replaceIncomming)
                {
                    bool changed;
                    do
                    {
                        buffer = Searcher.Searcher.ReplaceBytes(buffer, match.match, match.replace, out changed);
                    } while (changed);
                }
            }

            f.callInfo.Result().Value = buffer.Length;
            f.callInfo.Params().GetAt(2).Value = buffer.Length; ;
            f.callInfo.Params().GetAt(1).set_ValueAt(0, buffer);
            return f;
        }
    }
}
