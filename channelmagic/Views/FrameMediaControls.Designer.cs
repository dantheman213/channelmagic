namespace ChannelMagic.Views
{
    partial class FrameMediaControls
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
            this.buttonPlayPause = new System.Windows.Forms.Button();
            this.buttonSkipProgram = new System.Windows.Forms.Button();
            this.buttonMute = new System.Windows.Forms.Button();
            this.buttonFullscreenToggle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPlayPause
            // 
            this.buttonPlayPause.Location = new System.Drawing.Point(380, 58);
            this.buttonPlayPause.Name = "buttonPlayPause";
            this.buttonPlayPause.Size = new System.Drawing.Size(79, 42);
            this.buttonPlayPause.TabIndex = 0;
            this.buttonPlayPause.Text = "Play";
            this.buttonPlayPause.UseVisualStyleBackColor = true;
            this.buttonPlayPause.Click += new System.EventHandler(this.buttonPlayPause_Click);
            // 
            // buttonSkipProgram
            // 
            this.buttonSkipProgram.Location = new System.Drawing.Point(465, 58);
            this.buttonSkipProgram.Name = "buttonSkipProgram";
            this.buttonSkipProgram.Size = new System.Drawing.Size(75, 42);
            this.buttonSkipProgram.TabIndex = 2;
            this.buttonSkipProgram.Text = "Skip Program";
            this.buttonSkipProgram.UseVisualStyleBackColor = true;
            this.buttonSkipProgram.Click += new System.EventHandler(this.buttonSkipProgram_Click);
            // 
            // buttonMute
            // 
            this.buttonMute.Location = new System.Drawing.Point(546, 58);
            this.buttonMute.Name = "buttonMute";
            this.buttonMute.Size = new System.Drawing.Size(88, 42);
            this.buttonMute.TabIndex = 3;
            this.buttonMute.Text = "Mute";
            this.buttonMute.UseVisualStyleBackColor = true;
            this.buttonMute.Click += new System.EventHandler(this.buttonMute_Click);
            // 
            // buttonFullscreenToggle
            // 
            this.buttonFullscreenToggle.Location = new System.Drawing.Point(705, 63);
            this.buttonFullscreenToggle.Name = "buttonFullscreenToggle";
            this.buttonFullscreenToggle.Size = new System.Drawing.Size(75, 37);
            this.buttonFullscreenToggle.TabIndex = 4;
            this.buttonFullscreenToggle.Text = "Toggle Fullscreen";
            this.buttonFullscreenToggle.UseVisualStyleBackColor = true;
            this.buttonFullscreenToggle.Click += new System.EventHandler(this.buttonFullscreenToggle_Click);
            // 
            // FrameMediaControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 139);
            this.Controls.Add(this.buttonFullscreenToggle);
            this.Controls.Add(this.buttonMute);
            this.Controls.Add(this.buttonSkipProgram);
            this.Controls.Add(this.buttonPlayPause);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrameMediaControls";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrameMediaControls";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrameMediaControls_Load);
            this.Click += new System.EventHandler(this.FrameMediaControls_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPlayPause;
        private System.Windows.Forms.Button buttonSkipProgram;
        private System.Windows.Forms.Button buttonMute;
        private System.Windows.Forms.Button buttonFullscreenToggle;
    }
}