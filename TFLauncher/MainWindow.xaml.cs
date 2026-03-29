using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Diagnostics;
using System.Runtime.InteropServices;
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
        Process mpvProcess;
        JobObject job;

        void PlayLauncherBGMusic()
        {
            try
            {
                // random number generator (NO LONGER NEEDED, WE JUST GO FULL EA TRAX SHUFFLE THIS TIME, LIKE FIFA/FC GAMES
                // Random random = new Random();
                // int randomInRange = random.Next(1, 7); // Upper bound is exclusive
                // Console.WriteLine($"Random Integer Test: {randomInRange}");

                // playing launcher background music
                mpvProcess = new Process();
                mpvProcess.StartInfo.FileName = ".\\..\\third-party\\mpv\\mpv-tetfuck.exe";
                mpvProcess.StartInfo.WorkingDirectory = ".\\..\\third-party\\mpv\\";
                mpvProcess.StartInfo.Arguments = ($"--no-osc --no-input-default-bindings --no-config --window-scale=0.1 --force-window=no --loop=inf --volume=75 --shuffle --vo=null .\\..\\..\\tf_shared\\sound\\ui_launcher\\eatrax.m3u"); // Command line
                mpvProcess.StartInfo.UseShellExecute = false;
                mpvProcess.StartInfo.CreateNoWindow = false;

                mpvProcess.Start();
                job.AddProcess(mpvProcess.Handle);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // job object
        public class JobObject : IDisposable
        {
            private IntPtr handle;

            public JobObject()
            {
                handle = CreateJobObject(IntPtr.Zero, null);

                JOBOBJECT_BASIC_LIMIT_INFORMATION info = new JOBOBJECT_BASIC_LIMIT_INFORMATION
                {
                    LimitFlags = 0x2000 // JOB_OBJECT_LIMIT_KILL_ON_JOB_CLOSE
                };

                JOBOBJECT_EXTENDED_LIMIT_INFORMATION extendedInfo =
                    new JOBOBJECT_EXTENDED_LIMIT_INFORMATION
                    {
                        BasicLimitInformation = info
                    };

                int length = Marshal.SizeOf(typeof(JOBOBJECT_EXTENDED_LIMIT_INFORMATION));
                IntPtr extendedInfoPtr = Marshal.AllocHGlobal(length);

                Marshal.StructureToPtr(extendedInfo, extendedInfoPtr, false);

                SetInformationJobObject(handle,
                    JobObjectInfoType.ExtendedLimitInformation,
                    extendedInfoPtr,
                    (uint)length);

                Marshal.FreeHGlobal(extendedInfoPtr);
            }

            public bool AddProcess(IntPtr processHandle)
            {
                return AssignProcessToJobObject(handle, processHandle);
            }

            public void Dispose()
            {
                CloseHandle(handle);
            }

            [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
            static extern IntPtr CreateJobObject(IntPtr lpJobAttributes, string name);

            [DllImport("kernel32.dll")]
            static extern bool SetInformationJobObject(
                IntPtr hJob,
                JobObjectInfoType infoType,
                IntPtr lpJobObjectInfo,
                uint cbJobObjectInfoLength);

            [DllImport("kernel32.dll")]
            static extern bool AssignProcessToJobObject(IntPtr job, IntPtr process);

            [DllImport("kernel32.dll")]
            static extern bool CloseHandle(IntPtr handle);

            enum JobObjectInfoType
            {
                ExtendedLimitInformation = 9
            }

            [StructLayout(LayoutKind.Sequential)]
            struct JOBOBJECT_BASIC_LIMIT_INFORMATION
            {
                public long PerProcessUserTimeLimit;
                public long PerJobUserTimeLimit;
                public uint LimitFlags;
                public UIntPtr MinimumWorkingSetSize;
                public UIntPtr MaximumWorkingSetSize;
                public uint ActiveProcessLimit;
                public UIntPtr Affinity;
                public uint PriorityClass;
                public uint SchedulingClass;
            }

            [StructLayout(LayoutKind.Sequential)]
            struct IO_COUNTERS
            {
                public ulong ReadOperationCount;
                public ulong WriteOperationCount;
                public ulong OtherOperationCount;
                public ulong ReadTransferCount;
                public ulong WriteTransferCount;
                public ulong OtherTransferCount;
            }

            [StructLayout(LayoutKind.Sequential)]
            struct JOBOBJECT_EXTENDED_LIMIT_INFORMATION
            {
                public JOBOBJECT_BASIC_LIMIT_INFORMATION BasicLimitInformation;
                public IO_COUNTERS IoInfo;
                public UIntPtr ProcessMemoryLimit;
                public UIntPtr JobMemoryLimit;
                public UIntPtr PeakProcessMemoryUsed;
                public UIntPtr PeakJobMemoryUsed;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            job = new JobObject();

            PlayLauncherBGMusic();
        }

        // This kill MPV process when closing the game
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);

            try
            {
                if (mpvProcess != null && !mpvProcess.HasExited)
                {
                    mpvProcess.CloseMainWindow(); // try graceful shutdown
                    mpvProcess.Kill();            // force if needed
                }
            }
            catch { }
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
            SelectGameWindow selectgamewin = new SelectGameWindow();
            selectgamewin.Show();
            this.Content = null;
            this.Hide();
        }
    }
}
