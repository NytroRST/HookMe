using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nektra.Deviare2;

namespace hook.wrappers
{
    class FunctionWrapper
    {
        public enum Status
        {
            Waiting,
            Forwarded,
            Droped
        }

        public NktHook Hook;
        public NktProcess proc;
        public NktHookCallInfo callInfo;
        public Status status;

        public FunctionWrapper(NktHook Hook, NktProcess proc, NktHookCallInfo callInfo)
        {
            this.Hook = Hook;
            this.proc = proc;
            this.callInfo = callInfo;

            status = Status.Waiting;
        }
    }
}
