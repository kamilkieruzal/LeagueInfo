using LeagueInfo.Core.Contract;
using RestSharp;
using System;
using System.Net;

namespace LeagueInfo.Infrastructure.RiotApiClient
{
	public abstract class RiotApiClientBase<T> : IRiotApiClientBase<T> where T : class
	{
		private RestClient client;
		private RestRequest request;
		private string apiUrl;
		private Method method;

		public RiotApiClientBase(
			string apiUrl, 
			Method method)
		{
			client = new RestClient(euwRiotApiUrl);
			this.apiUrl = apiUrl;
			this.method = method;
		}

		public T GetData(string resourceId)
		{
			var requestedData = GetRequestedData(resourceId);
			if (requestedData != null)
				return Parse(requestedData, resourceId);
			return null;
		}

		protected virtual string GetRequestedData(string resourceId)
		{
			request = new RestRequest(apiUrl, method);
			request.AddQueryParameter("api_key", MyApiKey);
			request.AddUrlSegment("id", resourceId);
			try
			{
				var response = client.Get(request);

				if (response.StatusCode != HttpStatusCode.OK)
					return null;

				return response.Content;
			}
			catch(Exception)
			{
				//unlucky situation here boys;
				return null;
			}
		}

		protected abstract T Parse(string data, string resourceId);

		private readonly string MyApiKey = "RGAPI-35c53f7a-36e1-4e49-9e04-6ca07af0c024";
		private readonly string euwRiotApiUrl = "https://euw1.api.riotgames.com/";
	}
}
