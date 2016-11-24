using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Nektra.Deviare2;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security.Principal;
using System.Diagnostics;

namespace hook
{
    static class Program
    {
        public static FormMain formMain;
        public static Core.Hook hook;
        public static Core.Data data;
        public static Core.Console consoleHandler = new Core.Console();

        /// <summary>
        /// Global method to log messages
        /// </summary>
        /// <param name="msg"></param>
        public static void LogThis(string module, string msg)
        {
            formMain.LogThis(module, msg);
        }

        /// <summary>
        /// Global method to log messages in the API console
        /// </summary>
        /// <param name="msg"></param>
        public static void LogThisInAPIConsole(string msg)
        {

            formMain.LogThisInAPIConsole(msg);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
#if DEBUG
            /*
            args = new string[] {   "-h", 
                                    "-p", @"..\..\Scripts\MySQL_Backdoor.txt" ,
                                    "-p", @"..\..\Scripts\script01.txt",
                                    "-p", @"..\..\Scripts\DoesntExist.txt"
                                };
             */
#endif

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                hook = new Core.Hook();
                data = new Core.Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            consoleHandler.ProcessArguments(args);

            Program.data.configuration.LoadConfiguration();

            try
            {
                // Si desde la consola se le indica una licencia... se establece en la configuracion antes de arrancar el motor de deviare
                if (!string.IsNullOrEmpty(consoleHandler.licenseDeviareBase64))
                    Program.data.configuration.deviareLicenseBase64 = consoleHandler.licenseDeviareBase64;
                // Si no se ha cargado desde la consola, se carga la licencia desde el registro de windows, si es que existe
                if (!string.IsNullOrEmpty(Program.data.configuration.deviareLicenseBase64))
                    Program.hook.spyMgr.LicenseKey = Program.data.configuration.deviareLicenseBase64;

                bool spymgrInitialized = Program.hook.InitializeSpyMgr();

                if (spymgrInitialized == false) // Algo falla... la DLL parece no estar registrada.
                {
                    MessageBox.Show("Error [001] initializing Deviare Core. Please, execute 'installer.exe' before running HookME.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Error [002] initializing Deviare Core. Please, execute 'installer.exe' before running HookME.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            
            formMain = new FormMain();
            // Si se ha indicado un plugin desde la consola ...
            // Se cargaran en el OnLoad del formulario
            Application.Run(formMain);
        }

        public static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

    }
}
