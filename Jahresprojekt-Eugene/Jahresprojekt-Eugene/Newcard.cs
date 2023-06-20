using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Jahresprojekt_Eugene
{
    public partial class Newcard : Form
    {
        public Newcard()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            string rarity = cb_rarity.Text;
            string quality = cb_quality.Text;
            string type = cb_type.Text;
            string price = tb_price.Text;
            sqlclass.addNewCard(name, rarity, quality, type, price);
            MessageBox.Show("Karte " + tb_name.Text + " wurde erfolgreich erstellt");
            tb_name.Clear();
            cb_rarity.Text = "";  ///combobox leeren
            cb_quality.Text = "";
            cb_type.Text = "";
            tb_price.Clear();
            
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Mainform Mainform = new Mainform();
            this.Hide();
            Mainform.ShowDialog();
            this.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}