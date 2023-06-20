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
    public partial class Packshop : Form
    {
        public Packshop()
        {
            InitializeComponent();
        }

        private void btn_bronze_Click(object sender, EventArgs e)
        {
            string name = tb_username.Text;
            sqlclass.BronzePack(name);
        }

        private void btn_iron_Click(object sender, EventArgs e)
        {
            string name = tb_username.Text;
            sqlclass.IronPack(name);
        }

        private void btn_plat_Click(object sender, EventArgs e)
        {
            string name = tb_username.Text;
            sqlclass.PlatinPack(name);
        }

        private void btn_dia_Click(object sender, EventArgs e)
        {
            string name = tb_username.Text;
            sqlclass.DiamandPack(name);
        }
    }
}
