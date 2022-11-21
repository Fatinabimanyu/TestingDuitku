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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Duitku
{
    partial class Form6 : Form
    {
        public User Pengguna; 
        public Form6(User pengguna)
        {
            InitializeComponent();
            Pengguna = pengguna;
           /* string id_user = Pengguna.ID_user;
            string name = Pengguna.userName;*/
        }
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;username=postgres;Password=widhi191;Database=duitkudb";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;

        private void Form6_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }
        private void llHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2(lblrekom6);
            f2.ShowDialog();
        }

        private void llOutcome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7(Pengguna);
            f7.ShowDialog();
        }

        private void tbUangAwal_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbJangkaWaktu_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTabungan_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDanaMasuk_ValueChanged(object sender, EventArgs e)
        {

        }
        private void lblRekomendasi_Click(object sender, EventArgs e)
        {

        }
        public static string lblrekom6 = "";
        private void btnAddFinance_Click_1(object sender, EventArgs e)
        {
            rekomendasipengeluaran uangRek = new rekomendasipengeluaran();
            int reklagi = uangRek.reccomendation(Convert.ToInt32(tbUangAwal.Text), Convert.ToInt32(tbTabungan.Text), Convert.ToInt32(tbJangkaWaktu.Text));
            string msgrek = "Rp" + Convert.ToString(reklagi) + ",00/hari";
            lblRekomendasi.Text = msgrek;
            lblrekom6 = lblRekomendasi.Text;
            try
            {
                conn.Open();
                sql = @"select * from dt_insert_income(:_uangmasuk::integer,:_jangkawaktu::integer,:_tabungan::integer, :_tanggal::date, :_rekomendasi::character varying)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_uangmasuk", tbUangAwal.Text);
                cmd.Parameters.AddWithValue("_jangkawaktu", tbJangkaWaktu.Text);
                cmd.Parameters.AddWithValue("_tabungan", tbTabungan.Text);
                cmd.Parameters.AddWithValue("_tanggal", dtpDanaMasuk.Text);
                cmd.Parameters.AddWithValue("_rekomendasi", lblRekomendasi.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Uang Anda berhasil dimasukkan", "Well done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Insert FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Form2 f2 = new Form2(lblrekom6);
            f2.ShowDialog();
        }
    }
    }
