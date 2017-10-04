using LeagueInfo.ViewModel;
using System.Windows.Controls;

namespace LeagueInfo.View
{
	/// <summary>
	/// Interaction logic for SummonerHistoryView.xaml
	/// </summary>
	public partial class SummonerHistoryView : UserControl
	{
		public SummonerHistoryView()
		{
			var viewModel = new SummonerHistoryViewModel();
			DataContext = viewModel;
			InitializeComponent();
		}
	}
}
