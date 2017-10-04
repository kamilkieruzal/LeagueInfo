using LeagueInfo.ViewModel;
using System.Windows;

namespace LeagueInfo
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			var viewModel = new MainWindowViewModel();
			InitializeComponent();
			DataContext = viewModel;
		}
	}
}