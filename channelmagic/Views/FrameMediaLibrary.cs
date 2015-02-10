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
    public partial class FrameMediaLibrary : Form
    {
        public FrameMediaLibrary() {
            InitializeComponent();
        }

        private void refreshTvShowListView() {
            listTvShows.Items.Clear();

            foreach (var item in ChannelManager.mediaTvShowItems) {

                string[] row = { 
                                   item.Title, 
                                   item.Rating.ToString(), 
                                   item.BitRate, 
                                   String.Format("{0}:{1}:{2}", item.Duration.Hours.ToString(), item.Duration.Minutes.ToString(), item.Duration.Seconds.ToString()), 
                                   item.Season.ToString(),
                                   item.Episode.ToString(),
                                   item.FrameSize, 
                                   item.DateAdded.ToString("yyyy-MM-dd hh:mm:ss tt"), 
                                   item.FilePath 
                               };

                ListViewItem listItem = new ListViewItem(row);
                listTvShows.Items.Add(listItem);
            }
        }

        private void buttonAddTvShows_Click(object sender, EventArgs e) {
            //dialogDirectoryBrowse.RootFolder = Environment.SpecialFolder.MyComputer;

            // TBD remove
            dialogDirectoryBrowse.SelectedPath = "C:\\Users\\Dan\\Videos";

            if (dialogDirectoryBrowse.ShowDialog() == DialogResult.OK) {

                MediaTracker.addTvShowMedia(dialogDirectoryBrowse.SelectedPath);
                MessageBox.Show("Complete!", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshTvShowListView();
            }
        }

        private void FrameMediaLibrary_Load(object sender, EventArgs e) {
            listTvShows.FullRowSelect = true;
            refreshTvShowListView();
        }

        private void listTvShows_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
