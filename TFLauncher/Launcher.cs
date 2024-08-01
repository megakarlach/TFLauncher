﻿using System;
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
        public static void PlayBtnSound()
        {
            SoundPlayer buttonclickrelease = new SoundPlayer(@".\sound\buttonclickrelease.wav");
            buttonclickrelease.Load();
            buttonclickrelease.Play();
        }
        // TetFuck 2142
        public static void OpenTetFuck2142()
        {
            Process.Start("StartTF2142_NoMUS.cmd");
        }
        public static void OpenTF2142AllMusic()
        {
            Process.Start("tf2142_allmusic.cmd");
        }
        public static void OpenTF2142Mus1()
        {
            Process.Start("StartTF2142_MUS1.cmd");
        }
        public static void OpenTF2142Mus2()
        {
            Process.Start("StartTF2142_MUS2.cmd");
        }
        public static void OpenTF2142Mus3()
        {
            Process.Start("StartTF2142_MUS3.cmd");
        }
        public static void OpenTF2142Mus4()
        {
            Process.Start("StartTF2142_MUS4.cmd");
        }
        public static void OpenTF2142LegacyLauncher()
        {
            Process.Start("StartTF2142_Legacy.cmd");
        }
        // TetFuck 2142
        // TetFuck 4000
        public static void OpenTetFuck4000()
        {
            Process.Start("StartTF4000.cmd");
        }
        public static void OpenTetFuck4000Setup()
        {
            Process.Start("StartTF4000Setup.cmd");
        }
        // TetFuck 5000
        public static void OpenTetFuck5000()
        {
            Process.Start("StartTF5000.cmd");
        }
        // Cunny Crisis (Puyo Puyo)
        public static void OpenCunnyCrisis()
        {
            Process.Start("StartCunnyCrisis.cmd");
        }
    }
}
