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
    /// Interaction logic for TF2142Window.xaml
    /// </summary>
    public partial class TF2142Window : Window
    {
        public TF2142Window()
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

        // shitty battlelog system
        private void VisitKanyeTwitterProfile_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            Launcher.LaunchWebsite("https://x.com/kanyewest"); //link updated 11/2025
        }

        private void QuitBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            Launcher.ExitMe();
        }

        private void AboutBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            TFAbout aboutpopup = new TFAbout();
            aboutpopup.ShowDialog();
        }

        private void HelpBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            TF_Help_Window aboutpopup = new TF_Help_Window();
            aboutpopup.ShowDialog();
        }

        // TOP BAR STUFF

        //          Deprecated
        //        private void UseLegacyTF2142Launcher_Click(object sender, RoutedEventArgs e)
        //        {
        //            Launcher.PlayBtnSound();
        //            Launcher.OpenTF2142LegacyLauncher();
        //            Launcher.ExitMe();
        //        }

        // Launch game btn
        private void PlayTF2142NoMusicBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            Launcher.OpenTetFuck2142();
            Launcher.ExitMe();
        }

        private void PlayTF2142AllMusicBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            Launcher.OpenTF2142AllMusic();
            Launcher.ExitMe();
        }

        private void OpenTetFuck2142CDKeyBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            TF_Help_TF2142_CDKey_Window viewcdkeywnd = new TF_Help_TF2142_CDKey_Window();
            viewcdkeywnd.ShowDialog();
        }

        private void OpenMusicSetlistBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            Launcher.OpenSetlist();
        }
        // Launch game btn - END

        // SELECT GAME SCRIPTS
        // Button that opens TetFuck 2142
        private void OpenTetFuck2142_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            // Open up the game window and hide the select game window.
            this.Hide();
            TF2142Window tf2142win = new TF2142Window();
            tf2142win.ShowDialog();
        }

        // Button that opens TetFuck 4K
        private void OpenTetFuck4000_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            // Open up the game window and hide the select game window.
            this.Hide();
            TF4000Window tf4kwin = new TF4000Window();
            tf4kwin.ShowDialog();
        }

        // Button that opens TetFuck 4K Enhanced
        private void OpenTetFuck4000Enhanced_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            // Open up the game window and hide the select game window.
            this.Hide();
            TF4000EnhancedWindow tf4kewin = new TF4000EnhancedWindow();
            tf4kewin.ShowDialog();
        }

        // Button that opens TetFuck Five
        private void OpenTetFuck5000_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            // Open up the game window and hide the select game window.
            this.Hide();
            TF5000Window tf5000win = new TF5000Window();
            tf5000win.ShowDialog();
        }

        // Button that opens TetFuck Five enhanced
        private void OpenTetFuck5000Enhanced_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            // Open up the game window and hide the select game window.
            this.Hide();
            TF5000EnhancedWindow tf5kewin = new TF5000EnhancedWindow();
            tf5kewin.ShowDialog();
        }

        // Button that opens Cunny Crysis
        private void OpenCunnyCrisis_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            // Open up the game window and hide the select game window.
            this.Hide();
            CunnyCrisisWindow cunnycrysis = new CunnyCrisisWindow();
            cunnycrysis.ShowDialog();
        }

        // Button that opens Tetrizz
        private void OpenTetRizz_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            // Open up the game window and hide the select game window.
            this.Hide();
            TetRizzWindow game_tetrizz = new TetRizzWindow();
            game_tetrizz.ShowDialog();
        }

        // Button that opens Tetrizz Enhanced
        private void OpenTetRizzEnhanced_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            // Open up the game window and hide the select game window.
            this.Hide();
            TetRizzEnhancedWindow game_tetrizz_enhanced = new TetRizzEnhancedWindow();
            game_tetrizz_enhanced.ShowDialog();
        }

        // SELECT GAME SCRIPTS
        // UPDATE POPUP 2025
        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            TFChkUpdateWindow aboutpopup = new TFChkUpdateWindow();
            aboutpopup.ShowDialog();
        }
    }
}
