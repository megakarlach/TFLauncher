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

        private void button_BACK_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            animatedBG.Stop(); // Stop video playback
            SelectGameWindow selectgamewnd = new SelectGameWindow();
            selectgamewnd.ShowDialog();
            this.Content = null;
            this.Close();
        }
    }
}
