using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicStore
{
    public partial class CRUD : Form
    {
        MusicStoreContext context;
        int id;
        public CRUD(int albumid)
        {
            InitializeComponent();
            id = albumid;
            context = new MusicStoreContext();
            cbGenreCRUD.DisplayMember = "Name";
            cbGenreCRUD.ValueMember = "GenreId";
            cbGenreCRUD.DataSource = context.Genres.ToList<Genre>();

            cbArtistCRUD.DisplayMember= "Name";
            cbArtistCRUD.ValueMember = "ArtistId";
            cbArtistCRUD.DataSource = context.Artists.ToList<Artist>(); 

            if(albumid != -1)
            {
                Album album = context.Albums.Find(albumid);
                tbTitleCRUD.Text = album.Title;
                tbPriceCRUD.Text = album.Price.ToString();
                cbGenreCRUD.SelectedIndex = album.GenreId - 1;
                cbArtistCRUD.Text = context.Artists.Where(x => x.ArtistId == album.ArtistId).Select(x=>x.Name).FirstOrDefault();
                tbimageCRUD.Text = album.AlbumUrl;

                //try
                //{
                //    pictureBox1.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString()+ tbimageCRUD.Text);
                //    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                //}
                //catch
                //{
                //    pictureBox1.Image = null;
                //}
            }
        }



    }
}
