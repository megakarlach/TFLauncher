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
using CefSharp;
using CefSharp.Wpf;
using System.Diagnostics;

namespace TFLauncher
{
    /// <summary>
    /// Interaction logic for TF2142Window2.xaml
    /// </summary>
    public partial class TF2142Window2 : Window
    {
        public TF2142Window2()
        {
            InitializeComponent();
        }

        private void GoBackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainwin = new MainWindow();
            mainwin.ShowDialog();
        }
        private void BackPage1Btn_Click(object sender, RoutedEventArgs e)
        {
            // Previous page.
            this.Hide();
            TF2142Window tf2142win = new TF2142Window();
            tf2142win.ShowDialog();
        }
        private void NextPage3Btn_Click(object sender, RoutedEventArgs e)
        {
            // Next page.
            this.Hide();
            TF2142Window3 tf2142win3 = new TF2142Window3();
            tf2142win3.ShowDialog();
        }
        private void PlayTF2142NoMusicBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTetFuck2142();
            Launcher.ExitMe();
        }

        private void UseLegacyTF2142Launcher_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTF2142LegacyLauncher();
            Launcher.ExitMe();
        }

        private void PlayTF2142Mus1Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTF2142Mus1();
            Launcher.ExitMe();
        }

        private void PlayTF2142Mus1aBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTF2142Mus1a();
            Launcher.ExitMe();
        }

        private void PlayTF2142Mus2Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTF2142Mus2();
            Launcher.ExitMe();
        }
        private void PlayTF2142Mus3Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTF2142Mus3();
            Launcher.ExitMe();
        }
        private void PlayTF2142Mus4Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTF2142Mus4();
            Launcher.ExitMe();
        }
        private void PlayTF2142Mus5Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTF2142Mus5();
            Launcher.ExitMe();
        }
        private void PlayTF2142Mus6Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTF2142Mus6();
            Launcher.ExitMe();
        }
        private void PlayTF2142Mus7Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTF2142Mus7();
            Launcher.ExitMe();
        }
        private void PlayTF2142Mus8Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTF2142Mus8();
            Launcher.ExitMe();
        }
        private void PlayTF2142Mus9Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTF2142Mus9();
            Launcher.ExitMe();
        }
        private void PlayTF2142Mus10Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTF2142Mus10();
            Launcher.ExitMe();
        }
        private void PlayTF2142Mus11Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTF2142Mus11();
            Launcher.ExitMe();
        }
        private void PlayTF2142Mus12Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTF2142Mus12();
            Launcher.ExitMe();
        }
        private void PlayTF2142Mus13Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTF2142Mus13();
            Launcher.ExitMe();
        }
        private void PlayTF2142Mus14Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTF2142Mus14();
            Launcher.ExitMe();
        }
        private void PlayTF2142Mus15Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTF2142Mus15();
            Launcher.ExitMe();
        }
        private void PlayTF2142Mus15bBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTF2142Mus15b();
            Launcher.ExitMe();
        }
        private void PlayTF2142Mus16Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTF2142Mus16();
            Launcher.ExitMe();
        }
        private void PlayTF2142Mus17Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTF2142Mus17();
            Launcher.ExitMe();
        }
        private void PlayTF2142Mus18Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTF2142Mus18();
            Launcher.ExitMe();
        }
        private void PlayTF2142Mus19Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTF2142Mus19();
            Launcher.ExitMe();
        }
        private void PlayTF2142Mus20Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTF2142Mus20();
            Launcher.ExitMe();
        }
        private void PlayTF2142Mus21Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTF2142Mus21();
            Launcher.ExitMe();
        }
        private void PlayTF2142Mus22Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTF2142Mus22();
            Launcher.ExitMe();
        }
        private void PlayTF2142Mus23Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTF2142Mus23();
            Launcher.ExitMe();
        }
        private void PlayTF2142Mus24Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTF2142Mus24();
            Launcher.ExitMe();
        }
        private void PlayTF2142Mus25Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTF2142Mus25();
            Launcher.ExitMe();
        }
        private void PlayTF2142Mus26Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTF2142Mus26();
            Launcher.ExitMe();
        }
        private void PlayTF2142Mus27Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTF2142Mus27();
            Launcher.ExitMe();
        }
        private void PlayTF2142Mus28Btn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.OpenTF2142Mus28();
            Launcher.ExitMe();
        }

        private void QuitBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.ExitMe();
        }
    }
}
