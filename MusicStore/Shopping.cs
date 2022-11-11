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
    public partial class Shopping : Form
    {
        MusicStoreContext context;
        ShoppingCart cart;
        PageList<Album> pageAlbum;
        

        public Shopping()
        {
            InitializeComponent();
            context = new MusicStoreContext();
            cart = new ShoppingCart();
            cbGenreShopping.DisplayMember = "Name";
            cbGenreShopping.ValueMember = "GenreId";
            cbGenreShopping.DataSource = context.Genres.ToList();
            load(1);
        }
        void load(int pageIndex)
        {
            IQueryable<Album> albums = context.Albums.Where(x=>x.Genre.Name.Contains(cbGenreShopping.Text));
            pageAlbum = PageList<Album>.Create(albums, pageIndex, 3);
            btPrevious.Enabled = pageAlbum.Previous;
            btNext.Enabled = pageAlbum.Next;

            panel1.Controls.Clear();
            int height = panel1.Height - 20;
            int width = (panel1.Width - 20)/3;
            int i = 0;
            foreach(Album album in pageAlbum)
            {
                GroupBox gr = new GroupBox();
                gr.Width = width;
                gr.Text = album.Title;
                gr.Height = height;
                gr.Location = new Point(10 + i * width, 10);
               
                PictureBox pictureBox = new PictureBox();
                pictureBox.BorderStyle = BorderStyle.None;
                string s = Directory.GetCurrentDirectory();
                try
                {
                    pictureBox.Image = Image.FromFile(Directory.GetParent(s).Parent.Parent.FullName + album.AlbumUrl);
                }
                catch
                {
                    pictureBox.Image = null;
                }
                pictureBox.Size = new Size(120, 72);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Location = new Point(60, 30);
                gr.Controls.Add(pictureBox);

                Label lPrice = new Label();
                lPrice.AutoSize = true;
                lPrice.Text = $"${album.Price.ToString()}";
                lPrice.Location = new Point(100, 110);
                gr.Controls.Add(lPrice);

                Label lArtis = new Label();
                lArtis.AutoSize = true;
                lArtis.Text = context.Artists.Where(r => r.ArtistId == album.ArtistId)
                    .Select(r => r.Name).FirstOrDefault();
                lArtis.Location = new Point(90, 130);
                gr.Controls.Add(lArtis);

                Button bAdd = new Button();
                bAdd.Name = $"btn{album.AlbumId}";
                bAdd.Text = "Add to cart";
                bAdd.BackColor = Color.Blue;
                bAdd.ForeColor = Color.White;
                bAdd.AutoSize = true;
                bAdd.Location = new Point(80, 150);
                gr.Controls.Add(bAdd);
                bAdd.Click += Btadd_Click;

                i++;
                panel1.Controls.Add(gr);
            }
        }
        private void Btadd_Click(object? sender,EventArgs e)
        {
            int albumId = Convert.ToInt32(((Button)sender).Name.Substring(3));
            MessageBox.Show("Add to cart thanh cong");
            Album album = context.Albums.Find(albumId);
            ShoppingCart sp = ShoppingCart.GetCart();
            sp.AddToCart(album);
        }
        // load panelSerach
        public void loadPanelSearch(int pageIndex)
        {
            IQueryable<Album> albums = context.Albums.Where(x => x.Title.Contains(tbTitleShopping.Text.Trim()));

            pageAlbum = PageList<Album>.Create(albums, pageIndex, 3);
            btPrevious.Enabled = pageAlbum.Previous;
            btNext.Enabled = pageAlbum.Next;

            panel1.Controls.Clear();
            int height = panel1.Height - 20;
            int width = (panel1.Width - 20) / 3;
            int i = 0;
            foreach (Album album in pageAlbum)
            {
                GroupBox gr = new GroupBox();
                gr.Text = album.Title;
                gr.Height = height;
                gr.Width = width;
                gr.Location = new Point(10 + i * width, 10);

                PictureBox pictureBox = new PictureBox();
                pictureBox.BorderStyle = BorderStyle.None;
                string s = Directory.GetCurrentDirectory();
                try
                {
                    pictureBox.Image = Image
                        .FromFile(Directory.GetParent(s).Parent.Parent.FullName + album.AlbumUrl);
                }
                catch
                {
                    pictureBox.Image = null;
                }
                pictureBox.Size = new Size(120, 72);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Location = new Point(60, 30);
                gr.Controls.Add(pictureBox);

                Label lPrice = new Label();
                lPrice.AutoSize = true;
                lPrice.Text = $"${album.Price.ToString()}";
                lPrice.Location = new Point(100, 110);
                gr.Controls.Add(lPrice);

                Label lArtis = new Label();
                lArtis.AutoSize = true;
                lArtis.Text = context.Artists.Where(r => r.ArtistId == album.ArtistId)
                    .Select(r => r.Name).FirstOrDefault();
                lArtis.Location = new Point(100, 130);
                gr.Controls.Add(lArtis);

                Button btAdd = new Button();
                btAdd.Name = $"btn{album.AlbumId}";
                btAdd.Text = "Add to cart";
                btAdd.BackColor = Color.Blue;
                btAdd.ForeColor = Color.White;
                btAdd.AutoSize = true;
                btAdd.Location = new Point(80, 150);
                gr.Controls.Add(btAdd);
                btAdd.Click += Btadd_Click;
                i++;
                panel1.Controls.Add(gr);
            }
        }

        private void btSearchShopping_Click(object sender, EventArgs e)
        {
            loadPanelSearch(1);
        }

        private void btPrevious_Click(object sender, EventArgs e)
        {
            load(pageAlbum.Index - 1);
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            load(pageAlbum.Index + 1);
        }

        private void cbGenreShopping_SelectedIndexChanged(object sender, EventArgs e)
        {
            load(1);
        }
    }
}
