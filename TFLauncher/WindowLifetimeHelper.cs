using CefSharp.Wpf;
using System.Windows;
using System.Windows.Controls;

namespace TFLauncher
{
    internal static class WindowLifetimeHelper
    {
        internal static void CleanupMediaElement(MediaElement mediaElement)
        {
            if (mediaElement == null)
            {
                return;
            }

            try
            {
                mediaElement.Stop();
                mediaElement.LoadedBehavior = MediaState.Manual;
                mediaElement.UnloadedBehavior = MediaState.Manual;
                mediaElement.Source = null;
            }
            catch
            {
            }
        }

        internal static void CleanupBrowser(ChromiumWebBrowser browser)
        {
            if (browser == null)
            {
                return;
            }

            try
            {
                browser.Dispose();
            }
            catch
            {
            }
        }

        internal static bool ShowOwnedDialog(Window owner, Window dialog)
        {
            if (dialog == null)
            {
                return false;
            }

            if (owner != null && owner != dialog)
            {
                dialog.Owner = owner;
            }

            bool? dialogResult = dialog.ShowDialog();
            return dialogResult.HasValue && dialogResult.Value;
        }
    }
}
