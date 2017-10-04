using System.Collections.Generic;

namespace LeagueInfo.Core.Contract
{
	public class CurrentGameInfo
	{
		public long GameId { get; set; }
		public long GameStartTime { get; set; }
		public string PlatformId { get; set; }
		public string GameMode { get; set; }
		public long MapId { get; set; }
		public string GameType { get; set; }
		public IList<BannedChampion> BannedChampions { get; set; }
		public Observer Observers { get; set; }
		public IList<CurrentGameParticipant> Participants { get; set; }
		public long GameLength { get; set; }
		public long GameQueueConfigId { get; set; }
	}
}
