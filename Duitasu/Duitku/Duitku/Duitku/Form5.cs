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
    partial class Form5 : Form
    {
        public User Pengguna;
        public Form5(User pengguna)
        {
            InitializeComponent();
            Pengguna = pengguna;
            string id_user = Pengguna.ID_user;
            string name = Pengguna.userName;
        }

        private void guna2vTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2(Pengguna);
            f2.ShowDialog();
        }

        private void btnNotLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2(Pengguna);
            f2.ShowDialog();
        }

        private void btnYesLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}
