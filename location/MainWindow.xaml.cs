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

namespace location
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<string> arg = new List<string>();
            string userName= name.Text;
            string location = loc.Text;
            string h = host.Text;
            string p = port.Text;
            
            //Check if empty or not
            arg.Add(userName);

            if (location!=""){arg.Add(location);}

            if (h != "")
            {
                arg.Add("-h");
                arg.Add(h);
            }

            if (p != "")
            {
                arg.Add("-p");
                arg.Add(p);
            }

            if (h9.IsChecked == true){arg.Add("-h9");}
            else if (h0.IsChecked == true){arg.Add("-h0");}
            else if (h1.IsChecked== true){arg.Add("-h1");}




        }
    }
}
