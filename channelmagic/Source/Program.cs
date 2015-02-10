using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using ChannelMagic.Source;
using ChannelMagic.Views;

namespace ChannelMagic
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Database.init();
            App.init();
            ChannelManager.init();

            Application.Run(new FrameMain());
        }
    }
}
