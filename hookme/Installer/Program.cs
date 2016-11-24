using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Principal;
using System.IO;
using System.Diagnostics;

namespace Installer
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Program p = new Program();
            p.Start();

            Console.WriteLine("\r\n\r\nPress <Enter> to exit ...");
            Console.ReadLine();
        }

        private bool Downloader()
        {
            DownloaderDependencies dependencies = new DownloaderDependencies();
            dependencies.CheckDependencies();

            if (dependencies.RequiereDependencies())
            {
                Console.WriteLine("Downloading dependencies. Please wait ...");
                FormDownloader fDownloader = new FormDownloader(dependencies);
                fDownloader.ShowDialog();

                if (fDownloader.success == false)
                    return true; // Se canceló la descarga o ocurrió algun problema
                return false;
            }

            return false;
        }

        private void RegisterDLLs()
        {
            string pathDll32 = "\"" + Directory.GetCurrentDirectory() + @"\" + "DeviareCOM.dll" + "\"";
            string pathDll64 = "\"" + Directory.GetCurrentDirectory() + @"\" + "DeviareCOM64.dll" + "\"";
            string fullPath = "regsvr32.exe /s /u " + pathDll32 + " & regsvr32.exe /s /u " + pathDll64 + " & regsvr32.exe /s " + pathDll32 + " & regsvr32.exe /s " + pathDll64;

            StreamWriter sw = System.IO.File.CreateText("register.bat");
            sw.WriteLine(fullPath);
            sw.Close();
            
            ProcessStartInfo startInfo;
            startInfo = new ProcessStartInfo("cmd.exe");
            startInfo.Arguments = "/k " + "\"" + Directory.GetCurrentDirectory() + @"\register.bat" + "\"";
            startInfo.Verb = "runas";
            System.Diagnostics.Process.Start(startInfo);
        }

        private void Start()
        {
            Console.WriteLine("Installing HookME\r\n");

            try
            {
                Console.WriteLine("Checking dependencies");
                if (Downloader())
                {
                    Console.WriteLine("Error downloading dependencies. Check your conection to internet and try again");
                }

                Console.WriteLine("Registering DLLs");
                RegisterDLLs();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
