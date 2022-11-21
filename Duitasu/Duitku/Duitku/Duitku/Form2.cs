using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Duitku
{
    
    partial class Form2 : Form
    {
        public User Pengguna;
        private string lblrekom6;
        
        public Form2(User pengguna)
        {
            InitializeComponent();
            Pengguna = pengguna;
            string id_user = Pengguna.ID_user;
            string name = Pengguna.userName;
            lblUser.Text = "Hi " + name + "!";
        }
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;username=postgres;Password=balance01;Database=postgres";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        public Form2(string lblrekom6)
        {
            InitializeComponent();
            lblRekom.Text = Form6.lblrekom6;
            this.lblrekom6 = lblrekom6;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5(Pengguna);
            f5.ShowDialog();
        }

        private void llFinance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7(Pengguna);
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
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from TableName", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            lblUser.Text = Convert.ToString(ds.Tables[0].Rows[0][1]);

        }

        private void lblRekom_Click(object sender, EventArgs e)
        {
            
        }

        private void lblSisaUang_Click(object sender, EventArgs e)
        {

        }

        private void lblKeluar_Click(object sender, EventArgs e)
        {
            conn.Open();
            int outcome = 0;
            NpgsqlCommand cmd_outcome = new NpgsqlCommand("Select sum (uang_keluar) as total from tb_outcome where user_id = '" + Pengguna.ID_user + "'", conn);
            NpgsqlDataReader out_reader = cmd_outcome.ExecuteReader();
            while (out_reader.Read())
            {
                try
                {
                    outcome = out_reader.GetInt32(0);
                }
                catch
                {
                    outcome = 0;
                }
            }
            lblKeluar.Text = outcome.ToString();
            conn.Close();
        }

        /*private void btnRefresh_Click(object sender, EventArgs e)
        {
            conn.Open();
            int outcome = 0;
            NpgsqlCommand cmd_outcome = new NpgsqlCommand("Select sum (uang_keluar) as total from tb_outcome where user_id = '" + Pengguna.ID_user + "'", conn);
            NpgsqlDataReader out_reader = cmd_outcome.ExecuteReader();
            while (out_reader.Read())
            {
                try
                {
                    outcome = out_reader.GetInt32(0);
                }
                catch
                {
                    outcome = 0;
                }
            }
            lblKeluar.Text = outcome.ToString();
            conn.Close();

            //int balance = income - outcome;
            //lblKeluar.Text = balance.ToString();
        }*/

        private void Form2_Load(object sender, EventArgs e)
        {
            /*conn = new NpgsqlConnection(connstring)*/
        }
    }
 }

