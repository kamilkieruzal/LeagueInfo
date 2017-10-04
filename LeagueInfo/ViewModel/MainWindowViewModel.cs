using LeagueInfo.Utils;
using System.Windows;
using System.Windows.Input;

namespace LeagueInfo.ViewModel
{
	public class MainWindowViewModel : ViewModelBase
	{
		public ICommand SearchCommand { get; set; }
		public MainWindowViewModel()
		{
			SearchCommand = new RelayCommand(
				c => true,
				c => Search());
		}

		private void Search()
		{
			MessageBox.Show("XD");
		}
	}
}
