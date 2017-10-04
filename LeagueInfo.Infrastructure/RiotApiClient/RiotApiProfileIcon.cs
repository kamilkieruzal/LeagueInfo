using LeagueInfo.Core.Contract;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;

namespace LeagueInfo.Infrastructure.RiotApiClient
{
	public class RiotApiProfileIcon : RiotApiClientBase<SummonerProfileIcon>
	{
		public RiotApiProfileIcon() : base(apiUrl, method)
		{
		}

		protected override SummonerProfileIcon Parse(string data, string resourceId)
		{
			var definition = new { type = "", version = "", data = new Dictionary<string, SummonerProfileIcon>() };
			var dictionaryProfileIconData = JsonConvert.DeserializeAnonymousType(data, definition).data;
			return dictionaryProfileIconData[resourceId.ToLower()];
		}

		protected override string GetRequestedData(string resourceId)
		{
			if (profileIconData == null)
				profileIconData = base.GetRequestedData(resourceId);
			return profileIconData;
		}

		private string profileIconData;
		private static readonly string apiUrl = "/lol/static-data/v3/profile-icons";
		private readonly static Method method = Method.GET;
	}
}
