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
using System.Windows.Navigation;
using System.Windows.Shapes;
using CefSharp;
using CefSharp.Wpf;

namespace TFLauncher
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

        private void VisitTFWebsiteBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.LaunchWebsite("https://tetfakgame.wordpress.com/");
        }

        private void QuitBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.ExitMe();
        }

        private void OpenTetFuck2142_Click(object sender, RoutedEventArgs e)
        {
            // Open up the TF2142 - Select Music window and hide the select game window.
            this.Hide();
            TF2142Window tf2142win = new TF2142Window();
            tf2142win.ShowDialog();
        }

        private void OpenTetFuck5000_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTetFuck5000();
            Launcher.ExitMe();
        }

        private void AboutBtn_Click(object sender, RoutedEventArgs e)
        {
            AboutTF aboutpopup = new AboutTF();
            aboutpopup.ShowDialog();
        }
    }
}
