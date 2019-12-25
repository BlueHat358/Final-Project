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
    public partial class frmRuang : Form
    {

        MySqlConnection koneksi;
        MySqlCommand command;
        MySqlDataReader reader;

        String query;

        Boolean stat;

        public frmRuang()
        {
            InitializeComponent();

            koneksi = koneksiDB.koneksiDB.getkoneksi();

            showAllData();
        }

        private void btnTambahkan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRuang2 frm = new frmRuang2();
            frm.ShowDialog();
            this.Dispose();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            String getId = dgvRuang.SelectedRows[0].Cells[0].Value.ToString();

            if (DeleteData(getId))
            {
                MessageBox.Show("Data Berhasil Dihapus", "Berhasil");
            }
            else
            {
                MessageBox.Show("Data Gagal Dihapus", "Error");
            }

            if (this.dgvRuang.SelectedRows.Count > 0)
            {
                dgvRuang.Rows.RemoveAt(this.dgvRuang.SelectedRows[0].Index);
            };
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

        private void btnPengambil_Click(object sender, EventArgs e)
        {
            this.Hide();
           
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

        private void showAllData()
        {
            int count = 0;

            query = "SELECT tb_ruang.id_ruang, tb_ruang.nama_ruang, tb_ruang.status_ruang, " +
                "tb_barang.id_barang, tb_barang.nama_barang FROM tb_ruang " +
                "LEFT JOIN tb_barang ON " +
                "tb_ruang.id_ruang = tb_barang.id_ruang ORDER BY tb_ruang.id_ruang";

            koneksi.Open();
            command = koneksi.CreateCommand();
            command.CommandText = query;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                EntRuang ruang = new EntRuang();
                EntBarang barang = new EntBarang();
                ruang.id = reader["id_ruang"].ToString();
                ruang.nama = reader["nama_ruang"].ToString();
                ruang.status = reader["status_ruang"].ToString();
                barang.id = reader["id_barang"].ToString();
                barang.nama = reader["nama_barang"].ToString();

                dgvRuang.Rows.Add();
                dgvRuang[0, count].Value = ruang.id;
                dgvRuang[1, count].Value = ruang.nama;
                dgvRuang[2, count].Value = barang.id;
                dgvRuang[3, count].Value = barang.nama;
                dgvRuang[4, count].Value = ruang.status;


                count++;
            }
            koneksi.Close();


        }

        private Boolean DeleteData(String id)
        {
            query = $"DELETE FROM tb_ruang WHERE id_ruang = '{id}';";

            try
            {
                koneksi.Open();
                command = koneksi.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();

                stat = true;
            }
            catch(MySqlException er)
            {
                //MessageBox.Show(er.ToString());
                stat = false;
            }

            return stat;
        }
    }
}
