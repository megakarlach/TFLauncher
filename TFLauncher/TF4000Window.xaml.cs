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
using System.Diagnostics;

namespace TFLauncher
{
    /// <summary>
    /// Interaction logic for TF4000Window.xaml
    /// </summary>
    public partial class TF4000Window : Window
    {
        public TF4000Window()
        {
            InitializeComponent();
        }

        private void GoBackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainwin = new MainWindow();
            mainwin.ShowDialog();
        }

        private void PlayTF4000Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTetFuck4000();
            Launcher.ExitMe();
        }

        private void QuitBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.ExitMe();
        }

        private void RunTF4KSetupBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTetFuck4000Setup();
        }
    }
}
