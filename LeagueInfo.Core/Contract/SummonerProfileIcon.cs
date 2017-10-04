namespace LeagueInfo.Core.Contract
{
	public class SummonerProfileIcon
	{
		public Image Image { get; set; }
	}

	public class Image
	{
		public string Full { get; set; }
		public string Group { get; set; }
		public string Sprite { get; set; }
		public int H { get; set; }
		public int W { get; set; }
		public int Y { get; set; }
		public int X { get; set; }
	}
}