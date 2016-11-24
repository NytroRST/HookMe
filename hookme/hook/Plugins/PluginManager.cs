using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IronPython.Hosting;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;
using System.IO;

namespace hook.Plugins
{
    class PluginManager
    {
        public delegate void pluginLoadedEvent(Plugin plugin);
        public event pluginLoadedEvent pluginLoaded;

        public delegate void pluginUnLoadedEvent(Plugin plugin);
        public event pluginUnLoadedEvent pluginUnloaded;

        // http://secretgeek.net/host_ironpython.asp

        public List<Plugin> lstPlugins = new List<Plugin>();

        
        public PluginsAPI pluginsApi = new PluginsAPI();
        public PluginsAPINotExported pluginsApiNotExported = new PluginsAPINotExported();

        public PluginManager()
        {

        }

        public void Load(Plugin p)
        {
            if (File.Exists(p.filename))
            {
                lstPlugins.Add(p);

                if (pluginLoaded != null)
                    pluginLoaded(p);

                p.ExecuteCode();
            }
            else
            {
                Program.LogThis("Core", "Plugin " + p.filename + " doesn't exist");
            }
        }

        public void Unload(Plugin p)
        {
            lstPlugins.Remove(p);

            if (pluginUnloaded != null)
                pluginUnloaded(p);
        }

    }
}
