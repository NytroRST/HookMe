using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hook.MatchAndReplace
{
    public class MatchAndReplace
    {
        public string name;
        public byte[] match;
        public byte[] replace;
        public bool replaceIncomming;
        public bool replaceOutcomming;
        public bool enabled = true;

        public MatchAndReplace(string name, byte[] match, byte[] replace, bool replaceIncomming, bool replaceOutcomming)
        {
            this.name = name;
            this.match = match;
            this.replace = replace;
            this.replaceIncomming = replaceIncomming;
            this.replaceOutcomming = replaceOutcomming;
            this.enabled = true;
        }
    }
}
