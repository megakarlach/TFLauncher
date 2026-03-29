using System;
using System.Windows;
using System.Windows.Input;

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

        // SELECT GAME & Middle bottom btns
        // Button that opens TetFuck 2142
        private void OpenTetFuck2142_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            animatedBG.Stop(); // Stop video playback
            // Open up the game window and hide the select game window.
            TF2142Window tf2142win = new TF2142Window();
            Application.Current.MainWindow = tf2142win;
            tf2142win.Show();
            UnregisterName("animatedBG");
            this.Content = null;
            this.Close();
        }

        // Button that opens TetFuck 4K (NOTE: Enhanced version can be accessed via TF4K)
        private void OpenTetFuck4000_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            animatedBG.Stop(); // Stop video playback
            // Open up the game window and hide the select game window.
            TF4000Window tf4kwin = new TF4000Window();
            Application.Current.MainWindow = tf4kwin;
            tf4kwin.Show();
            UnregisterName("animatedBG");
            this.Content = null;
            this.Close();
        }

        // Button that opens TetFuck Five (NOTE: Enhanced version can be accessed via TFV)
        private void OpenTetFuck5000_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            animatedBG.Stop(); // Stop video playback
            // Open up the game window and hide the select game window.
            TF5000Window tf5000win = new TF5000Window();
            Application.Current.MainWindow = tf5000win;
            tf5000win.Show();
            UnregisterName("animatedBG");
            this.Content = null;
            this.Close();
        }

        private void OpenMoreGamesBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            animatedBG.Stop(); // Stop video playback
            // Open up the game window and hide the select game window.
            SelectGameWindowP2 selectgamewnd2 = new SelectGameWindowP2();
            Application.Current.MainWindow = selectgamewnd2;
            selectgamewnd2.Show();
            UnregisterName("animatedBG");
            this.Content = null;
            this.Close();
        }

        // SELECT GAME & Middle bottom btns

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
