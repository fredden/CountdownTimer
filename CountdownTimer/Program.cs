using System;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace CountdownTimer
{
    static class Program
    {

        // https://stackoverflow.com/questions/19147/what-is-the-correct-way-to-create-a-single-instance-application
        // http://sanity-free.org/143/csharp_dotnet_single_instance_application.html
        private static Mutex mutex = mutex = new Mutex(true, "MutexString:{d2a923ea-32d9-40dd-abfc-8c409b231b30}");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
                mutex.ReleaseMutex();
            } else
            {
                // send our Win32 message to make the currently running instance
                // jump on top of all the other windows
                NativeMethods.PostMessage(
                    (IntPtr)NativeMethods.HWND_BROADCAST,
                    NativeMethods.WM_SHOWME,
                    IntPtr.Zero,
                    IntPtr.Zero);
            }
        }
    }

    // this class just wraps some Win32 stuff that we're going to use
    internal class NativeMethods
    {
        public const int HWND_BROADCAST = 0xffff;
        public static readonly int WM_SHOWME = RegisterWindowMessage("WM_SHOWME");
        [DllImport("user32")]
        public static extern bool PostMessage(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam);
        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string message);
    }

}
