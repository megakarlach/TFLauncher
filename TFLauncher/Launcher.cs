using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Media;

namespace TFLauncher
{
    class Launcher
    {
        public static void ExitMe()
        { System.Windows.Application.Current.Shutdown(); }
        public static void LaunchWebsite(string url)
        {
            Process.Start(url);
        }
        public static void PlayHoverBtnSound()
        {
            SoundPlayer buttonclickrollover = new SoundPlayer(@".\sound\buttonrollover.wav");
            buttonclickrollover.Load();
            buttonclickrollover.Play();
        }
        public static void PlayBtnSound()
        {
            SoundPlayer buttonclickrelease = new SoundPlayer(@".\sound\buttonclickrelease.wav");
            buttonclickrelease.Load();
            buttonclickrelease.Play();
        }
        public static void PlayScrollBtnSound()
        {
            SoundPlayer buttonclickrelease = new SoundPlayer(@".\sound\csgo_ui_page_scroll.wav");
            buttonclickrelease.Load();
            buttonclickrelease.Play();
        }

        // See music setlist for TetFuck 2142 (Excel)
        public static void OpenSetlist()
        {
            Process.Start("ListOfTetFuckOST.xls");
        }

        // TetFuck 2142
        public static void OpenTetFuck2142()
        {
            var startTF2142 = new ProcessStartInfo
            {
                FileName = "..\\tf2142\\TetFuck2142NG.exe",
                Arguments = "", // Command line
                UseShellExecute = true,   // Required for certain applications
                CreateNoWindow = false    // Show the window
            };

            Process.Start(startTF2142);
        }
        // TetFuck 2142 with Music
        public static void OpenTF2142AllMusic()
        {
            var startTF2142 = new ProcessStartInfo
            {
                FileName = "..\\tf2142\\TetFuck2142NG.exe",
                Arguments = "", // Command line
                UseShellExecute = true,   // Required for certain applications
                CreateNoWindow = false    // Show the window
            };
            var startTF2142withMusic = new ProcessStartInfo
            {
                FileName = "..\\third-party\\vlc\\vlc.exe",
                Arguments = "-Iskins --skins2-last=.\\skins\\ifon.vlt", // Command line
                UseShellExecute = true,   // Required for certain applications
                CreateNoWindow = false    // Show the window
            };
            Process.Start(startTF2142);
            Process.Start(startTF2142withMusic);
        }
//        DEPRECATED
//        public static void OpenTF2142LegacyLauncher()
//        {
//            Process.Start("StartTF2142_Legacy.cmd");
//        }
        // TetFuck 2142 end
        // TetFuck 4000
        public static void OpenTetFuck4000()
        {
            var startTF4000 = new ProcessStartInfo
            {
                FileName = "..\\tf4000\\TetFuck4K.exe",
                Arguments = "", // Command line
                UseShellExecute = true,   // Required for certain applications
                CreateNoWindow = false    // Show the window
            };

            Process.Start(startTF4000);
        }
        public static void OpenTetFuck4000Setup()
        {
            var startTF4000CFG = new ProcessStartInfo
            {
                FileName = "..\\tf4000\\tf_config.exe",
                Arguments = "", // Command line
                UseShellExecute = true,   // Required for certain applications
                CreateNoWindow = false    // Show the window
            };

            Process.Start(startTF4000CFG);
        }
        // TetFuck 4000 Enhanced
        public static void OpenTetFuck4000E()
        {
            var startTF4000E = new ProcessStartInfo
            {
                FileName = "..\\tf4000_enhanced\\TetFuck4K_Enhanced.exe",
                Arguments = "", // Command line
                UseShellExecute = true,   // Required for certain applications
                CreateNoWindow = false    // Show the window
            };

            Process.Start(startTF4000E);
        }
        public static void OpenTetFuck4000ESetup()
        {
            var startTF4000ECFG = new ProcessStartInfo
            {
                FileName = "..\\tf4000_enhanced\\tf_config.exe",
                Arguments = "", // Command line
                UseShellExecute = true,   // Required for certain applications
                CreateNoWindow = false    // Show the window
            };

            Process.Start(startTF4000ECFG);
        }
        // TetFuck 5000
        public static void OpenTetFuck5000()
        {
            var startTF5000 = new ProcessStartInfo
            {
                FileName = "..\\tf5000\\TetFuckV.exe",
                Arguments = "", // Command line
                UseShellExecute = true,   // Required for certain applications
                CreateNoWindow = false    // Show the window
            };

            Process.Start(startTF5000);
        }

        // TetFuck 5000 Enhanced
        public static void OpenTetFuck5000E()
        {
            var startTF5000E = new ProcessStartInfo
            {
                FileName = "..\\tf5000_enhanced\\TetFuckV_Enhanced.exe",
                Arguments = "", // Command line
                UseShellExecute = true,   // Required for certain applications
                CreateNoWindow = false    // Show the window
            };

            Process.Start(startTF5000E);
        }

        // Cunny Crisis (Puyo Puyo)
        public static void OpenCunnyCrisis()
        {
            var startKunnyKrysis = new ProcessStartInfo
            {
                FileName = "..\\cunnycrisis\\CandyCrisis.exe",
                Arguments = "", // Command line
                UseShellExecute = true,   // Required for certain applications
                CreateNoWindow = false    // Show the window
            };

            Process.Start(startKunnyKrysis);
        }
        // TetRizz
        public static void OpenTetRizz()
        {
            var startTetRizz = new ProcessStartInfo
            {
                FileName = "..\\tetrizz\\runme.exe",
                Arguments = "", // Command line
                UseShellExecute = true,   // Required for certain applications
                CreateNoWindow = false    // Show the window
            };

            Process.Start(startTetRizz);
        }

        // TetRizz Enhanced
        public static void OpenTetRizzEnhanced()
        {
            var startTetRizzE = new ProcessStartInfo
            {
                FileName = "..\\tetrizz_enhanced\\runme.exe",
                Arguments = "", // Command line
                UseShellExecute = true,   // Required for certain applications
                CreateNoWindow = false    // Show the window
            };

            Process.Start(startTetRizzE);
        }
    }
}
