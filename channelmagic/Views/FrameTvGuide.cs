using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ChannelMagic.Source;
using Newtonsoft.Json;

namespace ChannelMagic.Views
{
    public partial class FrameTvGuide : Form
    {
        private Rectangle rect;
        
        public FrameTvGuide() {
            InitializeComponent();
        }

        private void FrameTvGuide_Load(object sender, EventArgs e) {


            // configure browser
            browserGuide.Dock = DockStyle.Fill;
            browserGuide.ScrollBarsEnabled = false;
            browserGuide.ScriptErrorsSuppressed = false;
            browserGuide.WebBrowserShortcutsEnabled = false;
            browserGuide.IsWebBrowserContextMenuEnabled = true;


            // load HTML document from embedded resource link
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "ChannelMagic.WebApp.guide.html";
     
            using (StreamReader reader = new StreamReader(assembly.GetManifestResourceStream(resourceName))) {
                string result = reader.ReadToEnd();

                string channelJson = JsonConvert.SerializeObject(ChannelManager.channels);
                result = result.Replace("[CHANNEL_JSON]", channelJson);
                browserGuide.DocumentText = result;
            }

            // TBD CHECK FULLSCREEN OR NOT
            rect = new Rectangle(App.frameMain.Left, App.frameMain.Top, App.frameMain.Width, App.frameMain.Height);
            this.Location = new Point(rect.X, rect.Y);
            this.Size = new Size(rect.Width, rect.Height);

            //this.Focus();
        }

        private void FrameTvGuide_KeyPress(object sender, KeyPressEventArgs e) {
            //Console.WriteLine(e.KeyChar);
        }

        private void FrameTvGuide_Leave(object sender, EventArgs e) {
            //this.Focus();
        }

        private void timerCheckFocus_Tick(object sender, EventArgs e) {
            //this.Focus();
        }

       protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
           Console.WriteLine("Key: " + keyData);

            if (keyData == Keys.F1) {
                MessageBox.Show("You pressed the F1 key");
                return true;    // indicate that you handled this keystroke
            }

            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
