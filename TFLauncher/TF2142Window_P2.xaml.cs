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
using System.Threading;

namespace TFLauncher
{
    /// <summary>
    /// Interaction logic for TF2142Window_P2.xaml
    /// </summary>
    public partial class TF2142Window_P2 : Window
    {
        public TF2142Window_P2()
        {
            InitializeComponent();
        }
        // Play sounds when hovering buttons
        private void ButtonSFX_MouseEnter(object sender, MouseEventArgs e)
        {
            // start playing
            Launcher.PlayHoverBtnSound();
        }

        private void ButtonSFX_MouseLeave(object sender, MouseEventArgs e)
        {
            // stop playing
        }
        // TOP BAR STUFF
        private void VisitTFWebsiteBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            Launcher.LaunchWebsite("https://playtetfuck.wordpress.com/"); //link updated 8/3/2024
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
            Launcher.PlayBtnSound();
            this.Hide();
            SelectGameWindow selgamewin = new SelectGameWindow();
            selgamewin.ShowDialog();
        }

        // TOP BAR STUFF

        private void PlayTF2142NoMusicBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            Launcher.OpenTetFuck2142();
            Launcher.ExitMe();
        }

        private void UseLegacyTF2142Launcher_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            Launcher.OpenTF2142LegacyLauncher();
            Launcher.ExitMe();
        }
        private void PlayTF2142AllMusicBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            Launcher.OpenTF2142AllMusic();
            Launcher.ExitMe();
        }
        private void PlayTF2142Mus1Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            Launcher.OpenTF2142Mus1B();
            Launcher.ExitMe();
        }

        private void PlayTF2142Mus2Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            Launcher.OpenTF2142Mus2B();
            Launcher.ExitMe();
        }

        private void PlayTF2142Mus3Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            Launcher.OpenTF2142Mus3B();
            Launcher.ExitMe();
        }
        private void PlayTF2142Mus4Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            Launcher.OpenTF2142Mus4B();
            Launcher.ExitMe();
        }
        private void PlayTF2142Mus5Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            Launcher.OpenTF2142Mus5B();
            Launcher.ExitMe();
        }
        private void PrevSetlistBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayScrollBtnSound();
            Thread.Sleep(150);
            this.Hide();
            TF2142Window tf2142page1 = new TF2142Window();
            tf2142page1.ShowDialog();
        }

        private void OpenMusicSetlistBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            Launcher.OpenSetlist();
        }
    }
}
