using System;
using System.Windows;
using System.Windows.Input;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Reflection;


namespace TFLauncher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Process mpvProcess;
        JobObject job;
        public MainWindow()
        {
            InitializeComponent();
            SetVersionLabel();
            job = new JobObject();

            PlayLauncherBGMusic();
        }

        private void SetVersionLabel()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;

            DateTime dotNetBaseDate = new DateTime(2000, 1, 1);

            DateTime buildDate = dotNetBaseDate.AddDays(version.Build)
                                               .AddSeconds(version.Revision * 2);

            int customBuildNumber = (buildDate - LauncherVerInfo.CustomBaseDate).Days;

            versionlabel.Content =
                $"TetFuck Launcher v{LauncherVerInfo.Version} build {customBuildNumber} | {buildDate:yyyy-MM-dd} | {LauncherVerInfo.Codename}";
        }

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
            finally
            {
                if (mpvProcess != null)
                {
                    mpvProcess.Dispose();
                    mpvProcess = null;
                }

                if (job != null)
                {
                    job.Dispose();
                    job = null;
                }
            }
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
            WindowLifetimeHelper.ShowOwnedDialog(this, aboutpopup);
        }

        private void HelpBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayBtnSound();
            TF_Help_Window aboutpopup = new TF_Help_Window();
            WindowLifetimeHelper.ShowOwnedDialog(this, aboutpopup);
        }
        // TOP BAR STUFF

        private void selectgamebtn_Click(object sender, RoutedEventArgs e)
        { //click to select game btn
            Launcher.PlayBtnSound();
            SelectGameWindow selectgamewin = new SelectGameWindow();
            Application.Current.MainWindow = selectgamewin;
            selectgamewin.Show();
            Hide();
        }
    }
}
