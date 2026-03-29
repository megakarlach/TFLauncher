using CefSharp;
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

namespace TFLauncher
{
    /// <summary>
    /// Interaction logic for TFChkUpdateWindow.xaml
    /// </summary>
    public partial class TFChkUpdateWindow : Window
    {
        public TFChkUpdateWindow()
        {
            InitializeComponent();
            var settings = new CefSettings();

            // Enable GPU
            settings.CefCommandLineArgs.Add("enable-gpu", "1");
            settings.CefCommandLineArgs.Add("disable-gpu-vsync", "1");
            settings.CefCommandLineArgs.Add("disable-software-rasterizer", "1");

            // Optional tweaks
            settings.CefCommandLineArgs.Add("enable-begin-frame-scheduling", "1");
            settings.CefCommandLineArgs.Add("enable-gpu-compositing", "1");
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
            this.Content = null;
            this.Close();
        }

        private void brokenBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.LaunchWebsite("https://archive.org/details/NineInchNails-Broken/");
            Launcher.ExitMe();
        }
    }
}
