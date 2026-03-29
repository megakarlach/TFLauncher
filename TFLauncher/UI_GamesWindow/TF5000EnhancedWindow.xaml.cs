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
    /// Interaction logic for CunnyCrisisWindow.xaml
    /// </summary>
    public partial class TF5000EnhancedWindow : Window
    {
        public TF5000EnhancedWindow()
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
            try
            {
                if (animatedgameplay != null)
                {
                    animatedgameplay.Stop();
                    animatedgameplay.Source = null;

                    // Optional but helps:
                    animatedgameplay.LoadedBehavior = System.Windows.Controls.MediaState.Manual;
                    animatedgameplay.UnloadedBehavior = System.Windows.Controls.MediaState.Manual;
                }
            }
            catch { }
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
        private void PlayTF5000EBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            Launcher.OpenTetFuck5000E();
            Launcher.ExitMe();
        }

        private void TryTF5KRegular_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            animatedgameplay.Stop();
            // Switch to Regular version
            TF5000Window tf5kwnd = new TF5000Window();
            tf5kwnd.ShowDialog();
            this.Content = null;
            this.Close();
        }

        private void FIFAAdBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            Launcher.LaunchWebsite("https://www.fifa.com/en/tournaments/mens/worldcup/canadamexicousa2026"); //link updated 3/28/2026
        }

        private void GoBackBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            animatedgameplay.Stop();
            SelectGameWindow selectgamewnd = new SelectGameWindow();
            selectgamewnd.ShowDialog();
            this.Content = null;
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
            this.Content = null;
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
        private void OpenTF5KControlsBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            TF_Help_TFV_Controls_Window viewcontrolswnd = new TF_Help_TFV_Controls_Window();
            viewcontrolswnd.ShowDialog();
        }
        // Bottom bar buttons
    }
}