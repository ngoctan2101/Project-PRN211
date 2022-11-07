using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicStore.Models;

namespace MusicStore
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void albumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListAlbum listAlbum = new ListAlbum();
            listAlbum.TopLevel = false;
            listAlbum.FormBorderStyle = FormBorderStyle.None;
            listAlbum.Show();

            toolStripContainer1.ContentPanel.Controls.Clear();
            toolStripContainer1.ContentPanel.Controls.Add(listAlbum);
            

        }
    }
}
