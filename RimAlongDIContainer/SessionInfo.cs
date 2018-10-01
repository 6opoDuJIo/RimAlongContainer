using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimAlongDIContainer
{
    public interface SessionInfo
    {
        int GameTickCount { get; }
        int NextSyncTickID { get; }
		int SyncRoundCount { get; }
		int SyncRoundDurationInMiliseconds { get; }
		int SessionGenericRandSeed { get; }
		string SessionMapSeed { get; }
		IEnumerable<int> InitialSessionPawnSeeds { get; }
        IEnumerable<PlayerInfo> Players { get; }
        SessionState State { get; }
		IEnumerable<KeyValuePair<PlayerInfo, string>> GetChatHistory();
    }
}
