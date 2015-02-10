﻿namespace ChannelMagic.Views
{
    partial class FrameMediaLibrary
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
            this.tabControls = new System.Windows.Forms.TabControl();
            this.tabPageTvShows = new System.Windows.Forms.TabPage();
            this.buttonAddTvShows = new System.Windows.Forms.Button();
            this.listTvShows = new System.Windows.Forms.ListView();
            this.columnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBitRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFrameSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDateAdded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dialogDirectoryBrowse = new System.Windows.Forms.FolderBrowserDialog();
            this.columnSeason = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEpisode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControls.SuspendLayout();
            this.tabPageTvShows.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControls
            // 
            this.tabControls.Controls.Add(this.tabPageTvShows);
            this.tabControls.Controls.Add(this.tabPage2);
            this.tabControls.Location = new System.Drawing.Point(12, 38);
            this.tabControls.Name = "tabControls";
            this.tabControls.SelectedIndex = 0;
            this.tabControls.Size = new System.Drawing.Size(1100, 568);
            this.tabControls.TabIndex = 0;
            // 
            // tabPageTvShows
            // 
            this.tabPageTvShows.Controls.Add(this.buttonAddTvShows);
            this.tabPageTvShows.Controls.Add(this.listTvShows);
            this.tabPageTvShows.Location = new System.Drawing.Point(4, 22);
            this.tabPageTvShows.Name = "tabPageTvShows";
            this.tabPageTvShows.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTvShows.Size = new System.Drawing.Size(1092, 542);
            this.tabPageTvShows.TabIndex = 0;
            this.tabPageTvShows.Text = "TV Shows";
            this.tabPageTvShows.UseVisualStyleBackColor = true;
            // 
            // buttonAddTvShows
            // 
            this.buttonAddTvShows.Location = new System.Drawing.Point(1009, 507);
            this.buttonAddTvShows.Name = "buttonAddTvShows";
            this.buttonAddTvShows.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTvShows.TabIndex = 1;
            this.buttonAddTvShows.Text = "Add Shows";
            this.buttonAddTvShows.UseVisualStyleBackColor = true;
            this.buttonAddTvShows.Click += new System.EventHandler(this.buttonAddTvShows_Click);
            // 
            // listTvShows
            // 
            this.listTvShows.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTitle,
            this.columnRating,
            this.columnBitRate,
            this.columnDuration,
            this.columnSeason,
            this.columnEpisode,
            this.columnFrameSize,
            this.columnDateAdded,
            this.columnFilePath});
            this.listTvShows.Location = new System.Drawing.Point(6, 6);
            this.listTvShows.Name = "listTvShows";
            this.listTvShows.Size = new System.Drawing.Size(1078, 495);
            this.listTvShows.TabIndex = 0;
            this.listTvShows.UseCompatibleStateImageBehavior = false;
            this.listTvShows.View = System.Windows.Forms.View.Details;
            this.listTvShows.SelectedIndexChanged += new System.EventHandler(this.listTvShows_SelectedIndexChanged);
            // 
            // columnTitle
            // 
            this.columnTitle.Text = "Title";
            this.columnTitle.Width = 237;
            // 
            // columnRating
            // 
            this.columnRating.Text = "Rating";
            // 
            // columnBitRate
            // 
            this.columnBitRate.Text = "BitRate";
            // 
            // columnDuration
            // 
            this.columnDuration.Text = "Duration";
            this.columnDuration.Width = 71;
            // 
            // columnFrameSize
            // 
            this.columnFrameSize.Text = "Frame Size";
            this.columnFrameSize.Width = 72;
            // 
            // columnDateAdded
            // 
            this.columnDateAdded.Text = "Date Added";
            this.columnDateAdded.Width = 121;
            // 
            // columnFilePath
            // 
            this.columnFilePath.Text = "File Path";
            this.columnFilePath.Width = 503;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1092, 542);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(1012, 621);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 38);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // columnSeason
            // 
            this.columnSeason.Text = "Season";
            // 
            // columnEpisode
            // 
            this.columnEpisode.Text = "Episode";
            // 
            // FrameMediaLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 672);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tabControls);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrameMediaLibrary";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Media Library";
            this.Load += new System.EventHandler(this.FrameMediaLibrary_Load);
            this.tabControls.ResumeLayout(false);
            this.tabPageTvShows.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControls;
        private System.Windows.Forms.TabPage tabPageTvShows;
        private System.Windows.Forms.Button buttonAddTvShows;
        private System.Windows.Forms.ListView listTvShows;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.FolderBrowserDialog dialogDirectoryBrowse;
        private System.Windows.Forms.ColumnHeader columnTitle;
        private System.Windows.Forms.ColumnHeader columnRating;
        private System.Windows.Forms.ColumnHeader columnBitRate;
        private System.Windows.Forms.ColumnHeader columnDuration;
        private System.Windows.Forms.ColumnHeader columnFrameSize;
        private System.Windows.Forms.ColumnHeader columnDateAdded;
        private System.Windows.Forms.ColumnHeader columnFilePath;
        private System.Windows.Forms.ColumnHeader columnSeason;
        private System.Windows.Forms.ColumnHeader columnEpisode;
    }
}