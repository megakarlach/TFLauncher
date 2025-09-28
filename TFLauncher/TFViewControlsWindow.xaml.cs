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
    /// Interaction logic for TFViewControlsWindow.xaml
    /// </summary>
    public partial class TFViewControlsWindow : Window
    {
        public TFViewControlsWindow()
        {
            InitializeComponent();
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
            this.Close();
        }
    }
}
