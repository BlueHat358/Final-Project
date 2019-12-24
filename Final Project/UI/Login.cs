using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project;
using Final_Project.koneksiDB;
using Final_Project.UI;
using MySql.Data.MySqlClient;


namespace WinForm
{
    public partial class Login : Form
    {

        private String query, id;
        private Boolean status;
        private MySqlConnection Koneksi;
        private MySqlCommand command;
        private MySqlDataReader reader;
        private KeyEventArgs e;


        public Login()
        {
            Koneksi = koneksiDB.getkoneksi();
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, KeyEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LblSignUp_Click(object sender, EventArgs e)
        {
            Sign_Up frm = new Sign_Up();
            this.Hide();
            frm.ShowDialog();
            this.Dispose();
        }

        private void LbLupaPwd_Click(object sender, EventArgs e)
        {
            LupaPassword frm = new LupaPassword();
            this.Hide();
            frm.ShowDialog();
            this.Dispose();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            query = $"SELECT id_admin FROM tb_admin WHERE BINARY `nama_admin` = '{txtUsername.Text}' AND BINARY `password` = '{txtPassword.Text}'";

            Koneksi.Open();
            command = Koneksi.CreateCommand();
            command.CommandText = query;
            reader = command.ExecuteReader();

            while (reader.Read()) {
                id = reader["id_admin"].ToString();
            }

            Koneksi.Close();

            Koneksi.Open();

            query = $"UPDATE tb_admin SET status_admin = 1 WHERE id_admin = '{id}';";
            command.CommandText = query;
            command.ExecuteNonQuery();

            Koneksi.Close();

            if (id != null)
            {
                frmKehilangan frm = new frmKehilangan();
                this.Hide();
                frm.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Maaf Username atau Password anda salah", "Input Salah");
                Koneksi.Close();
            }
        }
    }
}
