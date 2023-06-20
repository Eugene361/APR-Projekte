using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jahresprojekt_Eugene
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;
            string conPassword = tb_conpassword.Text;

            if(password == conPassword)
            {
                sqlclass.AddUser(username, password);
                MessageBox.Show(username + " wurde erstellt");
            }
            else
            {
                MessageBox.Show("Passwort und Passwort bestätigen müssen gleich sein");
            }
            
            tb_username.Clear();
            tb_password.Clear();
            tb_conpassword.Clear();
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Show();
        }
    }
}
