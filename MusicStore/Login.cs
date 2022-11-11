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
    public partial class Login : Form
    {
        MusicStoreContext context;
        public Login()
        {
            InitializeComponent();
            tbPasswordLogin.PasswordChar = '*';

        }

        private void btLoginLogin_Click(object sender, EventArgs e)
        {
            bool isUser = false;
            string username = tbUsernameLogin.Text;
            string pass = tbPasswordLogin.Text;
            context = new MusicStoreContext();
            // neu user , pass != empty
            if(username != string.Empty && pass != string.Empty)
            {
                // neu admin role =1 , user role = 0
                IQueryable<User> admin = context.Users.Where(x => x.Role == 1);
                IQueryable<User> users = context.Users.Where(x => x.Role == 0);
                foreach(User item in admin)
                {
                    if(username.Equals(item.UserName) && pass.Equals(item.Password))
                    {
                        Check.UserName = item.UserName;
                        Check.Role = item.Role;
                        this.Close();
                        isUser = true;
                    }
                }
                foreach (User item in users)
                {
                    if (username.Equals(item.UserName) && pass.Equals(item.Password))
                    {
                        Check.UserName = item.UserName;
                        Check.Role = item.Role;
                        this.Close();
                        isUser = true;
                    }
                }
                if(isUser == false)
                {
                    MessageBox.Show("Not exist");
                }

            }
            else
            {
                MessageBox.Show("Dien day tu thong tin");
            }
        }

        private void btCancelLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
