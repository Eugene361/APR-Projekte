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
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void btn_shop_Click(object sender, EventArgs e)
        {
            Packshop Packshop = new Packshop();
            this.Hide();
            Packshop.ShowDialog();
            this.Show();
        }

        private void btn_trading_Click(object sender, EventArgs e)
        {
            Tradingmarket Tradingmarket = new Tradingmarket();
            this.Hide();
            Tradingmarket.ShowDialog();
            this.Show();
        }

        private void btn_invetory_Click(object sender, EventArgs e)
        {
            inventory inventory = new inventory();
            this.Hide();
            inventory.ShowDialog();
            this.Show();
        }

        private void btn_allcards_Click(object sender, EventArgs e)
        {
            allcards allcards = new allcards();
            this.Hide();
            allcards.ShowDialog();
            this.Show();
        }

        private void btn_newcard_Click(object sender, EventArgs e)
        {
            Newcard Newcard = new Newcard();
            this.Hide();
            Newcard.ShowDialog();
            this.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_cardshop_Click(object sender, EventArgs e)
        {
            Cardshop Cardshop = new Cardshop();
            this.Hide();
            Cardshop.ShowDialog();
            this.Show();
        }
    }
}
