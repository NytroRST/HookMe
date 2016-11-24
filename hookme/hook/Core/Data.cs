using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using hook.MatchAndReplace;
namespace hook.Core
{
    class Data
    {
        public Plugins.PluginManager pluginMngr = new Plugins.PluginManager();
        public Configuration configuration = new Configuration();

        public wrappers.FunctionWrapper currentFunction = null;
        public bool AceptingNewFunctions = true;
        public bool intercept = true;


        private List<MatchAndReplace.MatchAndReplace> lstMatchReplace = new List<MatchAndReplace.MatchAndReplace>();


        public delegate void matchAndReplaceHandler(MatchAndReplace.MatchAndReplace matchAndReplace);
        public event matchAndReplaceHandler NewMatchAndReplace;

        public Data()
        {
        }

        public void AddMatchAndReplace(MatchAndReplace.MatchAndReplace matchAndReplace)
        {
            lstMatchReplace.Add(matchAndReplace);

            if (NewMatchAndReplace != null)
                NewMatchAndReplace(matchAndReplace);
        }

        public void RemoveMatchAndReplace(MatchAndReplace.MatchAndReplace matchAndReplace)
        {
            lstMatchReplace.Remove(matchAndReplace);
        }

        public List<MatchAndReplace.MatchAndReplace> GetReplaceList()
        {
            return lstMatchReplace;
        }
    }
}
