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
            Launcher.Quit();
        }

        private void OpenTetFuck2142_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTetFuck2142();
        }

        private void OpenTetFuck5000_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
