using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.UI {
    public partial class LupaPassword : Form {

        MySqlConnection koneksi;
        MySqlCommand command;
        MySqlDataReader reader;

        String query;

        public LupaPassword()
        {
            InitializeComponent();

            koneksi = koneksiDB.koneksiDB.getkoneksi();
        }

        private void BtnFindPwd_Click(object sender, EventArgs e)
        {
            query = $"SELECT password FROM tb_admin WHERE BINARY `nama_admin` = '{txtUsername.Text}' " +
                $"AND BINARY `email` = '{txtEmail.Text}';";

            koneksi.Open();

            command = koneksi.CreateCommand();
            command.CommandText = query;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                txtEmail.Clear();
                txtUsername.Clear();
                MessageBox.Show($"Password Anda = {reader["password"].ToString()}", "Informasi Rahasia");
            }

            koneksi.Close();
        }
    }
}
