using LeagueInfo.Core.Contract;
using LeagueInfo.Infrastructure.RiotApiClient;
using LeagueInfo.Utils;

namespace LeagueInfo.ViewModel
{
	public class SummonerDetailsViewModel : ViewModelBase
	{
		private RiotApiSummoner summonerApi = new RiotApiSummoner();
		private RiotApiSpectator spectatorApi = new RiotApiSpectator();
		private RiotApiProfileIcon profileIconApi = new RiotApiProfileIcon();

		private string summonerName;
		private SummonerDto summonerProfileData;

		public string SummonerIconUrl
		{
			get
			{
				if (SummonerName != null)
				{
					var profileIcon = profileIconApi.GetData(summonerProfileData.ProfileIconId.ToString());
					return ProfileIconUrlBuilder.GetProfileIconUrl(profileIcon);
				}
				return string.Empty;
			}
		}

		public string SummonerName
		{
			get => summonerName;
			set
			{
				summonerName = value;
				summonerProfileData = summonerApi.GetData(summonerName);
				if(summonerProfileData!=null)
					OnPropertyChanged(nameof(SummonerIconUrl));
			}
		}
	}
}
