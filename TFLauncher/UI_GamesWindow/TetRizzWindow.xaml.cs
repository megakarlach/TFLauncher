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

        // attempt fixing nasty memory leak

        private void CleanupMedia()
        {
            WindowLifetimeHelper.CleanupMediaElement(animatedgameplay);
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            CleanupMedia();
            base.OnClosing(e);
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
            TetRizzEnhancedWindow game_tetrizz_enhanced = new TetRizzEnhancedWindow();
            Application.Current.MainWindow = game_tetrizz_enhanced;
            game_tetrizz_enhanced.Show();
            Close();
        }
        private void OpenTetRizzCDKeyBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            TF_Help_TR_CDKey_Window viewcdkeywnd = new TF_Help_TR_CDKey_Window();
            WindowLifetimeHelper.ShowOwnedDialog(this, viewcdkeywnd);
        }

        private void GoBackBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            SelectGameWindowP2 selectgamewnd = new SelectGameWindowP2();
            Application.Current.MainWindow = selectgamewnd;
            selectgamewnd.Show();
            Close();
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
            WindowLifetimeHelper.ShowOwnedDialog(this, aboutpopup);
        }

        // TETFUCK TRAX 2026
        private void OpenTetFuckTraxBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            EATraxWindow eatraxwnd = new EATraxWindow();
            Application.Current.MainWindow = eatraxwnd;
            eatraxwnd.Show();
            Close();
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
            WindowLifetimeHelper.ShowOwnedDialog(this, aboutpopup);
        }

        private void HelpBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            TF_Help_Window helppopup = new TF_Help_Window();
            WindowLifetimeHelper.ShowOwnedDialog(this, helppopup);
        }

        private void NewsBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            TFNewsWindow tfnewswnd = new TFNewsWindow();
            WindowLifetimeHelper.ShowOwnedDialog(this, tfnewswnd);
        }
        private void OpenTetRizzControlsBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            TF_Help_TR_Controls_Window viewcontrolswnd = new TF_Help_TR_Controls_Window();
            WindowLifetimeHelper.ShowOwnedDialog(this, viewcontrolswnd);
        }
        // Bottom bar buttons
    }
}
