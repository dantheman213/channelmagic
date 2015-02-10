using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ChannelMagic.Source;

namespace ChannelMagic.Views
{
    public partial class FrameMediaControls : Form
    {

        public FrameMediaControls() {
            InitializeComponent();
        }

        protected override bool ShowWithoutActivation {
            get { return true; }
        }

        private void buttonPlayPause_Click(object sender, EventArgs e) {

            ChannelManager.playPause();
            App.frameMain.Focus();
        }

        private void buttonMute_Click(object sender, EventArgs e) {

            ChannelManager.mute();
            App.frameMain.Focus();
        }

        private void FrameMediaControls_Load(object sender, EventArgs e) {

            App.frameControls = this;
        }

        public void positionFrame(Point windowPos, Size dimensions) {
            this.StartPosition = FormStartPosition.Manual;
            
            int x = windowPos.X + (dimensions.Width - (this.Width) - 200);
            int y = windowPos.Y + Convert.ToInt32(dimensions.Height * 0.7);

            this.Location = new Point(x, y);
        }

        private void buttonSkipProgram_Click(object sender, EventArgs e) {
            ChannelManager.playMediaItem();
            App.frameMain.Focus();
        }

        private void buttonFullscreenToggle_Click(object sender, EventArgs e) {
            App.frameMain.fullScreenToolStripMenuItem_Click(null, null);

            App.frameMain.Focus();
        }

        private void FrameMediaControls_Click(object sender, EventArgs e) {

            App.frameMain.Focus();
        }
    }
}
