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
    /// Interaction logic for CunnyCrisisWindow.xaml
    /// </summary>
    public partial class CunnyCrisisWindow : Window
    {
        public CunnyCrisisWindow()
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
        private void PlayCunnyCrysisBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            Launcher.OpenCunnyCrisis();
            Launcher.ExitMe();
        }

        private void PlayCunnyCrisisNSFWBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            Launcher.LaunchWebsite("https://www.youtube.com/watch?v=iuQB-vQRYfU");
            Launcher.ExitMe();
        }

        private void EAFIFAClubBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            Launcher.LaunchWebsite("http://web.archive.org/web/20130121005058/http://www.ea.com/soccer/fifa/xbox"); //link updated 3/21/2026
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
            animatedgameplay.Stop();
            EATraxWindow eatraxwnd = new EATraxWindow();
            eatraxwnd.Show();
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
