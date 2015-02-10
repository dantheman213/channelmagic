namespace ChannelMagic.Views
{
    partial class FrameTvGuide
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
            this.timerCheckFocus = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.browserGuide = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // timerCheckFocus
            // 
            this.timerCheckFocus.Enabled = true;
            this.timerCheckFocus.Interval = 1000;
            this.timerCheckFocus.Tick += new System.EventHandler(this.timerCheckFocus_Tick);
            // 
            // browserGuide
            // 
            this.browserGuide.Location = new System.Drawing.Point(229, 133);
            this.browserGuide.MinimumSize = new System.Drawing.Size(20, 20);
            this.browserGuide.Name = "browserGuide";
            this.browserGuide.Size = new System.Drawing.Size(668, 457);
            this.browserGuide.TabIndex = 0;
            // 
            // FrameTvGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 725);
            this.Controls.Add(this.browserGuide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrameTvGuide";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrameTvGuide";
            this.Load += new System.EventHandler(this.FrameTvGuide_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrameTvGuide_KeyPress);
            this.Leave += new System.EventHandler(this.FrameTvGuide_Leave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerCheckFocus;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.WebBrowser browserGuide;
    }
}