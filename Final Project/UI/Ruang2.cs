using Final_Project.Entity;
using Final_Project.Implementation;
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
using WinForm;

namespace Final_Project.UI
{
    public partial class frmRuang2 : Form
    {

        MySqlConnection koneksi;
        MySqlCommand command;
        MySqlDataReader reader;

        String query, newKode, first;

        EntRuang ruang;

        public frmRuang2()
        {
            koneksi = koneksiDB.koneksiDB.getkoneksi();

            InitializeComponent();

            ruang = new EntRuang();
            ruang.id = kodeBaru();
        }

        private void btnTambahkan_Click(object sender, EventArgs e)
        {
            query = $"INSERT INTO tb_ruang VALUES ('{ruang.id}', '{txtNamaRuang.Text}', 'Kosong');";

            koneksi.Open();
            command = koneksi.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();

            koneksi.Close();

            txtNamaRuang.Clear();

            MessageBox.Show("Input Ruang Ke Database Berhasil","Berhasil");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKehilangan frm = new frmKehilangan();
            frm.ShowDialog();
            this.Dispose();
        }

        private void btnPenemu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPenemu frm = new frmPenemu();
            frm.ShowDialog();
            this.Dispose();
        }

        private void btnPelapor_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPelapor frm = new frmPelapor();
            frm.ShowDialog();
            this.Dispose();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            ImpSignOut signOut = new ImpSignOut();
            signOut.SignOut();

            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Dispose();
        }

        private void BtnRuang_Click(object sender, EventArgs e)
        {
            frmRuang frm = new frmRuang();
            this.Hide();
            frm.ShowDialog();
            this.Dispose();
        }

        private String kodeBaru()
        {
            int kode = 0;
            try
            {
                query = "SELECT MAX(RIGHT(id_ruang,3)) FROM tb_ruang";

                koneksi.Open();
                command = koneksi.CreateCommand();
                command.CommandText = query;
                reader = command.ExecuteReader();

                first = "RU";

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
    }
}
