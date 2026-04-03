using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Reflection;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TFLauncher
{
    /// <summary>
    /// Interaction logic for TFAbout.xaml
    /// </summary>
    public partial class TFAbout : Window
    {
        public TFAbout()
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

            labellauncheraboutver.Content =
                $"Version {LauncherVerInfo.Version} Build {customBuildNumber} ({buildDate:yyyy-MM-dd})";
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

        private void OKbtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void brokenBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.LaunchWebsite("https://archive.org/details/NineInchNails-Broken/");
            Launcher.ExitMe();
        }
    }
}
