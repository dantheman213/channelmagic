namespace ChannelMagic.Views
{
    partial class FrameMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrameMain));
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stretchToFitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skipCurrentProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTVGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.channelUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channelDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.playPauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerPlayNextMediaItem = new System.Windows.Forms.Timer(this.components);
            this.timerMediaDoubleClick = new System.Windows.Forms.Timer(this.components);
            this.timerCheckFocus = new System.Windows.Forms.Timer(this.components);
            this.timerHideControlMenu = new System.Windows.Forms.Timer(this.components);
            this.labelMediaTitle = new System.Windows.Forms.Label();
            this.labelMediaSubtitle = new System.Windows.Forms.Label();
            this.labelChannelName = new System.Windows.Forms.Label();
            this.labelChannelNumber = new System.Windows.Forms.Label();
            this.timerOverlay = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(0, 24);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(1094, 708);
            this.mediaPlayer.TabIndex = 0;
            this.mediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.mediaPlayer_PlayStateChange);
            this.mediaPlayer.ClickEvent += new AxWMPLib._WMPOCXEvents_ClickEventHandler(this.mediaPlayer_ClickEvent);
            this.mediaPlayer.MouseMoveEvent += new AxWMPLib._WMPOCXEvents_MouseMoveEventHandler(this.mediaPlayer_MouseMoveEvent);
            this.mediaPlayer.Enter += new System.EventHandler(this.mediaPlayer_Enter);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.playbackToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1094, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullScreenToolStripMenuItem,
            this.stretchToFitToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            this.fullScreenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.fullScreenToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.fullScreenToolStripMenuItem.Text = "Full screen";
            this.fullScreenToolStripMenuItem.Click += new System.EventHandler(this.fullScreenToolStripMenuItem_Click);
            // 
            // stretchToFitToolStripMenuItem
            // 
            this.stretchToFitToolStripMenuItem.Name = "stretchToFitToolStripMenuItem";
            this.stretchToFitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.stretchToFitToolStripMenuItem.Text = "Stretch to fit";
            this.stretchToFitToolStripMenuItem.Click += new System.EventHandler(this.stretchToFitToolStripMenuItem_Click);
            // 
            // playbackToolStripMenuItem
            // 
            this.playbackToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skipCurrentProgramToolStripMenuItem,
            this.showTVGuideToolStripMenuItem,
            this.toolStripSeparator1,
            this.channelUpToolStripMenuItem,
            this.channelDownToolStripMenuItem,
            this.toolStripSeparator2,
            this.playPauseToolStripMenuItem});
            this.playbackToolStripMenuItem.Name = "playbackToolStripMenuItem";
            this.playbackToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.playbackToolStripMenuItem.Text = "&Playback";
            // 
            // skipCurrentProgramToolStripMenuItem
            // 
            this.skipCurrentProgramToolStripMenuItem.Name = "skipCurrentProgramToolStripMenuItem";
            this.skipCurrentProgramToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.skipCurrentProgramToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.skipCurrentProgramToolStripMenuItem.Text = "Skip Current Program";
            this.skipCurrentProgramToolStripMenuItem.Click += new System.EventHandler(this.skipCurrentProgramToolStripMenuItem_Click);
            // 
            // showTVGuideToolStripMenuItem
            // 
            this.showTVGuideToolStripMenuItem.Name = "showTVGuideToolStripMenuItem";
            this.showTVGuideToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.showTVGuideToolStripMenuItem.Text = "Show TV Guide";
            this.showTVGuideToolStripMenuItem.Click += new System.EventHandler(this.showTVGuideToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // channelUpToolStripMenuItem
            // 
            this.channelUpToolStripMenuItem.Name = "channelUpToolStripMenuItem";
            this.channelUpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.channelUpToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.channelUpToolStripMenuItem.Text = "Channel Up";
            this.channelUpToolStripMenuItem.Click += new System.EventHandler(this.channelUpToolStripMenuItem_Click);
            // 
            // channelDownToolStripMenuItem
            // 
            this.channelDownToolStripMenuItem.Name = "channelDownToolStripMenuItem";
            this.channelDownToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.channelDownToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.channelDownToolStripMenuItem.Text = "Channel Down";
            this.channelDownToolStripMenuItem.Click += new System.EventHandler(this.channelDownToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(185, 6);
            // 
            // playPauseToolStripMenuItem
            // 
            this.playPauseToolStripMenuItem.Name = "playPauseToolStripMenuItem";
            this.playPauseToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.playPauseToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.playPauseToolStripMenuItem.Text = "Play/Pause";
            this.playPauseToolStripMenuItem.Click += new System.EventHandler(this.playPauseToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.channelsToolStripMenuItem,
            this.libraryToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // channelsToolStripMenuItem
            // 
            this.channelsToolStripMenuItem.Name = "channelsToolStripMenuItem";
            this.channelsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.channelsToolStripMenuItem.Text = "Channels";
            this.channelsToolStripMenuItem.Click += new System.EventHandler(this.channelsToolStripMenuItem_Click);
            // 
            // libraryToolStripMenuItem
            // 
            this.libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            this.libraryToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.libraryToolStripMenuItem.Text = "Library";
            this.libraryToolStripMenuItem.Click += new System.EventHandler(this.libraryToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // timerPlayNextMediaItem
            // 
            this.timerPlayNextMediaItem.Interval = 350;
            this.timerPlayNextMediaItem.Tick += new System.EventHandler(this.timerPlayNextMediaItem_Tick);
            // 
            // timerMediaDoubleClick
            // 
            this.timerMediaDoubleClick.Interval = 2000;
            this.timerMediaDoubleClick.Tick += new System.EventHandler(this.timerMediaDoubleClick_Tick);
            // 
            // timerCheckFocus
            // 
            this.timerCheckFocus.Interval = 500;
            this.timerCheckFocus.Tick += new System.EventHandler(this.timerCheckFocus_Tick);
            // 
            // timerHideControlMenu
            // 
            this.timerHideControlMenu.Interval = 350;
            this.timerHideControlMenu.Tick += new System.EventHandler(this.timerHideControlMenu_Tick);
            // 
            // labelMediaTitle
            // 
            this.labelMediaTitle.AutoSize = true;
            this.labelMediaTitle.BackColor = System.Drawing.Color.Black;
            this.labelMediaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMediaTitle.ForeColor = System.Drawing.Color.White;
            this.labelMediaTitle.Location = new System.Drawing.Point(12, 41);
            this.labelMediaTitle.Name = "labelMediaTitle";
            this.labelMediaTitle.Size = new System.Drawing.Size(130, 25);
            this.labelMediaTitle.TabIndex = 2;
            this.labelMediaTitle.Text = "[Media Title]";
            this.labelMediaTitle.Visible = false;
            // 
            // labelMediaSubtitle
            // 
            this.labelMediaSubtitle.AutoSize = true;
            this.labelMediaSubtitle.BackColor = System.Drawing.Color.Black;
            this.labelMediaSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMediaSubtitle.ForeColor = System.Drawing.Color.White;
            this.labelMediaSubtitle.Location = new System.Drawing.Point(13, 75);
            this.labelMediaSubtitle.Name = "labelMediaSubtitle";
            this.labelMediaSubtitle.Size = new System.Drawing.Size(118, 20);
            this.labelMediaSubtitle.TabIndex = 3;
            this.labelMediaSubtitle.Text = "[Media Subtitle]";
            this.labelMediaSubtitle.Visible = false;
            // 
            // labelChannelName
            // 
            this.labelChannelName.AutoSize = true;
            this.labelChannelName.BackColor = System.Drawing.Color.Black;
            this.labelChannelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChannelName.ForeColor = System.Drawing.Color.White;
            this.labelChannelName.Location = new System.Drawing.Point(928, 41);
            this.labelChannelName.Name = "labelChannelName";
            this.labelChannelName.Size = new System.Drawing.Size(166, 25);
            this.labelChannelName.TabIndex = 4;
            this.labelChannelName.Text = "[Channel Name]";
            this.labelChannelName.Visible = false;
            // 
            // labelChannelNumber
            // 
            this.labelChannelNumber.AutoSize = true;
            this.labelChannelNumber.BackColor = System.Drawing.Color.Black;
            this.labelChannelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChannelNumber.ForeColor = System.Drawing.Color.White;
            this.labelChannelNumber.Location = new System.Drawing.Point(946, 75);
            this.labelChannelNumber.Name = "labelChannelNumber";
            this.labelChannelNumber.Size = new System.Drawing.Size(136, 20);
            this.labelChannelNumber.TabIndex = 5;
            this.labelChannelNumber.Text = "[Channel Number]";
            this.labelChannelNumber.Visible = false;
            // 
            // timerOverlay
            // 
            this.timerOverlay.Interval = 5000;
            this.timerOverlay.Tick += new System.EventHandler(this.timerOverlay_Tick);
            // 
            // FrameMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1094, 732);
            this.Controls.Add(this.labelChannelNumber);
            this.Controls.Add(this.labelChannelName);
            this.Controls.Add(this.labelMediaSubtitle);
            this.Controls.Add(this.labelMediaTitle);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "FrameMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Channel Magic";
            this.Load += new System.EventHandler(this.FrameMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrameMain_KeyDown);
            this.Resize += new System.EventHandler(this.FrameMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Timer timerPlayNextMediaItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stretchToFitToolStripMenuItem;
        private System.Windows.Forms.Timer timerMediaDoubleClick;
        private System.Windows.Forms.ToolStripMenuItem playbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skipCurrentProgramToolStripMenuItem;
        private System.Windows.Forms.Timer timerCheckFocus;
        private System.Windows.Forms.Timer timerHideControlMenu;
        private System.Windows.Forms.ToolStripMenuItem channelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTVGuideToolStripMenuItem;
        private System.Windows.Forms.Label labelMediaTitle;
        private System.Windows.Forms.Label labelMediaSubtitle;
        private System.Windows.Forms.Label labelChannelName;
        private System.Windows.Forms.Label labelChannelNumber;
        private System.Windows.Forms.Timer timerOverlay;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem channelUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem channelDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem playPauseToolStripMenuItem;
    }
}