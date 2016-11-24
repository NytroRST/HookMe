using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Scripting.Hosting;
using IronPython.Hosting;
using System.IO;
using Microsoft.Scripting;

namespace hook.Plugins
{
    class Plugin
    {
        public ScriptEngine engine = Python.CreateEngine();
        public ScriptScope scope = null;
        public string filename;

        public Plugin(string filename)
        {
            this.filename = filename;
            scope = engine.CreateScope();
            scope.SetVariable("hookme", Program.data.pluginMngr.pluginsApi);
            engine.SetSearchPaths(Program.data.configuration.lstPluginsSearchPath);
        }

        private string LoadScript(string filePath)
        {

            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string code = sr.ReadToEnd();

            sr.Close();
            fs.Close();
            return code;
        }

        public void ExecuteCode()
        {
            string code = LoadScript(filename);

            ScriptSource source = engine.CreateScriptSourceFromString(code, SourceCodeKind.AutoDetect);

            try
            {
                source.Execute(scope);
            }
            catch (Exception ex)
            {
                Program.data.pluginMngr.pluginsApi.Debug("ERROR: " + ex.Message);
            }
        }

        public void ExecuteInScope(string code)
        {
            ScriptSource source = engine.CreateScriptSourceFromString(code, SourceCodeKind.AutoDetect);

            try
            {
                source.Execute(scope);
            }
            catch (Exception ex)
            {
                Program.data.pluginMngr.pluginsApi.Debug("ERROR: " + ex.Message);
            }
        }

        public override string ToString()
        {
            return filename;
        }
    }
}
