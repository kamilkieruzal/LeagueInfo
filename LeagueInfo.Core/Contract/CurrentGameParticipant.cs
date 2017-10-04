using System.Collections.Generic;

namespace LeagueInfo.Core.Contract
{
	public  class CurrentGameParticipant
	{
		public long ProfileIconId { get; set; }
		public long ChampionId { get; set; }
		public string SummonerName { get; set; }
		public IList<Rune> Runes { get; set; }
		public bool Bot { get; set; }
		public long TeamId { get; set; }
		public long Spell2Id { get; set; }
		public IList<Mastery> Masteries { get; set; }
		public long Spell1Id { get; set; }
		public long SummonerId { get; set; }
	}
}