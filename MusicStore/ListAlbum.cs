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
    public partial class ListAlbum : Form
    {
        MusicStoreContext context;
        public ListAlbum()
        {
            InitializeComponent();
            context = new MusicStoreContext();
            cbGenre.DisplayMember = "Name";
            cbGenre.ValueMember = "GenreId";
            cbGenre.DataSource = context.Genres.ToList();
            load();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        // load
        private void load()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = context.Albums.Where(x=>x.Genre.Name.Contains(cbGenre.Text)).ToList();
            dataGridView1.Columns["AlbumId"].Visible = false;
            dataGridView1.Columns["GenreId"].Visible = false;
            dataGridView1.Columns["Artist"].Visible = false;
            dataGridView1.Columns["OrderDetails"].Visible = false;
            dataGridView1.Columns["Carts"].Visible = false;
            dataGridView1.Columns["Genre"].Visible = false;
            int count = dataGridView1.Columns.Count;
            number.Text = $" The number of albums: { dataGridView1.Rows.Count}";

            // Insert new column
            DataGridViewButtonColumn edit = new DataGridViewButtonColumn
            {
                Text = "Edit",
                Name = "Edit",
                UseColumnTextForButtonValue = true,
            };
            dataGridView1.Columns.Insert(count, edit);
            DataGridViewButtonColumn delete = new DataGridViewButtonColumn
            {
                Text = "Delete",
                Name = "Delete",
                UseColumnTextForButtonValue = true,
            };
            dataGridView1.Columns.Insert(count+1, delete);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // tim vi tri Delete
            if(e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            {
                int albumid = (int)dataGridView1.Rows[e.RowIndex].Cells["AlbumId"].Value;
                // check question
                DialogResult dr = MessageBox.Show("Do you want delete?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    try
                    {
                        var carts = context.Carts.Where(x=>x.AlbumId == albumid).ToList();
                        var orderDeta = context.OrderDetails.Where(x=>x.AlbumId == albumid).ToList();
                        context.RemoveRange(carts);
                        context.RemoveRange(orderDeta);
                        Album album = context.Albums.Find(albumid);
                        context.Albums.Remove(album);
                        context.SaveChanges();
                        MessageBox.Show("Delete suscesfull");
                        load();
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            // edit
            if(e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
            {
                int albumid = (int)dataGridView1.Rows[e.RowIndex].Cells["AlbumId"].Value; 
                CRUD crud = new CRUD(albumid);
                DialogResult dr = crud.ShowDialog();
                if(dr == DialogResult.OK)
                {
                    context = new MusicStoreContext();
                    load();
                }
            }
        }

        private void cbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            load();
        }
        // add
        private void btAdd_Click(object sender, EventArgs e)
        {
            CRUD crud = new CRUD(-1);
            DialogResult dr = crud.ShowDialog();
            if(dr == DialogResult.OK)
                load();
            
        }
        // search
        private void btSearch_Click(object sender, EventArgs e)
        {

            dataGridView1.Columns.Clear();
            // search theo title
            dataGridView1.DataSource = context.Albums.Where(x => x.Title.Contains(tbTitle.Text)).ToList();
            dataGridView1.Columns["AlbumId"].Visible = false;
            dataGridView1.Columns["GenreId"].Visible = false;
            dataGridView1.Columns["Artist"].Visible = false;
            dataGridView1.Columns["OrderDetails"].Visible = false;
            dataGridView1.Columns["Carts"].Visible = false;
            dataGridView1.Columns["Genre"].Visible = false;
            int count = dataGridView1.Columns.Count;
            number.Text = $" The number of albums: {dataGridView1.Rows.Count}";

            // Insert new column
            DataGridViewButtonColumn edit = new DataGridViewButtonColumn
            {
                Text = "Edit",
                Name = "Edit",
                UseColumnTextForButtonValue = true,
            };
            dataGridView1.Columns.Insert(count, edit);
            DataGridViewButtonColumn delete = new DataGridViewButtonColumn
            {
                Text = "Delete",
                Name = "Delete",
                UseColumnTextForButtonValue = true,
            };
            dataGridView1.Columns.Insert(count + 1, delete);
        }


    }
}
