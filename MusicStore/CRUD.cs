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

        private void btSaveCURD_Click(object sender, EventArgs e)
        {
            // ADD
            if(id == -1)
            {
                // add Album
                //Album album = new Album
                //{
                //    Title = tbTitleCRUD.Text,
                //    Price = decimal.Parse(tbPriceCRUD.Text),
                //    GenreId = context.Genres.Where(x=>x.Name == cbGenreCRUD.Text).Select(x=>x.GenreId).FirstOrDefault(),
                //    ArtistId = context.Artists.Where(x=>x.Name == cbArtistCRUD.Text).Select(x=>x.ArtistId).FirstOrDefault(),
                //    AlbumUrl = tbimageCRUD.Text,

                //};
                try
                {
                    Album album = new Album
                    {
                        Title = tbTitleCRUD.Text,
                        Price = decimal.Parse(tbPriceCRUD.Text),
                        GenreId = context.Genres.Where(x => x.Name == cbGenreCRUD.Text).Select(x => x.GenreId).FirstOrDefault(),
                        ArtistId = context.Artists.Where(x => x.Name == cbArtistCRUD.Text).Select(x => x.ArtistId).FirstOrDefault(),
                        AlbumUrl = tbimageCRUD.Text,

                    };
                    context.Albums.Add(album);
                    context.SaveChanges();
                    MessageBox.Show("Add thanh cong");
                }
                catch
                {
                    MessageBox.Show("Add failled");
                }
            }
            // edit 
            else
            {
                try
                {
                    // tim id 
                    Album album = context.Albums.Find(id);
                    album.Title = tbTitleCRUD.Text;
                    album.Price = decimal.Parse(tbPriceCRUD.Text);
                    album.GenreId = context.Genres.Where(x => x.Name == cbGenreCRUD.Text).Select(x => x.GenreId).FirstOrDefault();
                    album.ArtistId = context.Artists.Where(x=>x.Name == cbArtistCRUD.Text).Select(x=>x.ArtistId).FirstOrDefault();
                    album.AlbumUrl = tbimageCRUD.Text;
                    context.Albums.Update(album);
                    context.SaveChanges();
                    MessageBox.Show("Edit thanh cong");
                }
                catch
                {
                    MessageBox.Show("Edit failled");
                }
            }
        }

        private void btCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
