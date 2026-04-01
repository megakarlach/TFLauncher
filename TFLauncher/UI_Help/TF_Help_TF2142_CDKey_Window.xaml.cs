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
    /// </summary>
    public partial class TF_Help_TF2142_CDKey_Window : Window
    {
        public TF_Help_TF2142_CDKey_Window()
        {
            InitializeComponent();
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            WindowLifetimeHelper.CleanupBrowser(browserwnd);
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

        private void OKbtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
