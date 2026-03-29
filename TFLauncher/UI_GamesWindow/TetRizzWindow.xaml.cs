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
using System.Diagnostics;
using System.Media;

namespace TFLauncher
{
    /// <summary>
    /// Interaction logic for TetRizzWindow.xaml
    /// </summary>
    public partial class TetRizzWindow : Window
    {
        public TetRizzWindow()
        {
            InitializeComponent();
        }
        // Animated gameplay video
        private void animatedgameplay_Loaded(object sender, RoutedEventArgs e)
        {

            animatedgameplay.Play();

        }

        private void animatedgameplay_Ended(object sender, RoutedEventArgs e)
        {

            animatedgameplay.Position = TimeSpan.FromSeconds(0);

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
        private void OpenMusicSetlistBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            Launcher.OpenSetlist();
        }

        // Top bar buttons - END

        // Middle bottom btns
        private void PlayTetRizzBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            Launcher.OpenTetRizz();
            Launcher.ExitMe();
        }

        private void TryTetRizzEnhanced_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            animatedgameplay.Stop();
            // Switch to Enhanced version
            TetRizzEnhancedWindow game_tetrizz_enhanced = new TetRizzEnhancedWindow();
            game_tetrizz_enhanced.Show();
            this.Close();
        }
        private void OpenTetRizzCDKeyBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            TF_Help_TR_CDKey_Window viewcdkeywnd = new TF_Help_TR_CDKey_Window();
            viewcdkeywnd.ShowDialog();
        }

        private void GoBackBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            animatedgameplay.Stop();
            SelectGameWindow selectgamewnd = new SelectGameWindow();
            selectgamewnd.Show();
            this.Close();
        }

        // Middle bottom btns - END

        // Bottom bar buttons
        // Fake Ultimate Team btn
        private void OpenUltimateTeamBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            Launcher.LaunchWebsite("https://www.youtube.com/watch?v=dQw4w9WgXcQ"); //link updated 3/15/2026
        }
        // UPDATE POPUP 2025
        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            TFChkUpdateWindow aboutpopup = new TFChkUpdateWindow();
            aboutpopup.ShowDialog();
        }

        // TETFUCK TRAX 2026
        private void OpenTetFuckTraxBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            animatedgameplay.Stop();
            EATraxWindow eatraxwnd = new EATraxWindow();
            eatraxwnd.ShowDialog();
            this.Close();
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
            TF_Help_Window helppopup = new TF_Help_Window();
            helppopup.ShowDialog();
        }

        private void NewsBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            TFNewsWindow tfnewswnd = new TFNewsWindow();
            tfnewswnd.ShowDialog();
        }
        private void OpenTetRizzControlsBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            TF_Help_TR_Controls_Window viewcontrolswnd = new TF_Help_TR_Controls_Window();
            viewcontrolswnd.ShowDialog();
        }
        // Bottom bar buttons
    }
}