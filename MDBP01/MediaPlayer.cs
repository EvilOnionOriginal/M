using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDBP01
{
    public partial class MediaPlayer : Form
    {
        public MediaPlayer()
        {
            InitializeComponent();
        }

        private void menuStrip1_Enter(object sender, EventArgs e)
        {

        }

        private void openExistingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            View view = new View();
            view.Show();
        }

        private void filterSortFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit edit = new Edit();
            edit.Show();
        }

        private void openHelpWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Help help = new Help();
            help.Show();
        }

        private void createNewPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewPlaylist newplaylist = new NewPlaylist();
            newplaylist.Show();
        }
    }
}
