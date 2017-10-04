using LeagueInfo.Core.Contract;

namespace LeagueInfo.Infrastructure.RiotApiClient
{
	public static class ProfileIconUrlBuilder
	{
		public static string GetProfileIconUrl(SummonerProfileIcon summonerProfileIcon)
		{
			return dragonUrl + summonerProfileIcon.Image.Full;
		}

		private static readonly string dragonUrl = "http://ddragon.leagueoflegends.com/cdn/6.24.1/img/profileicon/";
	}
}