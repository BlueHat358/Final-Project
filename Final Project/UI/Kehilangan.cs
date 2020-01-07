using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project.Implementation;
using Final_Project.UI;
using MySql.Data.MySqlClient;
using WinForm;

namespace Final_Project
{
    public partial class frmKehilangan : Form
    {

        MySqlConnection koneksi;
        MySqlCommand command;
        MySqlDataReader reader;

        String query;

        public frmKehilangan()
        {
            koneksi = koneksiDB.koneksiDB.getkoneksi();

            InitializeComponent();

            showData();
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

        private void btnRuang_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRuang frm = new frmRuang();
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
            this.Dispose(); Dispose();
        }

        private void BtnCari_Click(object sender, EventArgs e)
        {
            int count = 0;
            if(txtCari.Text == null)
            {
                showData();
            }
            else
            {
                query = $"SELECT * FROM tb_barang WHERE nama_barang LIKE '%{txtCari.Text}%'";

                koneksi.Open();
                command = koneksi.CreateCommand();
                command.CommandText = query;
                reader = command.ExecuteReader();

                dgvBarang.Rows.Clear();

                while (reader.Read())
                {
                    dgvBarang.Rows.Add();
                    dgvBarang[0, count].Value = reader["id_barang"].ToString();
                    dgvBarang[1, count].Value = reader["id_ruang"].ToString();
                    dgvBarang[2, count].Value = reader["jenis_barang"].ToString();
                    dgvBarang[3, count].Value = reader["nama_barang"].ToString();
                    dgvBarang[4, count].Value = reader["status"].ToString();
                    count++;
                }
                koneksi.Close();
            }
        }

        private void showData()
        {
            int count = 0;
            query = "SELECT * FROM tb_barang";

            koneksi.Open();
            command = koneksi.CreateCommand();
            command.CommandText = query;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                dgvBarang.Rows.Add();
                dgvBarang[0, count].Value = reader["id_barang"].ToString();
                dgvBarang[1, count].Value = reader["id_ruang"].ToString();
                dgvBarang[2, count].Value = reader["jenis_barang"].ToString();
                dgvBarang[3, count].Value = reader["nama_barang"].ToString();
                dgvBarang[4, count].Value = reader["status"].ToString();
                count++;
            }
            koneksi.Close();
        }
    }
}
