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
    public partial class Checkout : Form
    {
        MusicStoreContext context;

        ShoppingCart cart;
        public Checkout()
        {
            InitializeComponent();
            context = new MusicStoreContext();
            cart = ShoppingCart.GetCart();
            int id = context.Users.Where(x => x.UserName == Check.UserName.ToString()).Select(x => x.Id).FirstOrDefault();
            User u = context.Users.Find(id);
            tbfirstname.Text = u.FirstName;
            tblastname.Text = u.LastName;
            tbemail.Text = u.Email;
            tbaddress.Text = u.Address;
            tbcity.Text = u.City;
            tbcountry.Text = u.Country;
            tbstate.Text = u.State;
            tbphone.Text = u.Phone;
            tbtotal.Text = cart.GetTotal().ToString();
        }

        //public Checkout(int id, MusicStoreContext con)
        //{
        //    InitializeComponent();
        //    tbfirstname.Text = tbfirstname.ToString();
        //    tblastname.Text = tblastname.ToString();
        //    tbemail.Text = tbemail.ToString();
        //    this.context = con;
        //    if(id != -1)
        //    {
        //        Order o = con.Orders.Find(tbtotal);
        //        User u = con.Users.Find(id);
        //        tbfirstname.Text = u.FirstName;
        //        tblastname.Text = u.LastName;
        //        tbemail.Text = u.Email;
        //        tbaddress.Text = u.Address;
        //        tbcity.Text = u.City;
        //        tbcountry.Text = u.Country;
        //        tbstate.Text = u.State;
        //        tbtotal.Text = tbtotal.ToString();
        //    }
        //}
        // save 
        private void btSaveCheckout_Click(object sender, EventArgs e)
        {
            cart = ShoppingCart.GetCart();
            Order o = new Order();
            o.FirstName = tbfirstname.Text;
            o.LastName = tblastname.Text;
            o.Address = tbaddress.Text;
            o.City = tbcity.Text;
            o.State = tbstate.Text;
            o.Country = tbcountry.Text;
            o.Phone = tbphone.Text;
            o.Email = tbemail.Text;
            o.Total = Convert.ToDecimal(tbtotal.Text);
            cart.CreateOrder(o);
            MessageBox.Show("Save thanh cong");
            this.Close();
        }

        private void btCancelCheckout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
