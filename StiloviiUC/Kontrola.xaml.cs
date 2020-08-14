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

namespace StiloviiUC
{
	/// <summary>
	/// Interaction logic for Kontrola.xaml
	/// </summary>
	public partial class Kontrola : UserControl
	{
		public string Nesto { get; set; }
		public Kontrola()
		{
			InitializeComponent();
			DataContext = this;
		}
	}
}
