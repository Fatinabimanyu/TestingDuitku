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
    partial class Form7 : Form
    {
        public User Pengguna;
        public Form7(User pengguna)
        {
            InitializeComponent();
            Pengguna = pengguna;

        }
        public Form7()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;username=postgres;Password=widhi191;Database=duitkudb";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void Form7_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void dtpDanaKeluar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddOut_Click(object sender, EventArgs e)
        {

        }

        private void llIncome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6(Pengguna);
            f6.ShowDialog();
        }

        private void llHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2(Pengguna);
            f2.ShowDialog();
        }

        private void llHome_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2(Pengguna);
            f2.ShowDialog();
        }

        private void llIncome_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6(Pengguna);
            f6.ShowDialog();
        }

        private void llOutcome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void tbPengeluaran_TextChanged(object sender, EventArgs e)
        {
            pengeluaran keluar = new pengeluaran();
            keluar.duitKeluar = Convert.ToInt32(tbUangKeluar.Text);
        }

        private void btnAddOutcome_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from dt_insert_outcome(:_uangkeluar::integer,:_loguang::date)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_uangkeluar", tbUangKeluar.Text);
                cmd.Parameters.AddWithValue("_loguang", dtpDanaKeluar.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Pengeluaran berhasil ditambahkan", "Well done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Insert FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                conn.Open();
                dgvRiwayat.DataSource = null;
                sql = "select * from dt_select_outcome()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvRiwayat.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Insert FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

 }
    

