﻿using System;
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

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShoppingCart cart = new ShoppingCart();
            logoutToolStripMenuItem.Visible = false;
            loginToolStripMenuItem.Visible = true;
            albumsToolStripMenuItem.Visible = false;
            cart = ShoppingCart.GetCart();
            Check.UserName = null;
            Check.CartId = null;
            cartToolStripMenuItem.Text = "Cart (0)";
        }

        private void shoppingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shopping shopping = new Shopping();
            shopping.TopLevel = false;
            shopping.FormBorderStyle = FormBorderStyle.None;
            shopping.Show();

            toolStripContainer1.ContentPanel.Controls.Clear();
            toolStripContainer1.ContentPanel.Controls.Add(shopping);
        }

        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
        }

        private void Home_Activated(object sender, EventArgs e)
        {
            // neu login dung
            if (Check.UserName != null && Check.UserName != " ")
            {
                logoutToolStripMenuItem.Text = $"Logout({Check.UserName})";
            }
            else
            {
                loginToolStripMenuItem.Text = $"Login";
            }
            // tai khoan admin
            if (Check.Role == 1 && Check.UserName != null && Check.UserName != " ")
            {
                albumsToolStripMenuItem.Visible = true;
                logoutToolStripMenuItem.Visible = true;
                loginToolStripMenuItem.Visible = false;
            }
            // tai khoan user
            else if (Check.Role == 0 && Check.UserName != null && Check.UserName != " ")
            {
                albumsToolStripMenuItem.Visible = false;
                loginToolStripMenuItem.Visible = false;
                logoutToolStripMenuItem.Visible = true;
            }
            ShoppingCart cart = ShoppingCart.GetCart();
            int count = cart.GetCount();
            cartToolStripMenuItem.Text = $"Cart ({count})";
        }
    }
}
