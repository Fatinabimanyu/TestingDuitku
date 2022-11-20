using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duitku
{
    partial class Form2 : Form
    {

        public User Pengguna;
        public Form2(User pengguna)
        {

            InitializeComponent();
            Pengguna = pengguna;
            string id_user = Pengguna.ID_user;
            string name = Pengguna.userName;
            lblUser.Text = "Hi " + name + "!";
        }
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;username=postgres;Password=balance01;Database=duitkudb";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void llFinance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void llCalendar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6(Pengguna);
            f6.ShowDialog();
        }

        private void lblProfilH_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
        private string uname;
        private void label1_Click(object sender, EventArgs e)
        {
            
                /*InitializeComponent();
                Pengguna = pengguna;
                string id_user = Pengguna.ID_user;
                string name = Pengguna.Name;
                lblUser.Text = "Hi " + name + "!";*/
            
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
