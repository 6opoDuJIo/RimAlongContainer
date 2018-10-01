using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimAlongDIContainer
{
    public interface PlayerInfo
    {
        string PlayerUID { get; }
        string PlayerDisplayName { get; }
		PlayerState State { get; }
    }
}
