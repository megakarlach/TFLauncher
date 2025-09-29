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
        {   //Shutdown startup menu music
            string processName = "mpv-tetfuck"; // Replace with the desired process name (without .exe)

            try
            {
                // Get all processes with the specified name
                Process[] processes = Process.GetProcessesByName(processName);

                foreach (Process process in processes)
                {
                    // Terminate the process
                    process.Kill();
                    process.WaitForExit(); // Optional: Wait for the process to exit
                    process.Dispose(); // Release resources
                    Console.WriteLine($"Process {processName} (ID: {process.Id}) terminated.");
                }

                if (processes.Length == 0)
                {
                    Console.WriteLine($"No processes found with the name '{processName}'.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            System.Windows.Application.Current.Shutdown(); //Close launcher

        }

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

        public static void PlayLauncherBGMusic()
        {
            // random number generator
            Random random = new Random();
            int randomInRange = random.Next(1, 13); // Upper bound is exclusive
            Console.WriteLine($"Random Integer Test (1-100): {randomInRange}");

            // playing music
            var startBGMusic = new ProcessStartInfo
            {
                FileName = "..\\third-party\\mpv\\mpv-tetfuck.exe",
                WorkingDirectory = "..\\third-party\\mpv\\",
                Arguments = ($"--no-osc --no-input-default-bindings --no-config --window-scale=0.1 --force-window=no --volume=90 --vo=null .\\..\\..\\tf_shared\\sound\\ui_launcher\\gamestartup{randomInRange}.m4a"), // Command line
                UseShellExecute = false,   // Required for certain applications
                CreateNoWindow = false    // Show the window
            };
            Process.Start(startBGMusic);
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
                FileName = "..\\tf2142\\bin\\TetFuck2142NG.exe",
                WorkingDirectory = ".\\..\\tf2142\\bin\\",
                Arguments = "", // Command line
                UseShellExecute = false,   // Required for certain applications
                CreateNoWindow = false    // Show the window
            };

            Process.Start(startTF2142);
        }
        // TetFuck 2142 with Music
        public static void OpenTF2142AllMusic()
        {
            var startTF2142 = new ProcessStartInfo
            {
                FileName = "..\\tf2142\\bin\\TetFuck2142NG.exe",
                WorkingDirectory = "..\\tf2142\\bin\\",
                Arguments = "", // Command line
                UseShellExecute = false,   // Required for certain applications
                CreateNoWindow = false    // Show the window
            };
            var startTF2142withMusic = new ProcessStartInfo
            {
                FileName = "..\\third-party\\vlc\\vlc.exe",
                Arguments = "-Iskins --skins2-last=..\\third-party\\vlc\\skins\\ifon.vlt ..\\tf_shared\\sound\\music_mp3\\tf_playlist.m3u", // Command line
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
                WorkingDirectory = "..\\tf4000\\",
                Arguments = "", // Command line
                UseShellExecute = false,   // Required for certain applications
                CreateNoWindow = false    // Show the window
            };

            Process.Start(startTF4000);
        }
        public static void OpenTetFuck4000Setup()
        {
            var startTF4000CFG = new ProcessStartInfo
            {
                FileName = "..\\tf4000\\tf_config.exe",
                WorkingDirectory = "..\\tf4000\\",
                Arguments = "", // Command line
                UseShellExecute = false,   // Required for certain applications
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
                WorkingDirectory = "..\\tf4000_enhanced\\",
                Arguments = "", // Command line
                UseShellExecute = false,   // Required for certain applications
                CreateNoWindow = false    // Show the window
            };

            Process.Start(startTF4000E);
        }
        public static void OpenTetFuck4000ESetup()
        {
            var startTF4000ECFG = new ProcessStartInfo
            {
                FileName = "..\\tf4000_enhanced\\tf_config.exe",
                WorkingDirectory = "..\\tf4000_enhanced\\",
                Arguments = "", // Command line
                UseShellExecute = false,   // Required for certain applications
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
                WorkingDirectory = "..\\tf5000\\",
                Arguments = "", // Command line
                UseShellExecute = false,   // Required for certain applications
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
                WorkingDirectory = "..\\tf5000_enhanced\\",
                Arguments = "", // Command line
                UseShellExecute = false,   // Required for certain applications
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
                WorkingDirectory = "..\\cunnycrisis\\",
                Arguments = "", // Command line
                UseShellExecute = false,   // Required for certain applications
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
                WorkingDirectory = "..\\tetrizz\\",
                Arguments = "", // Command line
                UseShellExecute = false,   // Required for certain applications
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
                WorkingDirectory = "..\\tetrizz_enhanced\\",
                Arguments = "", // Command line
                UseShellExecute = false,   // Required for certain applications
                CreateNoWindow = false    // Show the window
            };

            Process.Start(startTetRizzE);
        }
    }
}
