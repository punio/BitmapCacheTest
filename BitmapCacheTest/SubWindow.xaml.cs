using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BitmapCacheTest
{
	/// <summary>
	/// SubWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class SubWindow : Window
	{
		public SubWindow()
		{
			InitializeComponent();
			this.Loaded += SubWindow_Loaded;
		}

		private void SubWindow_Loaded(object sender, RoutedEventArgs e)
		{
			ThreadPool.QueueUserWorkItem(_ =>
			{
				while (true)
				{
					Thread.Sleep(1000);
					Dispatcher.BeginInvoke(new Action(() => Time.Text = DateTime.Now.ToString()));
				}
			});
		}
	}
}
