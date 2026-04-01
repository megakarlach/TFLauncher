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
            WindowLifetimeHelper.CleanupMediaElement(animatedBG);
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
            TF2142Window tf2142win = new TF2142Window();
            Application.Current.MainWindow = tf2142win;
            tf2142win.Show();
            Close();
        }

        // Button that opens TetFuck 4K (NOTE: Enhanced version can be accessed via TF4K)
        private void OpenTetFuck4000_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            TF4000Window tf4kwin = new TF4000Window();
            Application.Current.MainWindow = tf4kwin;
            tf4kwin.Show();
            Close();
        }

        // Button that opens TetFuck Five (NOTE: Enhanced version can be accessed via TFV)
        private void OpenTetFuck5000_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            TF5000Window tf5000win = new TF5000Window();
            Application.Current.MainWindow = tf5000win;
            tf5000win.Show();
            Close();
        }

        private void OpenMoreGamesBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            SelectGameWindowP2 selectgamewnd2 = new SelectGameWindowP2();
            Application.Current.MainWindow = selectgamewnd2;
            selectgamewnd2.Show();
            Close();
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

        // Bottom bar buttons
    }
}
