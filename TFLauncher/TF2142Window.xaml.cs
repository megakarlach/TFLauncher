using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CefSharp;
using CefSharp.Wpf;

namespace TFLauncher
{
    /// <summary>
    /// Interaction logic for TF2142Window.xaml
    /// </summary>
    public partial class TF2142Window : Window
    {
        public TF2142Window()
        {
            InitializeComponent();
        }

        private void GoBackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainwin = new MainWindow();
            mainwin.ShowDialog();
        }
    }
}
