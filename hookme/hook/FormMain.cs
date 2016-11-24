using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Nektra.Deviare2;
using hook.wrappers;
using Be.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Threading;
using System.Diagnostics;

namespace hook
{
    public partial class FormMain : Form
    {
        #region ProcessFunctions

        private bool ProcessEncryptMessage(FunctionWrapper f)
        {
            Core.ProcessFunctions.EncryptMessage fEncryptMessage = new Core.ProcessFunctions.EncryptMessage(f);
            byte[] buffer = fEncryptMessage.GetBuffer();

            if (buffer == null)
            {

                lbFunction.Invoke(new MethodInvoker(delegate
                {
                    lbFunction.Text = "";
                }));

                f.status = FunctionWrapper.Status.Forwarded;
                return false;
            }

            DynamicFileByteProvider dynamicFileByteProvider;
            mStream = new MemoryStream();
            mStream.Write(buffer, 0, buffer.Length);
            mStream.Seek(0, SeekOrigin.Begin);
            dynamicFileByteProvider = new DynamicFileByteProvider(mStream);
            hexBox.Invoke(new MethodInvoker(delegate
            {
                hexBox.ByteProvider = dynamicFileByteProvider;
            }));
            Search(0);

            return true;
        }

        private bool ProcessDecryptMessage(FunctionWrapper f)
        {
            Core.ProcessFunctions.DecryptMessage fDecryptMessage = new Core.ProcessFunctions.DecryptMessage(f);
            byte[] buffer = fDecryptMessage.GetBuffer();

            if (buffer == null)
            {

                lbFunction.Invoke(new MethodInvoker(delegate
                {
                    lbFunction.Text = "";
                }));

                f.status = FunctionWrapper.Status.Forwarded;
                return false;
            }

            DynamicFileByteProvider dynamicFileByteProvider;
            mStream = new MemoryStream();
            mStream.Write(buffer, 0, buffer.Length);
            mStream.Seek(0, SeekOrigin.Begin);
            dynamicFileByteProvider = new DynamicFileByteProvider(mStream);
            hexBox.Invoke(new MethodInvoker(delegate
            {
                hexBox.ByteProvider = dynamicFileByteProvider;
            }));
            Search(0);

            return true;
        }

        private bool ProcessSend(FunctionWrapper f)
        {
            Core.ProcessFunctions.send fSend = new Core.ProcessFunctions.send(f);
            byte[] buffer = fSend.GetBuffer();

            DynamicFileByteProvider dynamicFileByteProvider;
            mStream = new MemoryStream();
            mStream.Write(buffer, 0, buffer.Length);
            mStream.Seek(0, SeekOrigin.Begin);
            dynamicFileByteProvider = new DynamicFileByteProvider(mStream);
            hexBox.Invoke(new MethodInvoker(delegate
            {
                hexBox.ByteProvider = dynamicFileByteProvider;
            }));
            Search(0);

            return true;
        }

        private bool ProcessSendTo(FunctionWrapper f)
        {
            Core.ProcessFunctions.sendto fSendto = new Core.ProcessFunctions.sendto(f);
            byte[] buffer = fSendto.GetBuffer();

            DynamicFileByteProvider dynamicFileByteProvider;
            mStream = new MemoryStream();
            mStream.Write(buffer, 0, buffer.Length);
            mStream.Seek(0, SeekOrigin.Begin);
            dynamicFileByteProvider = new DynamicFileByteProvider(mStream);
            hexBox.Invoke(new MethodInvoker(delegate
            {
                hexBox.ByteProvider = dynamicFileByteProvider;
            }));
            Search(0);

            return true;
        }

        private bool ProcessRecv(FunctionWrapper f)
        {
            Core.ProcessFunctions.recv fRecv = new Core.ProcessFunctions.recv(f);
            byte[] buffer = fRecv.GetBuffer();
            
            // Esto ocurre cuando la funcion devuelve -1 bytes leidos. Cuando no quedan mas datos que leer.
            if (buffer == null || buffer.Length == 0)
            {
                lbFunction.Invoke(new MethodInvoker(delegate
                {
                    lbFunction.Text = "";
                }));

                // Hacemos forward de la función y aceptamos nuevas
                f.status = FunctionWrapper.Status.Forwarded;
                //Program.data.AceptingNewFunctions = true;



                return false;
            }

            DynamicFileByteProvider dynamicFileByteProvider;
            mStream = new MemoryStream();
            mStream.Write(buffer, 0, buffer.Length);
            mStream.Seek(0, SeekOrigin.Begin);
            dynamicFileByteProvider = new DynamicFileByteProvider(mStream);
            hexBox.Invoke(new MethodInvoker(delegate
            {
                hexBox.ByteProvider = dynamicFileByteProvider;
            }));
            Search(0);

            return true;
        }

        private bool ProcessRecvFrom(FunctionWrapper f)
        {
            Core.ProcessFunctions.recvfrom fRecvfrom = new Core.ProcessFunctions.recvfrom(f);
            byte[] buffer = fRecvfrom.GetBuffer();

            // Esto ocurre cuando la funcion devuelve -1 bytes leidos. Cuando no quedan mas datos que leer.
            if (buffer == null || buffer.Length == 0)
            {
                // Hacemos forward de la función y aceptamos nuevas
                f.status = FunctionWrapper.Status.Forwarded;
                //Program.data.AceptingNewFunctions = true;

                lbFunction.Invoke(new MethodInvoker(delegate
                {
                    lbFunction.Text = "";
                }));

                return false;
            }

            DynamicFileByteProvider dynamicFileByteProvider;
            mStream = new MemoryStream();
            mStream.Write(buffer, 0, buffer.Length);
            mStream.Seek(0, SeekOrigin.Begin);
            dynamicFileByteProvider = new DynamicFileByteProvider(mStream);
            hexBox.Invoke(new MethodInvoker(delegate
            {
                hexBox.ByteProvider = dynamicFileByteProvider;
            }));
            Search(0);

            return true;
        }

        private bool ProcessWSASend(FunctionWrapper f)
        {
            Core.ProcessFunctions.WSAsend wsaSend = new Core.ProcessFunctions.WSAsend(f);
            byte[] buffer = wsaSend.GetBuffer();

            DynamicFileByteProvider dynamicFileByteProvider;
            mStream = new MemoryStream();
            mStream.Write(buffer, 0, buffer.Length);
            mStream.Seek(0, SeekOrigin.Begin);
            dynamicFileByteProvider = new DynamicFileByteProvider(mStream);
            hexBox.Invoke(new MethodInvoker(delegate
            {
                hexBox.ByteProvider = dynamicFileByteProvider;
            }));
            Search(0);

            return true;
        }

        private bool ProcessWSASendTo(FunctionWrapper f)
        {
            f.status = FunctionWrapper.Status.Forwarded;
            //Program.data.AceptingNewFunctions = true;

            lbFunction.Invoke(new MethodInvoker(delegate
            {
                lbFunction.Text = "";
            }));
            return true;
            throw new Exception("Not implemented");
        }

        private bool ProcessWSARecv(FunctionWrapper f)
        {
            Core.ProcessFunctions.WSArecv fWSArecv = new Core.ProcessFunctions.WSArecv(f);
            byte[] buffer = fWSArecv.GetBuffer();
            
            // Esto ocurre cuando la funcion devuelve -1 bytes leidos. Cuando no quedan mas datos que leer.
            // O cuando la primera estructura de wsabuff tiene una longitud de 0 bytes (aunque la segunda tenga datos, se omiten, forwardeando el paquete)
            if (buffer == null || buffer.Length == 0)
            {
                lbFunction.Invoke(new MethodInvoker(delegate
                {
                    lbFunction.Text = "";
                }));

                // Hacemos forward de la función y aceptamos nuevas
                f.status = FunctionWrapper.Status.Forwarded;
                //Program.data.AceptingNewFunctions = true;

               

                return false;
            }

            DynamicFileByteProvider dynamicFileByteProvider;
            mStream = new MemoryStream();
            mStream.Write(buffer, 0, buffer.Length);
            mStream.Seek(0, SeekOrigin.Begin);
            dynamicFileByteProvider = new DynamicFileByteProvider(mStream);
            hexBox.Invoke(new MethodInvoker(delegate
            {
                hexBox.ByteProvider = dynamicFileByteProvider;
            }));
            Search(0);

            return true;
        }

        private bool ProcessWSARecvFrom(FunctionWrapper f)
        {
            f.status = FunctionWrapper.Status.Forwarded;
            //Program.data.AceptingNewFunctions = true;

            lbFunction.Invoke(new MethodInvoker(delegate
            {
                lbFunction.Text = "";
            }));

            return true;
            throw new Exception("Not implemented");
        }
        #endregion

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }
        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        MemoryStream mStream;
        MemoryStream mStreamSearch;

        public FormMain()
        {
                InitializeComponent();
                this.Text = AssemblyTitle + " " + AssemblyVersion;

                Program.data.pluginMngr.pluginLoaded += new Plugins.PluginManager.pluginLoadedEvent(pluginMngr_pluginLoaded);
                Program.data.pluginMngr.pluginUnloaded += new Plugins.PluginManager.pluginUnLoadedEvent(pluginMngr_pluginUnloaded);

                mStreamSearch = new MemoryStream();
                DynamicFileByteProvider dynamicFileByteProviderSearch = new DynamicFileByteProvider(mStreamSearch);
                hexBoxSearch.ByteProvider = dynamicFileByteProviderSearch;
        }

        void pluginMngr_pluginUnloaded(Plugins.Plugin plugin)
        {
            lbLoadedScripts.Invoke(new MethodInvoker(delegate
            {
                lbLoadedScripts.Items.Remove(plugin);
            }));
        }

        void pluginMngr_pluginLoaded(Plugins.Plugin plugin)
        {
            lbLoadedScripts.Invoke(new MethodInvoker(delegate
                {
                    lbLoadedScripts.Items.Add(plugin);
                }));
        }

        #region MenuItems actions
        private void attachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectProgram fSelecProgram = new FormSelectProgram();
            fSelecProgram.StartPosition = FormStartPosition.CenterParent;
            fSelecProgram.ShowDialog();

            if (fSelecProgram.returnedValue == null)
                return;

            NktProcess process = fSelecProgram.returnedValue;
            bool hookedSuccessful = Program.hook.HookProcess(process);

            if (hookedSuccessful)
            {
                FormInfo fInfo = new FormInfo("Hook successful", 0, FormInfo.IconType.OK);
                fInfo.StartPosition = FormStartPosition.CenterParent;
                fInfo.Show(Program.formMain);

                Program.LogThis("Core", "Process " + process.Name + " hooked successfully");
            }
            else
            {
                FormInfo fInfo = new FormInfo("Error hooking", 0, FormInfo.IconType.Error);
                fInfo.StartPosition = FormStartPosition.CenterParent;
                fInfo.Show(Program.formMain);

                Program.LogThis("Core", "Error hooking " + process.Name );
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAbout().ShowDialog();
        }
        #endregion

        public void LogThis(string module, string msg)
        {
            listViewLog.Invoke(new MethodInvoker(delegate
            {
                ListViewItem lvi = listViewLog.Items.Add(DateTime.Now.ToShortTimeString());
                lvi.SubItems.Add(module);
                lvi.SubItems.Add(msg);
                lvi.EnsureVisible();
            }));
        }

        public void LogThisInAPIConsole(string msg)
        {
            apiOutputConsole.Invoke(new MethodInvoker(delegate
            {
                apiOutputConsole.Text += msg;

                apiOutputConsole.SelectionStart = apiOutputConsole.Text.Length;
                apiOutputConsole.ScrollToCaret();
                apiOutputConsole.Refresh();
            }));
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
                tabControl1.TabPages.Remove(tabFuzzer);
                tabControl1.TabPages.Remove(tabRepeater);

                Thread tPool = new Thread(new ThreadStart(Pool));
                tPool.IsBackground = true;
                tPool.Start();

                lbFunction.Text = "";

                cbIntercepting.Checked = Program.data.intercept;


                if (Program.data.intercept)
                    cbIntercepting.Text = "Intercepting is ON";
                else
                    cbIntercepting.Text = "Intercepting is OFF";

                Program.data.NewMatchAndReplace += new Core.Data.matchAndReplaceHandler(data_NewMatchAndReplace);
                Program.LogThis("Core", "Program started");


                // Si se ha indicado un plugin desde la consola, se carga aqui
                foreach (string pString in Program.consoleHandler.pluginsToLoad)
                {
                    Plugins.Plugin p = new Plugins.Plugin(pString);
                    Program.data.pluginMngr.Load(p);
                }

                wBrowser.Navigate(Program.data.configuration.urlSponsor);
        }

        void data_NewMatchAndReplace(MatchAndReplace.MatchAndReplace matchAndReplace)
        {
            string typeMatch = string.Empty;

            if (matchAndReplace.replaceIncomming && matchAndReplace.replaceOutcomming)
                typeMatch = "In/Out";
            else if (matchAndReplace.replaceIncomming)
                typeMatch = "In";
            else 
                typeMatch = "Out";

            object[] row = new object[] 
            { 
                matchAndReplace.enabled,
                typeMatch,
                matchAndReplace.name,
                ASCIIEncoding.ASCII.GetString(matchAndReplace.match),
                ASCIIEncoding.ASCII.GetString(matchAndReplace.replace)
            };

            dgvMatchAndReplace.Rows.Add(row);
            dgvMatchAndReplace.Rows[dgvMatchAndReplace.Rows.Count - 1].Tag = matchAndReplace;
        }

        private  void Pool()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(0);

                if (Program.data.AceptingNewFunctions == false)
                    continue;
                if (Program.hook.stackFunctions.Count == 0)
                    continue;

                Program.data.AceptingNewFunctions = false;
                Program.data.currentFunction = (FunctionWrapper)Program.hook.stackFunctions.Pop();

                if (Program.data.currentFunction == null)
                {
                    Program.data.AceptingNewFunctions = true;
                    continue;
                }

                if (Program.data.intercept == false)
                {
                    // Aqui habria que hacer el remplazo de matchandreplace antes de forwardear
                    // Pero para eso primero es necesario completar todos los manejadores de todas las funcionesif 
                    ForwardFunction();
                    continue ;
                }

                lbFunction.Invoke(new MethodInvoker(delegate
                {
                    try
                    {
                        lbFunction.Text = Program.data.currentFunction.Hook.FunctionName;
                    }
                    catch
                    {
                    }
                }));
                hexBox.Invoke(new MethodInvoker(delegate
                    {
                        try
                        {
                            hexBox.ByteProvider = null;
                        }
                        catch
                        {
                        }
                    }));

                bool neededToForward = false;
              
                // SSL
                if (Program.data.currentFunction.Hook.FunctionName.ToLower() == "Secur32.dll!EncryptMessage".ToLower())
                    neededToForward = ProcessEncryptMessage(Program.data.currentFunction);
                else if (Program.data.currentFunction.Hook.FunctionName.ToLower() == "Secur32.dll!DecryptMessage".ToLower())
                    neededToForward = ProcessDecryptMessage(Program.data.currentFunction);
                // conexiones red
                else if (Program.data.currentFunction.Hook.FunctionName.ToLower() == "WS2_32.dll!Send".ToLower())
                    neededToForward = ProcessSend(Program.data.currentFunction);
                else if (Program.data.currentFunction.Hook.FunctionName.ToLower() == "WS2_32.dll!Recv".ToLower())
                    neededToForward = ProcessRecv(Program.data.currentFunction);
                else if (Program.data.currentFunction.Hook.FunctionName.ToLower() == "WS2_32.dll!SendTo".ToLower())
                    neededToForward = ProcessSendTo(Program.data.currentFunction);
                else if (Program.data.currentFunction.Hook.FunctionName.ToLower() == "WS2_32.dll!RecvFrom".ToLower())
                    neededToForward = ProcessRecvFrom(Program.data.currentFunction);
                else if (Program.data.currentFunction.Hook.FunctionName.ToLower() == "WS2_32.dll!WSASend".ToLower())
                    neededToForward = ProcessWSASend(Program.data.currentFunction);
                else if (Program.data.currentFunction.Hook.FunctionName.ToLower() == "WS2_32.dll!WSASendTo".ToLower())
                    neededToForward = ProcessWSASendTo(Program.data.currentFunction); // no implementado
                else if (Program.data.currentFunction.Hook.FunctionName.ToLower() == "WS2_32.dll!WSARecv".ToLower())
                    neededToForward = ProcessWSARecv(Program.data.currentFunction);
                else if (Program.data.currentFunction.Hook.FunctionName.ToLower() == "WS2_32.dll!WSARecvFrom".ToLower())
                    neededToForward = ProcessWSARecvFrom(Program.data.currentFunction); // no implementado

                if (neededToForward == false)
                    continue;
            }
        }

        /// <summary>
        /// Se encarga de forwardear una funcion cuando no se está interceptando. Tambien aplica los filtros de match and replace
        /// </summary>
        private void AutoForwardFunction()
        {
            /* Prepares the function to apply 'matchs and replaces' */

            if (Program.data.currentFunction.Hook.FunctionName.ToLower() == "WS2_32.dll!Send".ToLower())
            {
                Core.ProcessFunctions.send s = new Core.ProcessFunctions.send(Program.data.currentFunction);
                byte[] sendBuffer = s.GetBuffer();

                if (sendBuffer != null && sendBuffer.Length > 0)
                    Program.data.currentFunction = Core.ProcessFunctions.send.PrepareFunction(Program.data.currentFunction, sendBuffer);
            }
            else if (Program.data.currentFunction.Hook.FunctionName.ToLower() == "WS2_32.dll!Recv".ToLower())
            {
                Core.ProcessFunctions.recv r = new Core.ProcessFunctions.recv(Program.data.currentFunction);
                byte[] recvBuffer = r.GetBuffer();

                if (recvBuffer != null && recvBuffer.Length>0)
                    Program.data.currentFunction = Core.ProcessFunctions.recv.PrepareFunction(Program.data.currentFunction, recvBuffer);
            }
            else if (Program.data.currentFunction.Hook.FunctionName.ToLower() == "WS2_32.dll!SendTo".ToLower())
            {
                Core.ProcessFunctions.sendto st = new Core.ProcessFunctions.sendto(Program.data.currentFunction);
                byte[] sendToBuffer = st.GetBuffer();

                if (sendToBuffer != null && sendToBuffer.Length > 0)
                    Program.data.currentFunction = Core.ProcessFunctions.recv.PrepareFunction(Program.data.currentFunction, sendToBuffer);
            }
            else if (Program.data.currentFunction.Hook.FunctionName.ToLower() == "WS2_32.dll!RecvFrom".ToLower())
            {
                Core.ProcessFunctions.recvfrom rf = new Core.ProcessFunctions.recvfrom(Program.data.currentFunction);
                byte[] recvFromBuffer = rf.GetBuffer();

                if (recvFromBuffer != null && recvFromBuffer.Length > 0)
                    Program.data.currentFunction = Core.ProcessFunctions.recv.PrepareFunction(Program.data.currentFunction, recvFromBuffer);                
            }
            else if (Program.data.currentFunction.Hook.FunctionName.ToLower() == "WS2_32.dll!WSASend".ToLower())
            {

                Core.ProcessFunctions.WSAsend wsas = new Core.ProcessFunctions.WSAsend(Program.data.currentFunction);
                byte[] wsasBuffer = wsas.GetBuffer();

                if (wsasBuffer != null && wsasBuffer.Length > 0)
                    Program.data.currentFunction = Core.ProcessFunctions.WSAsend.PrepareFunction(Program.data.currentFunction, wsasBuffer); 
            }
            else if (Program.data.currentFunction.Hook.FunctionName.ToLower() == "WS2_32.dll!WSASendTo".ToLower())
                throw new Exception("not implemented");
            else if (Program.data.currentFunction.Hook.FunctionName.ToLower() == "WS2_32.dll!WSARecv".ToLower())
            {

                Core.ProcessFunctions.WSArecv wsar = new Core.ProcessFunctions.WSArecv(Program.data.currentFunction);
                byte[] wsarBuffer = wsar.GetBuffer();

                if (wsarBuffer != null && wsarBuffer.Length > 0)
                    Program.data.currentFunction = Core.ProcessFunctions.WSArecv.PrepareFunction(Program.data.currentFunction, wsarBuffer);

            }
            else if (Program.data.currentFunction.Hook.FunctionName.ToLower() == "Secur32.dll!EncryptMessage".ToLower())
            {

                Core.ProcessFunctions.EncryptMessage encMessage = new Core.ProcessFunctions.EncryptMessage(Program.data.currentFunction);
                byte[] encMessageBuffer = encMessage.GetBuffer();

                if (encMessageBuffer != null && encMessageBuffer.Length > 0)
                    Program.data.currentFunction = Core.ProcessFunctions.WSArecv.PrepareFunction(Program.data.currentFunction, encMessageBuffer);

            }
            else if (Program.data.currentFunction.Hook.FunctionName.ToLower() == "Secur32.dll!DecryptMessage".ToLower())
            {

                Core.ProcessFunctions.DecryptMessage decMessage = new Core.ProcessFunctions.DecryptMessage(Program.data.currentFunction);
                byte[] decMessageBuffer = decMessage.GetBuffer();

                if (decMessageBuffer != null && decMessageBuffer.Length > 0)
                    Program.data.currentFunction = Core.ProcessFunctions.WSArecv.PrepareFunction(Program.data.currentFunction, decMessageBuffer);

            }
            else if (Program.data.currentFunction.Hook.FunctionName.ToLower() == "WS2_32.dll!WSARecvFrom".ToLower())
                throw new Exception("not implemented");
            else
                throw new Exception("Unknow handler");

            Program.data.currentFunction.status = wrappers.FunctionWrapper.Status.Forwarded;
            //Program.data.AceptingNewFunctions = true;
        }

        private void ForwardFunction()
        {
            if (Program.data.intercept == false)
            {
                AutoForwardFunction();
                return;
            }

            hexBox.ByteProvider.ApplyChanges();
            byte[] buffer = new byte[mStream.Length];
            mStream.Position = 0;
            mStream.Read(buffer, 0, (int)mStream.Length);

            if (Program.data.currentFunction.Hook.FunctionName.ToLower() == "WS2_32.dll!Send".ToLower())
                Program.data.currentFunction = Core.ProcessFunctions.send.PrepareFunction(Program.data.currentFunction, buffer);
            else if (Program.data.currentFunction.Hook.FunctionName.ToLower() == "WS2_32.dll!Recv".ToLower())
                Program.data.currentFunction = Core.ProcessFunctions.recv.PrepareFunction(Program.data.currentFunction, buffer);
            else if (Program.data.currentFunction.Hook.FunctionName.ToLower() == "WS2_32.dll!SendTo".ToLower())
                Program.data.currentFunction = Core.ProcessFunctions.sendto.PrepareFunction(Program.data.currentFunction, buffer);
            else if (Program.data.currentFunction.Hook.FunctionName.ToLower() == "WS2_32.dll!RecvFrom".ToLower())
                Program.data.currentFunction = Core.ProcessFunctions.recvfrom.PrepareFunction(Program.data.currentFunction, buffer);
            else if (Program.data.currentFunction.Hook.FunctionName.ToLower() == "WS2_32.dll!WSASend".ToLower())
                Program.data.currentFunction = Core.ProcessFunctions.WSAsend.PrepareFunction(Program.data.currentFunction, buffer);
            else if (Program.data.currentFunction.Hook.FunctionName.ToLower() == "WS2_32.dll!WSASendTo".ToLower())
                throw new Exception("not implemented");
            else if (Program.data.currentFunction.Hook.FunctionName.ToLower() == "WS2_32.dll!WSARecv".ToLower())
                Program.data.currentFunction = Core.ProcessFunctions.WSArecv.PrepareFunction(Program.data.currentFunction, buffer);
            else if (Program.data.currentFunction.Hook.FunctionName.ToLower() == "WS2_32.dll!WSARecvFrom".ToLower())
                throw new Exception("not implemented");
            else if (Program.data.currentFunction.Hook.FunctionName.ToLower() == "Secur32.dll!EncryptMessage".ToLower())
                Program.data.currentFunction = Core.ProcessFunctions.EncryptMessage.PrepareFunction(Program.data.currentFunction, buffer);
            else if (Program.data.currentFunction.Hook.FunctionName.ToLower() == "Secur32.dll!DecryptMessage".ToLower())
                Program.data.currentFunction = Core.ProcessFunctions.DecryptMessage.PrepareFunction(Program.data.currentFunction, buffer);
            else
                throw new Exception("Handler not implemented");

            Program.data.currentFunction.status = wrappers.FunctionWrapper.Status.Forwarded;
            //Program.data.AceptingNewFunctions = true;
            //if (Program.hook.stackFunctions.Count > 0)
            //    Hook_eventNewFunction();
        }


        private void DropFunction()
        {
            
            Program.data.currentFunction.status = wrappers.FunctionWrapper.Status.Droped;
            //Program.data.AceptingNewFunctions = true;
            //if (Program.hook.stackFunctions.Count > 0)
            //    Hook_eventNewFunction();
        }

        private void btForward_Click(object sender, EventArgs e)
        {
            //if (Program.data.currentFunction == null)
            //    return;
            if (hexBox.ByteProvider == null)
                return;

            ForwardFunction();
            //hexBox.ByteProvider = null;
            //Program.data.currentFunction = null; // Uf, puede ser que la ponga a null ates de que se forwardee por core/hook.cs ???

            lbFunction.Invoke(new MethodInvoker(delegate
            {
                lbFunction.Text = "";
            }));
            hexBox.Invoke(new MethodInvoker(delegate
                {
                    hexBox.ByteProvider = null;
                }));
        }

        private void btDrop_Click(object sender, EventArgs e)
        {

            //if (Program.data.currentFunction == null)
           //     return;
            if (hexBox.ByteProvider == null)
                return;

            DropFunction();
            hexBox.ByteProvider = null;
            //Program.data.currentFunction = null;

            lbFunction.Invoke(new MethodInvoker(delegate
            {
                lbFunction.Text = "";
            }));
        }

        /// <summary>
        /// Updates the GUI and forwards the functions in the stack. This function is called from GUI and Plugins
        /// </summary>
        public void ChangeIntercepting()
        {
            if (Program.data.intercept)
            {
                cbIntercepting.Text = "Intercepting is ON";
                cbIntercepting.Checked = true;
            }
            else
            {
                cbIntercepting.Text = "Intercepting is OFF";
                cbIntercepting.Checked = false;

                if (Program.data.currentFunction != null)
                {
                    ForwardFunction();
                    hexBox.ByteProvider = null;
                }

                lbFunction.Invoke(new MethodInvoker(delegate
                {
                    lbFunction.Text = "";
                }));
            }
        }

        private void cbIntercepting_CheckedChanged(object sender, EventArgs e)
        {
            Program.data.intercept = cbIntercepting.Checked;
            ChangeIntercepting(); // Updates the GUI and forwards the functions in the stack
        }

        private void Search(int entry)
        {
            //if (Program.data.currentFunction == null)
           //     return;
            if (hexBox.ByteProvider == null)
                return;
            if (hexBoxSearch.ByteProvider == null)
                return;
            
            hexBoxSearch.ByteProvider.ApplyChanges();
            byte[] bufferMatch = new byte[mStreamSearch.Length];
            mStreamSearch.Seek(0, SeekOrigin.Begin);
            mStreamSearch.Read(bufferMatch, 0, bufferMatch.Length);

            if (bufferMatch.Length == 0)
            {
                lbMatches.Invoke(new MethodInvoker(delegate
                {
                    lbMatches.Text = "matches 0";
                }));
                return;
            }

            byte[] bufferContent = new byte[mStream.Length];
            mStream.Seek(0, SeekOrigin.Begin);
            mStream.Read(bufferContent, 0, bufferContent.Length);

            int entryPoint = Searcher.Searcher.Search(bufferContent, bufferMatch, entry);

            if (entryPoint != -1)
            {
                hexBox.Invoke(new MethodInvoker(delegate
                    {
                        hexBox.SelectionStart = entryPoint;
                        hexBox.SelectionLength = bufferMatch.Length;
                    }));
            }
            else
            {
                hexBox.Invoke(new MethodInvoker(delegate
                    {
                        hexBox.SelectionStart = 0;
                        hexBox.SelectionLength = 0;
                    }));
            }

            lbMatches.Invoke(new MethodInvoker(delegate
                {
                    lbMatches.Text = "matches " + Searcher.Searcher.CountMatches(bufferContent, bufferMatch);
                }));
        }
 

        private void hexBoxSearch_CurrentPositionInLineChanged(object sender, EventArgs e)
        {
            Search(0);
        }

        private void newMatchReplace_Click(object sender, EventArgs e)
        {
            FormMatchReplace f = new FormMatchReplace();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();

            if (f.returnedMatch != null)
                Program.data.AddMatchAndReplace(f.returnedMatch);
        }

        private void removeMatchReplace_Click(object sender, EventArgs e)
        {
            if (dgvMatchAndReplace.SelectedRows.Count == 0)
                return;

            // remove from data
            MatchAndReplace.MatchAndReplace match = (MatchAndReplace.MatchAndReplace)dgvMatchAndReplace.SelectedRows[0].Tag;
            Program.data.RemoveMatchAndReplace(match);
            // remove from gui
            dgvMatchAndReplace.Rows.Remove(dgvMatchAndReplace.SelectedRows[0]);
        }

        private void btLoadPlugin_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Plugins.Plugin p = new Plugins.Plugin(ofd.FileName);
                Program.data.pluginMngr.Load(p);
            }
            
        }

        private void tbInputTxtScripts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                apiOutputConsole.Text += ">>> " + tbInputTxtScripts.Text + "\r\n";
                Program.data.pluginMngr.pluginsApiNotExported.ExecuteCodeInScriptsScopes(tbInputTxtScripts.Text);
                tbInputTxtScripts.Text = "";

                apiOutputConsole.SelectionStart = apiOutputConsole.Text.Length;
                apiOutputConsole.ScrollToCaret();
                apiOutputConsole.Refresh();
            }
        }


        private void btUnloadPlugin_Click(object sender, EventArgs e)
        {
            if (lbLoadedScripts.SelectedItem == null)
                return;

            hook.Plugins.Plugin p = (hook.Plugins.Plugin) lbLoadedScripts.SelectedItem;
            Program.data.pluginMngr.Unload(p);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
            FormOpenProcess fop = new FormOpenProcess();
            fop.ShowDialog();

            if (fop.p != null)
            {
                bool r = true;

                try
                {
                   r = fop.p.Start();
                }
                catch
                {
                    //MessageBox.Show(ex.Message);
                    r = false;
                }

                if (r == false)
                    MessageBox.Show("Error starting " + fop.p.StartInfo.FileName);
                else
                {
                    try
                    {
                        // Puede dar una excepcion si la app no tiene una interfaz grafica
                        fop.p.WaitForInputIdle(1000);
                    }
                    catch
                    {
                        
                    }

                    foreach (NktProcess process in Program.hook.spyMgr.Processes())
                    {
                        if (process.Id == fop.p.Id)
                        {
                            bool hookedSuccessful = Program.hook.HookProcess(process);

                            if (hookedSuccessful)
                            {
                                FormInfo fInfo = new FormInfo("Hook successful", 0, FormInfo.IconType.OK);
                                fInfo.StartPosition = FormStartPosition.CenterParent;
                                fInfo.Show(Program.formMain);

                                Program.LogThis("Core", "Process " + process.Name + " hooked successfully");
                            }
                            else
                            {
                                FormInfo fInfo = new FormInfo("Error hooking", 0, FormInfo.IconType.Error);
                                fInfo.StartPosition = FormStartPosition.CenterParent;
                                fInfo.Show(Program.formMain);

                                Program.LogThis("Core", "Error hooking " + process.Name);
                            }
                            break;
                        }
                    }
                    
                }
            }
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfiguration fConf = new FormConfiguration();
            fConf.ShowDialog();
        }

        private void linkSponsorUs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:hookmesoftware@gmail.com");
        }

        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLicense frmLicense = new FormLicense();
            frmLicense.ShowDialog();
        }

        private void unhookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.hook.process == null)
                return;

            bool r = Program.hook.UnHook();

            if (r)
            {
                FormInfo fInfo = new FormInfo("Unhooked!", 0, FormInfo.IconType.OK);
                fInfo.StartPosition = FormStartPosition.CenterParent;
                fInfo.Show(Program.formMain);

                Program.LogThis("Core", "Process " + Program.hook.process.Name + " unhooked");
                Program.hook.process = null;
            }
            else
            {
                FormInfo fInfo = new FormInfo("Error hooking", 0, FormInfo.IconType.Error);
                fInfo.StartPosition = FormStartPosition.CenterParent;
                fInfo.Show(Program.formMain);

                Program.LogThis("Core", "Error hooking " + Program.hook.process.Name);
            }
        }

        private void fileToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            if (Program.hook.process == null)
            {
                openToolStripMenuItem.Enabled = true;
                attachToolStripMenuItem.Enabled = true;
                unhookToolStripMenuItem.Enabled = false;
            }
            else
            {
                openToolStripMenuItem.Enabled = false;
                attachToolStripMenuItem.Enabled = false;
                unhookToolStripMenuItem.Enabled = true;
            }
                
        }

        
        
    }
}
