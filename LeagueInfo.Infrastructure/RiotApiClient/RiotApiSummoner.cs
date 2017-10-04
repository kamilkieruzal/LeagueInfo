using RestSharp;
using Newtonsoft.Json;
using System.Collections.Generic;
using LeagueInfo.Core.Contract;

namespace LeagueInfo.Infrastructure.RiotApiClient
{
	public class RiotApiSummoner : RiotApiClientBase<SummonerDto>
	{
		public RiotApiSummoner() : base(apiUrl, method)
		{
		}

		protected override SummonerDto Parse(string data, string resourceId)
		{
			return JsonConvert.DeserializeObject<Dictionary<string, SummonerDto>>(data)[resourceId.ToLower()];
		}

		private readonly static string apiUrl = "/api/lol/euw/v1.4/summoner/by-name/{id}";
		private readonly static Method method = Method.GET;
	}
}
