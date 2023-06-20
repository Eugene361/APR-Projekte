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
    public partial class Cardshop : Form
    {
        public Cardshop()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            sqlclass.showAll(dt);
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text;
            string name = tb_username.Text;
            sqlclass.checkMoney(name, id);
            //sqlclass.buyCard(name, id);
            MessageBox.Show("Karte " + id + " wurde erfolgreich von " + name + " gekauft!");
        }
    }
}
