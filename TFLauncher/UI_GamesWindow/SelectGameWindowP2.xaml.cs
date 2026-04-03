using System;
using System.Windows;
using System.Windows.Input;
using System.Reflection;

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
            SetVersionLabel();
        }

        private void SetVersionLabel()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;

            DateTime dotNetBaseDate = new DateTime(2000, 1, 1);

            DateTime buildDate = dotNetBaseDate.AddDays(version.Build)
                                               .AddSeconds(version.Revision * 2);

            int customBuildNumber = (buildDate - LauncherVerInfo.CustomBaseDate).Days;

            versionlabel.Content =
                $"TetFuck Launcher v{LauncherVerInfo.Version} build {customBuildNumber} | {buildDate:yyyy-MM-dd} | {LauncherVerInfo.Codename}";
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

        // SELECT GAME SCRIPTS & Middle bottom btns
        // Button that opens Cunny Crysis
        private void OpenCunnyCrisis_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            CunnyCrisisWindow cunnycrysis = new CunnyCrisisWindow();
            Application.Current.MainWindow = cunnycrysis;
            cunnycrysis.Show();
            Close();
        }

        // Button that opens Tetrizz
        private void OpenTetRizz_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            TetRizzWindow game_tetrizz = new TetRizzWindow();
            Application.Current.MainWindow = game_tetrizz;
            game_tetrizz.Show();
            Close();
        }

        private void FIFAAdBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            Launcher.LaunchWebsite("https://www.fifa.com/en/tournaments/mens/worldcup/canadamexicousa2026"); //link updated 3/28/2026
        }

        private void GoBackBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            SelectGameWindow selectgamewnd = new SelectGameWindow();
            Application.Current.MainWindow = selectgamewnd;
            selectgamewnd.Show();
            Close();
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
