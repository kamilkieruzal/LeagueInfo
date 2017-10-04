namespace LeagueInfo.Core.Contract
{
	public class SummonerDto
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public int ProfileIconId { get; set; }
		public long RevisionDate { get; set; }
		public long SummonerLevel { get; set; }
	}
}
