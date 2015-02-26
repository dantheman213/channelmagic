using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ChannelMagic.Views;
using ChannelMagic.Models;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Diagnostics;
using System.Security.Cryptography;


namespace ChannelMagic.Source
{
    public static class App
    {
        public static FrameMain frameMain = null;
        public static FrameTvGuide frameGuide = null;
        public static FrameMediaControls frameControls = null;

        // *** show/hide taskbar *** \\
        [DllImport("user32.dll")]
        private static extern int FindWindow(string className, string windowText);
        [DllImport("user32.dll")]
        private static extern int ShowWindow(int hwnd, int command);

        private const int SW_HIDE = 0;
        private const int SW_SHOW = 1;
        // *** end *** \\

        private static readonly RNGCryptoServiceProvider _generator = new RNGCryptoServiceProvider();


        public static AppSettingsModel settings = null;
        private static List<MonitorInfoModel> monitorInfo = null;
        private static short primaryMonitorIndex = 0;
        private static Random rand = null;

        public static void init() {

            settings = new AppSettingsModel();
            // TBD load app data

            getMonitorData();
            frameGuide = new FrameTvGuide();

        }

        public static  MonitorInfoModel getPrimaryMonitorInfo() {
            return monitorInfo[primaryMonitorIndex];
        }

        public static void exitApplication() {

            Application.Exit();
        }

        private static void getMonitorData() {
            monitorInfo = new List<MonitorInfoModel>();

            foreach (var screen in Screen.AllScreens) {
                MonitorInfoModel mInfo = new MonitorInfoModel();
                mInfo.DeviceName = screen.DeviceName;
                mInfo.Dimensions = screen.Bounds;
                mInfo.Type = screen.GetType().ToString();

                monitorInfo.Add(mInfo);
            }
        }
        


        public static void showWinTaskbar(bool visible) {
            int hwnd = FindWindow("Shell_TrayWnd", "");

            if(visible)
                ShowWindow(hwnd, SW_SHOW);
            else
                ShowWindow(hwnd, SW_HIDE);
        }

        public static string getApplicationPath() {
            string path = System.IO.Path.GetDirectoryName(
               System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase
            );

            if (path.Substring(0, 5) == "file:") {
                // remove 'file://' out of the path
                path = path.Substring(6);
            }

            return path + "\\";
        }


        public static string getApplicationExePath() {
            string path = getApplicationPath() + "channelmagic.exe";
            return path;
        }

        public static int generateRandomNumber(int min, int max) {

            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buffer = new byte[4];

            rng.GetBytes(buffer);
            int result = BitConverter.ToInt32(buffer, 0);

            return new Random(result).Next(min, max);
        }

        public static List<string> findMediaFilesInDirectory(string sDir) {


            var items =  Directory.GetFiles(sDir, "*.*", SearchOption.AllDirectories).Where(x =>
                x.EndsWith("avi")  ||
                x.EndsWith("mp4")  ||
                x.EndsWith("m4v")  ||
                x.EndsWith("divx") ||
                x.EndsWith("flv")  ||
                x.EndsWith("ogv")  ||
                x.EndsWith("mpe")  ||
                x.EndsWith("mkv")  ||
                x.EndsWith("mpg")  ||
                x.EndsWith("mpeg") ||
                x.EndsWith("m1s")  ||
                x.EndsWith("mov")  ||
                x.EndsWith("wmv")  ||
                x.EndsWith("m2ts") ||
                x.EndsWith("3gp")
            );

            List<string> paths = new List<string>();

            foreach (var path in items) {

                paths.Add(path);
            }

            return paths;
        }
    }
}
