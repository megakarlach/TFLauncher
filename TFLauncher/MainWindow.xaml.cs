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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Launcher.PlayLauncherBGMusic(); // play bg music
        }

        private void animatedBG_Loaded(object sender, RoutedEventArgs e)
        {
            // animatedBG.Play();            // playing animated bg
        }

        private void animatedBG_Ended(object sender, RoutedEventArgs e)
        {

           // animatedBG.Position = TimeSpan.FromSeconds(0);

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

        private void selectgamebtn_Click(object sender, RoutedEventArgs e)
        { //click to select game btn
            Launcher.PlayBtnSound();
            // animatedBG.Stop(); // stop animated BG (UNUSED)
            // Open up the select game window.
            this.Hide();
            SelectGameWindow selectgamewin = new SelectGameWindow();
            selectgamewin.ShowDialog();
        }
        // UPDATE POPUP 2025
        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            TFChkUpdateWindow aboutpopup = new TFChkUpdateWindow();
            aboutpopup.ShowDialog();
        }
    }
}
