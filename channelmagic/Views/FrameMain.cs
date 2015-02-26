using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

using ChannelMagic.Source;
using ChannelMagic.Views;
using ChannelMagic.Models;

using WMPLib;

namespace ChannelMagic.Views {

    public partial class FrameMain : Form {
        private Point oldLocation;

        private short bMouseClickCount = 0;
        private Rectangle frameRect;

        private FrameMediaControls frameControls = null;
        private DateTime lastTimeMouseMoved;


        public FrameMain() {
            InitializeComponent();
        }

        private void libraryToolStripMenuItem_Click(object sender, EventArgs e) {
            FrameMediaLibrary frameLibrary = new FrameMediaLibrary();
            frameLibrary.ShowDialog();
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        public void showOverlay() {
            labelMediaTitle.Text = ChannelManager.currentScheduleItem.Title;
            labelMediaSubtitle.Text = ChannelManager.currentScheduleItem.SubTitle;
            labelChannelName.Text = ChannelManager.currentScheduleItem.ChannelName;
            labelChannelNumber.Text = (ChannelManager.currentScheduleItem.ChannelId + 1).ToString();

            labelChannelName.Left = this.Width = labelChannelName.Width - 15;

            labelMediaTitle.Visible = true;
            labelMediaSubtitle.Visible = true;
            labelChannelName.Visible = true;
            labelChannelNumber.Visible = true;

            timerOverlay.Enabled = false;
            timerOverlay.Enabled = true;
        }

        private void FrameMain_Load(object sender, EventArgs e) {

            ChannelManager.mediaPlayer = mediaPlayer;
            App.frameMain = this;


            // set HUD confg
            //labelMediaTitle.Parent = mediaPlayer;
            //labelMediaTitle.BackColor = Color.Transparent;
            //labelMediaSubtitle.BackColor = Color.Transparent;
            //labelChannelName.BackColor = Color.Transparent;
            //labelChannelNumber.BackColor = Color.Transparent;


            // Disable UI controls for media player
            mediaPlayer.Ctlenabled = false;
            mediaPlayer.uiMode = "none";

            // Disable context nenu for media player
            mediaPlayer.enableContextMenu = false;

            mediaPlayer.stretchToFit = true;

            mediaPlayer.closedCaption.SAMIFileName = "";

            if (ChannelManager.mediaTvShowItems.Count > 0)
                ChannelManager.playInitialVideo();

            frameControls = new FrameMediaControls();
            frameControls.positionFrame(new Point { X = this.Left, Y = this.Top }, new Size { Width = mediaPlayer.Width, Height = mediaPlayer.Height });
            //frameControls.Show();
            //App.showInactiveTopmost(frameControls);

            oldLocation = new Point(0, 0);

            mediaPlayer.Dock = DockStyle.Fill;

            FrameMain_Resize(null, null);
        }

        private void mediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e) {
            //if (e.newState == (int)MediaPlayerPlayStateEnum.Media_Ended) {
            if (e.newState == (int)WMPPlayState.wmppsMediaEnded) {

                timerPlayNextMediaItem.Enabled = true;
            } else if (e.newState == (int)WMPPlayState.wmppsPlaying) {

                //if(App.settings.IsFullscreen)
                // mediaPlayer.fullScreen = true;
            }
        }

        private void mediaPlayer_Enter(object sender, EventArgs e) {

        }

        private void timerPlayNextMediaItem_Tick(object sender, EventArgs e) {
            timerPlayNextMediaItem.Enabled = false;

            mediaPlayer.Ctlcontrols.stop();
            ChannelManager.playChannel(true);
        }

        private void mediaPlayer_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e) {
            //if (e.nButton == 1) {

            //    if (mediaPlayer.fullScreen)
            //        mediaPlayer.fullScreen = false;
            //    else
            //        mediaPlayer.fullScreen = true;                    
            //} else if (e.nButton == 2) {


            //}

            if (e.nButton == 1) {
                bMouseClickCount++;

                if (bMouseClickCount >= 2) {
                    // toggle full screen
                    //Console.WriteLine("double click");
                    fullScreenToolStripMenuItem_Click(null, null);
                } else {
                    timerMediaDoubleClick.Enabled = true;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            App.exitApplication();
        }

        public void fullScreenToolStripMenuItem_Click(object sender, EventArgs e) {

            if (App.settings.IsFullscreen) {
                fullScreenToolStripMenuItem.Checked = false;
                toggleFullscreen(false);

            } else {
                fullScreenToolStripMenuItem.Checked = true;
                toggleFullscreen(true);
            }
        }

        private void stretchToFitToolStripMenuItem_Click(object sender, EventArgs e) {
            // TBD figure out how to change aspect ratio

            if (App.settings.StretchToFit) {
                App.settings.StretchToFit = false;

                stretchToFitToolStripMenuItem.Checked = false;
            } else {

                App.settings.StretchToFit = true;

                stretchToFitToolStripMenuItem.Checked = true;
            }
        }

        private void timerMediaDoubleClick_Tick(object sender, EventArgs e) {
            timerMediaDoubleClick.Enabled = false;
            bMouseClickCount = 0;
        }

        private void toggleFullscreen(bool isFullscreen) {
            App.settings.IsFullscreen = isFullscreen;
            MonitorInfoModel monitor = App.getPrimaryMonitorInfo();

            if (isFullscreen) {
                // going into full screen

                frameRect.X = this.Left;
                frameRect.Y = this.Top;
                frameRect.Height = this.Height;
                frameRect.Width = this.Width;


                menu.Hide();
                this.FormBorderStyle = FormBorderStyle.None;
                App.showWinTaskbar(false);

                this.Location = new Point(0, 0);
                this.Size = new Size(monitor.Dimensions.Width, monitor.Dimensions.Height);
                //this.Top = 0;
                //this.Left = 0;
                //this.Width = monitor.Dimensions.Width;
                //this.Height = monitor.Dimensions.Height;

                timerCheckFocus.Enabled = true;
                Cursor.Hide();

            } else {
                timerCheckFocus.Enabled = false;

                //this.Top = frameRect.Y;
                //this.Left = frameRect.X;
                //this.Width = frameRect.Width;
                //this.Height = frameRect.Height;

                this.Location = new Point(frameRect.X, frameRect.Y);
                this.Size = new Size(frameRect.Width, frameRect.Height);

                menu.Show();
                this.FormBorderStyle = FormBorderStyle.Fixed3D;
                App.showWinTaskbar(true);

                this.Focus();
                Cursor.Show();
            }

            FrameMain_Resize(null, null);
        }

        private void skipCurrentProgramToolStripMenuItem_Click(object sender, EventArgs e) {

            ChannelManager.playMediaItem();

        }

        private void FrameMain_KeyDown(object sender, KeyEventArgs e) {

        }

        private void timerCheckFocus_Tick(object sender, EventArgs e) {

            if (App.settings.IsFullscreen && !this.Focused)
                this.Focus();
        }

        private void mediaPlayer_MouseMoveEvent(object sender, AxWMPLib._WMPOCXEvents_MouseMoveEvent e) {

            //if (oldLocation.X != e.fX && oldLocation.Y != e.fY) {
            //    oldLocation.X = e.fX;
            //    oldLocation.Y = e.fY;

            //    if (!frameControls.Visible) {
            //        frameControls.Show();
            //        timerHideControlMenu.Enabled = true;
            //    }

            //    lastTimeMouseMoved = DateTime.Now;
            //}

        }

        private void timerHideControlMenu_Tick(object sender, EventArgs e) {

            if (lastTimeMouseMoved.AddSeconds(3) <= DateTime.Now) {
                frameControls.Hide();
                timerHideControlMenu.Enabled = false;
            }
        }

        private void channelsToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void showTVGuideToolStripMenuItem_Click(object sender, EventArgs e) {

            if (App.settings.IsGuideVisible) {
                // hide the guide

                App.settings.IsGuideVisible = false;
                App.frameGuide.Hide();
            } else {
                // show guide

                App.settings.IsGuideVisible = true;
                App.frameGuide.Show();
            }

        }

        private void timerOverlay_Tick(object sender, EventArgs e) {
            timerOverlay.Enabled = false;

            labelMediaTitle.Visible = false;
            labelMediaSubtitle.Visible = false;
            labelChannelName.Visible = false;
            labelChannelNumber.Visible = false;
        }

        private void channelUpToolStripMenuItem_Click(object sender, EventArgs e) {

            ChannelManager.changeChannel("up");
        }

        private void channelDownToolStripMenuItem_Click(object sender, EventArgs e) {

            ChannelManager.changeChannel("down");
        }

        private void FrameMain_Resize(object sender, EventArgs e) {

            labelChannelName.Left = this.Width - labelChannelName.Width - 45;
            labelChannelNumber.Left = this.Width - labelChannelNumber.Width - 45;

        }

        private void playPauseToolStripMenuItem_Click(object sender, EventArgs e) {
            ChannelManager.playPause();
        }

        private void mediaPlayer_KeyDownEvent(object sender, AxWMPLib._WMPOCXEvents_KeyDownEvent e) {

            switch (e.nKeyCode) {
                case (short)Keys.Space:
                    ChannelManager.playPause();
                    break;
            
                case (short)Keys.Up:
                    ChannelManager.changeChannel("up");
                    break;
                
                case (short)Keys.Down:
                    ChannelManager.changeChannel("down");
                    break;

                case (short)Keys.Left:
                    mediaPlayer.Ctlcontrols.currentPosition -= 15;
                    break;

                case (short)Keys.Right:
                    mediaPlayer.Ctlcontrols.currentPosition += 15;
                    break;
                
                default:
                    break;
            }
        }


    }
}
