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
    public partial class Cart : Form
    {
        MusicStoreContext context;
        ShoppingCart cart;
        public Cart()
        {
            InitializeComponent();
            context = new MusicStoreContext();
            load();
        }

        public void load()
        {
            cart = ShoppingCart.GetCart();
            textBox1.Text = cart.GetTotal().ToString();

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = cart.GetCartsItems().ToList();
            dataGridView1.Columns["CartId"].Visible = false;
            dataGridView1.Columns["RecordId"].Visible = false;
            dataGridView1.Columns["Album"].Visible = false;
            

            if(dataGridView1.Rows.Count > 0 && Check.UserName != null)
            {
                button1.Enabled = true;
            }else if(dataGridView1.Rows.Count == 0)
            {
                button1.Enabled=false;
            }
            int count = dataGridView1.Columns.Count;
            DataGridViewButtonColumn btAdd = new DataGridViewButtonColumn
            {
                Text = "+",
                Name = "Add",
                UseColumnTextForButtonValue = true,
            };
            dataGridView1.Columns.Insert(0, btAdd);

            
            DataGridViewButtonColumn btRemove = new DataGridViewButtonColumn
            {
                Text = "-",
                Name = "Remove",
                UseColumnTextForButtonValue = true,
            };
            dataGridView1.Columns.Insert(count + 1, btRemove);
        }
        // check out
        private void button1_Click(object sender, EventArgs e)
        {
            Checkout c = new Checkout();
            DialogResult dr = c.ShowDialog();
            if(dr == DialogResult.OK)
            {
                cart.CartEmpty();
                load();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataGridView1.Columns["Add"].Index)
            {
                int albumId = (int)dataGridView1.Rows[e.RowIndex].Cells["AlbumId"].Value;
                Album a = context.Albums.Find(albumId);
                cart.AddToCart(a);
                load();
            }
            else if(e.ColumnIndex == dataGridView1.Columns["Remove"].Index)
            {
                int recordId = (int)dataGridView1.Rows[e.RowIndex].Cells["RecordId"].Value;
                cart.RemoveCart(recordId);
                load();
            }
        }
    }
}
