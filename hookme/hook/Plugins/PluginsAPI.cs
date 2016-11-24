using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace hook.Plugins
{
    public class PluginsAPI
    {
        #region Debug

        public void Debug(string msg)
        {
            Program.LogThisInAPIConsole(msg + "\r\n");
        }

        public void Debug(byte b)
        {
            Debug(b.ToString());
        }

        public void Debug(int i)
        {
            Debug(i.ToString());
        }

        public void Debug(object o)
        {
            Debug(o.ToString());
        }
        
        #endregion

        #region Log

        public void Log(string module, string message)
        {
            Program.LogThis(module, message);
        }

        #endregion

        #region Intercepting

        public void EnableIntercept()
        {
            Program.data.intercept = true;
            Program.formMain.ChangeIntercepting();
        }

        public void DisableIntercept()
        {
            Program.data.intercept = false;
            Program.formMain.ChangeIntercepting();
        }

        public bool IsIntercepting()
        {
            return Program.data.intercept;
        }
        
        #endregion

        #region hooking

        public int[] GetProcessPid(string name)
        {
            Process[] lstProcess = System.Diagnostics.Process.GetProcessesByName(name);

            int[] pids = new int[lstProcess.Count()];

            for (int i = 0 ; i < lstProcess.Count(); i++)
            {
                pids[i] = lstProcess[i].Id;
            }

            return pids;
        }

        public bool Attach(int pid)
        {
            return Program.hook.HookProcess(pid);
        }

        public bool Attach(string pname)
        {
            //bool hookedSuccessful = Program.hook.HookProcess(process);
            // Sin implementar
            return false;
        }

        #endregion

        #region GUI

        public void Show()
        {
            Program.formMain.Visible = true;
        }

        public void Hide()
        {
            Program.formMain.Visible = false;
        }

        public bool IsVisible()
        {
            return Program.formMain.Visible;
        }

        #endregion
    }

    public class PluginsAPINotExported
    {

        public byte[] SetSendBuffer(byte[] buffer)
        {
            byte[] newBuffer = null;
            bool modified = false;

            foreach (Plugin p in Program.data.pluginMngr.lstPlugins)
            {
                try
                {
                    // Convertimos el array de bytes a una lista, para que desde python sea más facil trabajar con el
                     List<byte> lstBytes;

                    if (!modified)
                        lstBytes = buffer.OfType<byte>().ToList();
                    else
                        lstBytes = newBuffer.OfType<byte>().ToList();

                    Func<List<Byte>, List<Byte>> f = p.scope.GetVariable("SetSendBuffer");
                    List<byte> newList = (List<byte>)f(lstBytes);
                    // La respuesta del plugin la volvemos a convertir a array de bytes
                    newBuffer = newList.ToArray<byte>();
                    modified = true;
                }
                catch
                {
                    // Si el script no tiene la funcion SetSendBuffer salta esta excepción
                }
                
            }

            if (modified)
                return newBuffer;
            return buffer;
        }

        public byte[] SetRecvBuffer(byte[] buffer)
        {
            byte[] newBuffer = null;
            bool modified = false;

            foreach (Plugin p in Program.data.pluginMngr.lstPlugins)
            {
                try
                {
                    // Convertimos el array de bytes a una lista, para que desde python sea más facil trabajar con el
                    List<byte> lstBytes;

                    if (!modified)
                        lstBytes = buffer.OfType<byte>().ToList();
                    else
                        lstBytes = newBuffer.OfType<byte>().ToList();

                    Func<List<Byte>, List<Byte>> f = p.scope.GetVariable("SetRecvBuffer");
                    List<byte> newList = (List<byte>)f(lstBytes);
                    // La respuesta del plugin la volvemos a convertir a array de bytes
                    newBuffer = newList.ToArray<byte>();
                    modified = true;
                }
                catch
                {
                    // Si el script no tiene la funcion SetRecvBuffer salta esta excepción
                }

            }
            if (modified)
                return newBuffer;
            return buffer;
        }
        
        /// <summary>
        /// Execute this python code in each one of the scripts that are loaded
        /// </summary>
        /// <param name="code"></param>
        public void ExecuteCodeInScriptsScopes(string code)
        {
            foreach (Plugin p in Program.data.pluginMngr.lstPlugins)
            {
                p.ExecuteInScope(code);
            }
        }
    }
}
