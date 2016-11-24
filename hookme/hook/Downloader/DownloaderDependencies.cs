using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace hook.Downloader
{
    public class DownloaderDependencies
    {
        public string urlRepositorio = "http://www.itsm3.com/hookme/dependencies/";

        // Las dependencias, o ficheros que deberian existir
        private List<string> dependencies = new List<string>();
        // Los ficheros que faltan y serán necesarios descargar
        private List<string> requiered = new List<string>();

        public DownloaderDependencies()
        {
            dependencies.Add("Be.Windows.Forms.HexBox.dll");
            dependencies.Add("IronPython.dll");
            dependencies.Add("IronPython.Modules.dll");
            dependencies.Add("IronPython.Modules.xml");
            dependencies.Add("Microsoft.Dynamic.dll");
            dependencies.Add("Microsoft.Scripting.dll");
            dependencies.Add("DvAgent.dll");
            dependencies.Add("Nektra.Deviare2.dll");
            dependencies.Add("DeviareCOM.dll");
            dependencies.Add("DeviareCOM64.dll");
            dependencies.Add("Deviare32.db");
            dependencies.Add("Deviare64.db");
        }

        public void CheckDependencies()
        {
            requiered.Clear(); 
            string path = Directory.GetCurrentDirectory();

            foreach (string file in dependencies)
            {
                System.Diagnostics.Process.GetCurrentProcess();
                if (!File.Exists(path + @"\" + file))
                {
                    requiered.Add(file);
                }
            }
        }

        public bool RequiereDependencies()
        {
            if (requiered.Count > 0)
                return true;
            return false;
        }

        public List<string> GetRequiered()
        {
            return requiered;
        }


    }
}
