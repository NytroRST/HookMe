using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security;
using System.Diagnostics;

namespace hook.Core
{
    class Console
    {
        public bool hidden = false;
        public List<string> pluginsToLoad = new List<string>();
        public string licenseDeviareBase64 = string.Empty;

        public void ProcessArguments(string[] args)
        {
            for (int i = 0; i < args.Count(); i++)
            {
                string arg = args[i];

                switch (arg)
                {
                    case "-p":
                        // plugins
                        if (args.Count() > i+1)
                        {
                            string plugin = args[i + 1];
                            pluginsToLoad.Add(plugin);
                        }
                        break;

                    case "-h":
                        // hidden
                        hidden = true;
                        break;

                    case "-l":
                        // licencia deviare
                        if (args.Count() > i+1)
                        {
                            string license = args[i + 1];
                            licenseDeviareBase64 = license;
                        }
                        break;
                }

            }
        }
    }

    
}
