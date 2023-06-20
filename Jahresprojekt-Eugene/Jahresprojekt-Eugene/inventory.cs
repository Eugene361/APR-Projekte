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
    public partial class inventory : Form
    {
        public inventory()
        {
            InitializeComponent();
        }

        private void tb_show_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tb_Name.Text;
                DataTable dt = new DataTable();
                dgv_inv.DataSource = dt;
                sqlclass.showInv(dt, name);
            }catch(Exception ex) { ex.ToString(); }
        }
    }
}
