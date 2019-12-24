using Final_Project.Entity;
using Final_Project.koneksiDB;
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

namespace WinForm
{
    public partial class Sign_Up : Form
    {

        MySqlConnection koneksi;
        MySqlCommand command;
        MySqlDataReader reader;

        String query;
        String newKode, first;

        bool status;

        EntAdmin entAdmin;

        public Sign_Up()
        {
            koneksi = koneksiDB.getkoneksi();
            InitializeComponent();

            entAdmin = new EntAdmin();
            entAdmin.id = kodeBaru();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            entAdmin.nama = txtUsername.Text;
            entAdmin.password = txtPassword.Text;
            entAdmin.email = txtEmail.Text;
            entAdmin.status = 0;

           if(!SameData(entAdmin.nama, entAdmin.email))
            {
                query = $"INSERT INTO tb_admin VALUES('{entAdmin.id}','{entAdmin.nama}','{entAdmin.password}','{entAdmin.email}','{entAdmin.status}');";

                try
                {
                    koneksi.Open();
                    command = koneksi.CreateCommand();
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                    koneksi.Close();

                    MessageBox.Show("Selamat Anda berhasil mendaftarkan diri", "Berhasil");

                    Login frm = new Login();
                    this.Hide();
                    frm.ShowDialog();
                    this.Dispose();

                }
                catch (MySqlException en)
                {
                    //MessageBox.Show("Maaf anda gagal mendaftarkan diri", "Gagal");
                    MessageBox.Show(en.ToString());
                }
            }
        }

        private String kodeBaru()
        {
            int kode = 0;
            try
            {
                query = "SELECT MAX(RIGHT(id_admin,3)) FROM tb_admin";

                koneksi.Open();
                command = koneksi.CreateCommand();
                command.CommandText = query;
                reader = command.ExecuteReader();

                first = "AD";

                while (reader.Read())
                {
                    kode = Int16.Parse(reader.GetString(0).ToString());

                    if (kode < 9)
                    {
                        newKode = first + "00" + (kode + 1);
                    }
                    else if (kode < 99)
                    {
                        newKode = first + "0" + (kode + 1);
                    }
                    else
                    {
                        newKode = first + (kode + 1);
                    }
                }

                //MessageBox.Show(newKode);
                koneksi.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }

            return newKode;
        }

        private Boolean SameData(String nama, String email)
        {
            query = "SELECT nama_admin, email FROM tb_admin";

            koneksi.Open();
            command = koneksi.CreateCommand();
            command.CommandText = query;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                if((nama == reader["nama_admin"].ToString()) && (email == reader["email"].ToString()))
                {
                    MessageBox.Show("Maaf Gunakan Nama dan Email yang lain");
                    status = true;
                }
                else
                {
                    status = false;
                }
            }

            return status;
        }
    }
}
