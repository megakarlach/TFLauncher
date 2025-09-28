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
using System.Media;

namespace TFLauncher
{
    /// <summary>
    /// Interaction logic for SelectGameWindow.xaml
    /// </summary>
    public partial class SelectGameWindow : Window
    {
        public SelectGameWindow()
        {
            InitializeComponent();
        }
        private void animatedBG_Loaded(object sender, RoutedEventArgs e)
        {

            animatedBG.Play();

        }

        private void animatedBG_Ended(object sender, RoutedEventArgs e)
        {

            animatedBG.Position = TimeSpan.FromSeconds(0);

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

        // Top bar buttons
        private void VisitTFWebsiteBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            Launcher.LaunchWebsite("https://playtetfuck.wordpress.com/"); //link updated 8/3/2024
        }

        // UPDATE POPUP 2025
        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            TFChkUpdateWindow aboutpopup = new TFChkUpdateWindow();
            aboutpopup.ShowDialog();
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

        private void sendfeedbackbtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            Launcher.LaunchWebsite("mailto:maxperture247@gmail.com?subject=TetFuck%20-%20Feedback%20(Insert%20title%20here)&body=Describe%20your%20feedback%3A%0A(Tell%20us%20what%20prompted%20this%20feedback...)%0A%0ANOTE%3A%20Please%20don%E2%80%99t%20include%20any%20sensitive%20information.");
        }
        // Top bar buttons

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
    }
}
