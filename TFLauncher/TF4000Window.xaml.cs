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
using System.Media;

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
        // TOP BAR STUFF
        private void VisitTFWebsiteBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            Launcher.LaunchWebsite("https://tetfakgame.wordpress.com/");
        }

        private void QuitBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            Launcher.ExitMe();
        }

        private void AboutBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            AboutTF aboutpopup = new AboutTF();
            aboutpopup.ShowDialog();
        }

        private void sendfeedbackbtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            Launcher.LaunchWebsite("mailto:maxperture247@gmail.com?subject=TetFuck%20-%20Feedback%20(Insert%20title%20here)&body=Describe%20your%20feedback%3A%0A(Tell%20us%20what%20prompted%20this%20feedback...)%0A%0ANOTE%3A%20Please%20don%E2%80%99t%20include%20any%20sensitive%20information.");
        }

        private void GoBackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SelectGameWindow selgamewin = new SelectGameWindow();
            selgamewin.ShowDialog();
        }

        // TOP BAR STUFF

        private void PlayTF4000Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTetFuck4000();
            Launcher.ExitMe();
        }

        private void OpenTF4KSettingsBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTetFuck4000Setup();
        }
    }
}
