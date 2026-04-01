using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using CefSharp;

namespace TFLauncher
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            this.DispatcherUnhandledException += (s, e) =>
            {
                MessageBox.Show(e.Exception.ToString(), "Crash");
                e.Handled = true;
            };

            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
            {
                MessageBox.Show(e.ExceptionObject.ToString(), "Fatal Crash");
            };

            InitializeCef();
            ShutdownMode = ShutdownMode.OnExplicitShutdown;
        }

        private static void InitializeCef()
        {
            if (Cef.IsInitialized)
            {
                return;
            }

            var settings = new CefSettings();
            settings.CefCommandLineArgs.Add("enable-gpu", "1");
            settings.CefCommandLineArgs.Add("disable-gpu-vsync", "1");
            settings.CefCommandLineArgs.Add("disable-software-rasterizer", "1");
            settings.CefCommandLineArgs.Add("enable-begin-frame-scheduling", "1");
            settings.CefCommandLineArgs.Add("enable-gpu-compositing", "1");

            Cef.Initialize(settings);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            if (Cef.IsInitialized)
            {
                Cef.Shutdown();
            }

            base.OnExit(e);
        }
    }
}
