using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using hook.wrappers;
using Be.Windows.Forms;
using System.IO;

namespace hook.Core.ProcessFunctions
{
    class send
    {
        /*
            send function http://msdn.microsoft.com/en-us/library/windows/desktop/ms740149(v=vs.85).aspx

            int send(
                _In_  SOCKET s,
                _In_  const char *buf,
                _In_  int len,
                _In_  int flags
            );
        */
        FunctionWrapper function;

        public send(FunctionWrapper function)
        {
            // ¿Quien usa esta api? xchat2

            this.function = function;
        }

        public byte[] GetBuffer()
        {
           
            // Numero de parámetros que trae la función
            /*
            if ((function.callInfo.Params() == null) | (function.callInfo.Params().Count == 0) )
            {
                //return null; // Esto pasa cuando la funcion se hookea mal. Es case sensitive y tiene que ir en minusculas, como 'send'
                return new byte[0];
            }
            */
            if (function.callInfo.Params() == null)
                return new byte[0];
            if (function.callInfo.Params().Count == 0)
                return new byte[0];

            int lenBytes = (int)function.callInfo.Params().GetAt(2).Value;

            if (lenBytes > 0)
            {
                byte[] tmpBuffer = (byte[])(Array)(function.callInfo.Params().GetAt(1).get_ValueArrayAt(0, lenBytes));
                byte[] buffer = new byte[lenBytes];
                System.Buffer.BlockCopy(tmpBuffer, 0, buffer, 0, lenBytes);



                // Mod de plugins
                buffer = Program.data.pluginMngr.pluginsApiNotExported.SetSendBuffer(buffer);
               

                return buffer;
            }

            //return null;
            return new byte[0];
        }

        public static FunctionWrapper PrepareFunction(FunctionWrapper f, byte[] buffer)
        {

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

            f.callInfo.Params().GetAt(2).Value = buffer.Length; ;
            f.callInfo.Params().GetAt(1).set_ValueAt(0, buffer);
            return f;
        }
    }
}
