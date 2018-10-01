using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimAlongDIContainer
{
    public enum SessionState
    {
        Unk,
        Lobbie,
        SomeoneIsLoading,
        ActionPhase,
        PausedByAnyReason,
        VolatileState
    }
}
