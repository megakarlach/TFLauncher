using System;
using System.Windows;
using System.Windows.Input;

namespace TFLauncher
{
    /// <summary>
    /// Interaction logic for SelectGameWindow.xaml
    /// </summary>
    public partial class EATraxWindow : Window
    {

        public EATraxWindow()
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

        private void button_BACK_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            SelectGameWindow selectgamewnd = new SelectGameWindow();
            Application.Current.MainWindow = selectgamewnd;
            selectgamewnd.Show();
            Close();
        }
    }
}
