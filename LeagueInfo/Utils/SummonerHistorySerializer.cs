using LeagueInfo.Core.Serialization;
using LeagueInfo.ViewModel;
using System.Collections.Generic;

namespace LeagueInfo.Utils
{
	public class SummonerHistorySerializer : Serializer<IList<MiniSummonerViewModel>>
	{
		public SummonerHistorySerializer() : base("History.json")
		{
		}
	}
}
