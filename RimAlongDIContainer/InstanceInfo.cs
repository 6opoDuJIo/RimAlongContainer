using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimAlongDIContainer
{
    public enum NetworkingModes
    {
        GameNetworkingSocketsOpensource,
        GameNetworkingSocketsSteam,
        Custom,
        None,
        Mocked
    }

    public interface InstanceInfo
    {
        string RimAlongVersionID { get; }
        string ProtocolVersionID { get; }
        NetworkingModes NetworkingMode { get; }
        SessionInfo CurrentSession { get; }
    }
}
