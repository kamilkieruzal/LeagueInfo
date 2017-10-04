using LeagueInfo.Utils;
using System.Collections.ObjectModel;

namespace LeagueInfo.ViewModel
{
	public class SummonerHistoryViewModel
	{
		private readonly SummonerHistorySerializer summonerHistorySerializer;

		public SummonerHistoryViewModel()
		{
			summonerHistorySerializer = new SummonerHistorySerializer();
			SummonerHistoryItems = 
				new ObservableCollection<MiniSummonerViewModel>(summonerHistorySerializer.Deserialize());
		}

		public ObservableCollection<MiniSummonerViewModel> SummonerHistoryItems { get; set; }
	}
}
