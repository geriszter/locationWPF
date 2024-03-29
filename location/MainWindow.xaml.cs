﻿using System;
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

            //Check if empty or not
            if (userName!="")
            {
                arg.Add(userName);
                if (loc.Text != ""){arg.Add(loc.Text);}

                if (host.Text != "")
                {
                    arg.Add("-h");
                    arg.Add(host.Text);
                }

                if (port.Text != "")
                {
                    arg.Add("-p");
                    arg.Add(port.Text);
                }

                if (h9.IsChecked == true){arg.Add("-h9");}
                else if (h0.IsChecked == true){arg.Add("-h0");}
                else if (h1.IsChecked== true){arg.Add("-h1");}

                Client myClient = new Client();
                string res = myClient.Main(arg.ToArray());
                serverAns.Text = res;
            }
            else
            {
                PopUp error = new PopUp();
                error.ShowDialog();
            }

        }

        private void customHost_Click(object sender, RoutedEventArgs e)
        {
            if (customHost.IsChecked==true)
            {
                host.IsEnabled = true;
            }
            else
            {
                host.IsEnabled = false;
            }
        }

        private void cPort_Click(object sender, RoutedEventArgs e)
        {
            if (cPort.IsChecked == true)
            {
                port.IsEnabled = true;
            }
            else
            {
                port.IsEnabled = false;
            }
        }
    }
}
