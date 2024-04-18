using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TFLauncher
{
    class Launcher
    {
        public static void OpenTetFuck2142()
        {
            Process.Start("test.cmd");
        }
        public static void OpenTetFuck5000()
        {
            Process.Start("test.cmd");
        }
        public static void LaunchWebsite(string url)
        {
            Process.Start(url);
        }
        public static void Quit()
        {
            Environment.Exit(0);
        }
    }
}
