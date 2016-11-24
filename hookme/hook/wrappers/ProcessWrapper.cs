using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nektra.Deviare2;
using System.Windows.Forms;
using System.Collections;

namespace hook.wrappers
{
    class ProcessWrapper
    {
        public NktProcess process;

        public ProcessWrapper(NktProcess process)
        {
            this.process = process;
        }

        public override string ToString()
        {
            return process.Name + " [Pid: " + process.Id + " ]";
        }



    }
}
