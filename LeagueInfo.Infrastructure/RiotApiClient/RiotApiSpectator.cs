using RestSharp;
using Newtonsoft.Json;
using LeagueInfo.Core.Contract;

namespace LeagueInfo.Infrastructure.RiotApiClient
{
	public class RiotApiSpectator : RiotApiClientBase<CurrentGameInfo>
	{
		public RiotApiSpectator() : base(apiUrl, method)
		{
		}

		protected override CurrentGameInfo Parse(string data, string resourceId)
		{
			return JsonConvert.DeserializeObject<CurrentGameInfo>(data);
		}

		private static readonly string apiUrl = "/lol/spectator/v3/active-games/by-summoner/{id}";
		private readonly static Method method = Method.GET;
	}
}
