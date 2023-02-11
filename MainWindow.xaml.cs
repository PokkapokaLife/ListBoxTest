using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListBoxTest
{
	/// <summary>
	/// MainWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class MainWindow : Window
	{
		private MainWindowVM _mainWindowVM = null;

		public MainWindow()
		{
			InitializeComponent();

			_mainWindowVM = new MainWindowVM();

			this.DataContext = _mainWindowVM;
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			MainWindowVM vm = (MainWindowVM)this.DataContext;

			ButtonTemplate bt = new ButtonTemplate();
			bt.Width = 50;
			bt.Height = 50;
			bt.Text = "1";
			bt.ButtonBackground = new SolidColorBrush(Colors.White);
			vm.ButtonList.Add(bt);

			bt = new ButtonTemplate();
			bt.Width = 50;
			bt.Height = 50;
			bt.Text = "2";
			bt.ButtonBackground = new SolidColorBrush(Colors.White);
			vm.ButtonList.Add(bt);
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			//Button bt = (Button)sender;

			ButtonTemplate btt = (ButtonTemplate)((Button)sender).DataContext;

			int index = 0;

			int.TryParse(btt.Text, out index);

			ButtonTemplate buttonTemplate = new ButtonTemplate();
			buttonTemplate.Width = btt.Width;
			buttonTemplate.Height = btt.Height;
			buttonTemplate.Text = btt.Text;
			buttonTemplate.ButtonBackground = new SolidColorBrush(Colors.Aqua);

			MainWindowVM vm = (MainWindowVM)DataContext;

			vm.ButtonList[index - 1] = buttonTemplate;
		}

		private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			
		}
	}
}
