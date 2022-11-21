using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Npgsql;

namespace Duitku
{
    public partial class formLogin : Form
    {
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;username=postgres;Password=widhi191;Database=duitkudb";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        public formLogin()
        {
            InitializeComponent();

        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void tbUname_TextChanged(object sender, EventArgs e)
        {
            //User emil = new User();
            //emil.Email = tbEmail.Text;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from u_login(:_useremail, :_userpassword)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_useremail", tbEmail.Text);
                cmd.Parameters.AddWithValue("_userpassword", tbPassword.Text);

                int result = (int)cmd.ExecuteScalar();
                if (result == 1) //login success
                {
                    MessageBox.Show("Login Success, Welcome to Duitku!");
                    /*this.Hide();*/
                    //conn.Open();
                    string id_user = "CTDEFAULT";
                    NpgsqlCommand cmd_id = new NpgsqlCommand("Select id from pengguna where user_email = '" + tbEmail.Text + "' and user_password = '" + tbPassword.Text + "'", conn);
                    NpgsqlDataReader id_reader = cmd_id.ExecuteReader();
                    //string id_user = id_reader.GetString(0);
                    while (id_reader.Read())
                    {
                        id_user = id_reader.GetString(0);
                    }
                    conn.Close();
                    conn.Open();
                    string name = "NMDEFAULT";
                    NpgsqlCommand cmd_name = new NpgsqlCommand("Select user_name from pengguna where user_email = '" + tbEmail.Text + "' and user_password = '" + tbPassword.Text + "'", conn);
                    NpgsqlDataReader name_reader = cmd_name.ExecuteReader();
                    //string id_user = id_reader.GetString(0);
                    while (name_reader.Read())
                    {
                        name = name_reader.GetString(0);
                    }
                    conn.Close();
                    User pengguna = new User(id_user, name, tbEmail.Text);
                    Form2 f2 = new Form2(pengguna);
                    f2.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please check your email or password", "login fail", MessageBoxButtons.OK);
                    return;
                }
                //conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }
    }
}