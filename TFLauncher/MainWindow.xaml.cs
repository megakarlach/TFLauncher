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

        private void sendfeedbackbtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.LaunchWebsite("mailto:maxperture247@gmail.com?subject=TetFuck%20-%20Feedback%20(Insert%20title%20here)&body=Describe%20your%20feedback%3A%0A(Tell%20us%20what%20prompted%20this%20feedback...)%0A%0ANOTE%3A%20Please%20don%E2%80%99t%20include%20any%20sensitive%20information.");
        }

        private void OpenTetFuck4000_Click(object sender, RoutedEventArgs e)
        {
            // Open up the TF4K window and hide the select game window.
            this.Hide();
            TF4000Window tf4kwin = new TF4000Window();
            tf4kwin.ShowDialog();
        }
    }
}
