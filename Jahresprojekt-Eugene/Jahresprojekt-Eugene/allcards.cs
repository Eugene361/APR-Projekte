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

namespace Jahresprojekt_Eugene
{
    public partial class allcards : Form
    {
        public allcards()
        {
            InitializeComponent();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = "server= (localdb)\\MSSQLLocalDB; Integrated Security = true;";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                conn.ChangeDatabase("cardbase");
                SqlCommand cmd = new SqlCommand("SELECT * FROM cardtbl WHERE Name = '" + tb_input.Text + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                tb_input.Clear();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_showall_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = "server= (localdb)\\MSSQLLocalDB; Integrated Security = true;";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                conn.ChangeDatabase("cardbase");
                SqlCommand cmd = new SqlCommand("SELECT * FROM cardtbl", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                tb_input.Clear();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string connString = "server= (localdb)\\MSSQLLocalDB; Integrated Security = true;";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            conn.ChangeDatabase("cardbase");
            SqlCommand cmd = new SqlCommand("DELETE FROM cardtbl WHERE Name = '" + tb_input.Text + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show(tb_input.Text + " wurde gelöscht");
            tb_input.Clear();
            btn_showall_Click(sender, e);
        }
    }
}
