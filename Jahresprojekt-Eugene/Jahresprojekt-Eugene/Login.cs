using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Jahresprojekt_Eugene
{
    public partial class Login : Form
    {
        public static bool loggedIn = false;
        public Login()
        {
            InitializeComponent();
            sqlclass.createDatabase();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            bool userExist = false;

            string username = tb_username.Text;
            string password = tb_password.Text;
            userExist = sqlclass.CheckUser(username);
            if(userExist.Equals(true)) 
            {
                bool rightPassword = sqlclass.getPassword(username, password);
                if (rightPassword.Equals(true))
                {
                    loggedIn = true;
                    MessageBox.Show("Angemeldet");
                    Mainform Mainform = new Mainform();
                    this.Hide();
                    Mainform.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Falsches Passwort");
                    tb_password.Clear();
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
            this.Show();
        }

    }
}