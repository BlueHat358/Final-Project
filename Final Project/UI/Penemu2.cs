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
    public partial class frmPenemu2 : Form
    {

        MySqlConnection koneksi;
        MySqlCommand command;
        MySqlDataReader reader;

        String query;

        public frmPenemu2()
        {
            koneksi = koneksiDB.koneksiDB.getkoneksi();

            InitializeComponent();

            showData();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            EntPenemu penemu = new EntPenemu();
            EntBarang barang = new EntBarang();

            penemu.id = dgvPenemu.SelectedRows[0].Cells[0].Value.ToString();
            penemu.nama = dgvPenemu.SelectedRows[0].Cells[2].Value.ToString();
            penemu.id_lokasi = dgvPenemu.SelectedRows[0].Cells[7].Value.ToString();
            penemu.id_admin = dgvPenemu.SelectedRows[0].Cells[6].Value.ToString();
            penemu.ruang = dgvPenemu.SelectedRows[0].Cells[5].Value.ToString();
            barang.id = dgvPenemu.SelectedRows[0].Cells[1].Value.ToString();
            barang.nama = dgvPenemu.SelectedRows[0].Cells[4].Value.ToString();
            barang.jenis = dgvPenemu.SelectedRows[0].Cells[3].Value.ToString();

            frmPelapor frm = new frmPelapor(true, 1);
            frm.getEntity(penemu, barang);
            this.Hide();
            frm.ShowDialog();
            this.Dispose();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            String id, id1;
            query = $"SELECT id_ruang FROM tb_barang WHERE id = '{dgvPenemu.SelectedRows[0].Cells[1].ToString()}';";

            koneksi.Open();
            command = koneksi.CreateCommand();
            command.CommandText = query;
            reader = command.ExecuteReader();

            reader.Read();
            id = reader["id_ruang"].ToString();
            koneksi.Close();

            query = $"SELECT id_lokasi FROM tb_penemu WHERE id = '{dgvPenemu.SelectedRows[0].Cells[0].ToString()}';";

            koneksi.Open();
            command = koneksi.CreateCommand();
            command.CommandText = query;
            reader = command.ExecuteReader();

            reader.Read();
            id1 = reader["id_lokasi"].ToString();
            koneksi.Close();

            String[] id_ = new String[4]
            {
                dgvPenemu.SelectedRows[0].Cells[0].ToString(),
                id1,
                dgvPenemu.SelectedRows[0].Cells[1].ToString(),
                id
            };

            ImpPenemu imp = new ImpPenemu();
            if (imp.DeleteData(id_))
            {
                MessageBox.Show("Hapus Berhasil");
            }

            if (this.dgvPenemu.SelectedRows.Count > 0)
            {
                dgvPenemu.Rows.RemoveAt(this.dgvPenemu.SelectedRows[0].Index);
            };
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKehilangan frm = new frmKehilangan();
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
            this.Dispose();
        }

        private void showData()
        {
            int count = 0;

            query = "SELECT tb_penemu.id_penemu, tb_penemu.id_barang, tb_penemu.nama_penemu, " +
                "tb_barang.jenis_barang, tb_barang.nama_barang,tb_ruang.nama_ruang, tb_penemu.id_admin, tb_penemu.id_lokasi, tb_barang.status " +
                "FROM tb_penemu " +
                "INNER JOIN tb_barang ON tb_penemu.id_barang = tb_barang.id_barang " +
                "INNER JOIN tb_ruang ON tb_barang.id_ruang = tb_ruang.id_ruang";
            koneksi.Open();
            command = koneksi.CreateCommand();
            command.CommandText = query;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                dgvPenemu.Rows.Add();
                dgvPenemu[0, count].Value = reader["id_penemu"].ToString();
                dgvPenemu[1, count].Value = reader["id_barang"].ToString();
                dgvPenemu[2, count].Value = reader["nama_penemu"].ToString();
                dgvPenemu[3, count].Value = reader["jenis_barang"].ToString();
                dgvPenemu[4, count].Value = reader["nama_barang"].ToString();
                dgvPenemu[5, count].Value = reader["nama_ruang"].ToString();
                dgvPenemu[6, count].Value = reader["id_admin"].ToString();
                dgvPenemu[7, count].Value = reader["id_lokasi"].ToString();
                dgvPenemu[8, count].Value = reader["status"].ToString();

                count++;
            }
            koneksi.Close();
        }

        private void BtnCari_Click(object sender, EventArgs e)
        {
            int count = 0;
            EntData data = new EntData();
            ImpPenemu imp = new ImpPenemu();
            data = imp.Search(txtCari.Text);

            //MessageBox.Show(data.dataBarang.Count.ToString());

            dgvPenemu.Rows.Clear();

            for (int i = 0; i < data.dataPenemu.Count; i++)
            {
                dgvPenemu.Rows.Add();
                dgvPenemu[0, count].Value = data.dataPenemu[i].id;
                dgvPenemu[1, count].Value = data.dataBarang[i].id;
                dgvPenemu[2, count].Value = data.dataPenemu[i].nama;
                dgvPenemu[3, count].Value = data.dataBarang[i].jenis;
                dgvPenemu[4, count].Value = data.dataBarang[i].nama;
                dgvPenemu[5, count].Value = data.dataRuang[i].nama;
                dgvPenemu[6, count].Value = data.dataPenemu[i].id_admin;
                dgvPenemu[7, count].Value = data.dataPenemu[i].id_lokasi;
                dgvPenemu[8, count].Value = data.dataBarang[i].status;
                count++;
            }
        }
    }
}
