using System;
using System.Windows;
using System.Windows.Input;

namespace TFLauncher
{
    /// <summary>
    /// Interaction logic for SelectGameWindow.xaml
    /// </summary>
    public partial class SelectGameWindowP2 : Window
    {

        public SelectGameWindowP2()
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

        // attempt fixing nasty memory leak

        private void CleanupMedia()
        {
            try
            {
                if (animatedBG != null)
                {
                    animatedBG.Stop();
                    animatedBG.Source = null;

                    // Optional but helps:
                    animatedBG.LoadedBehavior = System.Windows.Controls.MediaState.Manual;
                    animatedBG.UnloadedBehavior = System.Windows.Controls.MediaState.Manual;
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

        // SELECT GAME SCRIPTS & Middle bottom btns
        // Button that opens Cunny Crysis
        private void OpenCunnyCrisis_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            animatedBG.Stop(); // Stop video playback
            // Open up the game window and hide the select game window.
            CunnyCrisisWindow cunnycrysis = new CunnyCrisisWindow();
            Application.Current.MainWindow = cunnycrysis;
            cunnycrysis.Show();
            UnregisterName("animatedBG");
            this.Content = null;
            this.Close();
        }

        // Button that opens Tetrizz
        private void OpenTetRizz_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            animatedBG.Stop(); // Stop video playback
            // Open up the game window and hide the select game window.
            TetRizzWindow game_tetrizz = new TetRizzWindow();
            Application.Current.MainWindow = game_tetrizz;
            game_tetrizz.Show();
            UnregisterName("animatedBG");
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
            animatedBG.Stop(); // Stop video playback
            SelectGameWindow selectgamewnd = new SelectGameWindow();
            Application.Current.MainWindow = selectgamewnd;
            selectgamewnd.Show();
            UnregisterName  ("animatedBG");
            this.Content = null;
            this.Close();
        }

        // SELECT GAME SCRIPTS & Middle bottom btns

        // Bottom bar buttons
        private void VisitTFWebsiteBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            Launcher.LaunchWebsite("https://playtetfuck.wordpress.com/"); //link updated 8/3/2024
        }
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
            animatedBG.Stop(); // Stop video playback
            EATraxWindow eatraxwnd = new EATraxWindow();
            Application.Current.MainWindow = eatraxwnd;
            eatraxwnd.Show();
            UnregisterName("animatedBG");
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

        // Bottom bar buttons
    }
}
