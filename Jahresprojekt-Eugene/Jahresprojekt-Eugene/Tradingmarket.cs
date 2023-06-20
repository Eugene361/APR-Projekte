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
    public partial class Tradingmarket : Form
    {
        public Tradingmarket()
        {
            InitializeComponent();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tb_username.Text;
                DataTable dt = new DataTable();
                dgv_inv.DataSource = dt;
                sqlclass.showInv(dt, name);
            }
            catch (Exception ex) { ex.ToString(); }
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text;
            string name = tb_username.Text;
            //sqlclass.checkMoney(name, id);
            sqlclass.sellCard(name, id);
            MessageBox.Show("Karte " + id + " wurde erfolgreich von verkauft!");
        }
    }
}
