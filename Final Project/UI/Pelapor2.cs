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
    public partial class frmPelapor2 : Form
    {
        public frmPelapor2()
        {
            InitializeComponent();

            dgvPelapor.ForeColor = Color.Black;

            showData();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            EntPelapor pelapor = new EntPelapor();
            pelapor.id = dgvPelapor.SelectedRows[0].Cells[0].Value.ToString();
            pelapor.otherId = dgvPelapor.SelectedRows[0].Cells[2].Value.ToString();
            pelapor.nama = dgvPelapor.SelectedRows[0].Cells[3].Value.ToString();
            pelapor.jenis = dgvPelapor.SelectedRows[0].Cells[4].Value.ToString();
            pelapor.nama_barang = dgvPelapor.SelectedRows[0].Cells[5].Value.ToString();
            pelapor.no_telp = dgvPelapor.SelectedRows[0].Cells[6].Value.ToString();

            this.Hide();
            frmPelapor frm = new frmPelapor(true);
            frm.getChangeData(pelapor);
            frm.ShowDialog();
            this.Dispose();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            String[] id = new String[3]
               {
                    dgvPelapor.SelectedRows[0].Cells[0].Value.ToString(),
                    dgvPelapor.SelectedRows[0].Cells[2].Value.ToString(),
                    dgvPelapor.SelectedRows[0].Cells[1].Value.ToString()
               };

            ImpPelaporan imp = new ImpPelaporan();
            if (imp.DeleteData(id))
            {
                MessageBox.Show("Hapus Berhasil");
            }
            
            if (this.dgvPelapor.SelectedRows.Count > 0)
            {
                dgvPelapor.Rows.RemoveAt(this.dgvPelapor.SelectedRows[0].Index);
               
            };
            dgvPelapor.Refresh();
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

        private void btnPangambil_Click(object sender, EventArgs e)
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
            String query = "SELECT * FROM tb_pelapor;";

            List<EntPelapor> data = new List<EntPelapor>();
            List<EntBarang> data1 = new List<EntBarang>();

            MySqlConnection koneksi;
            MySqlCommand command;
            MySqlDataReader reader;

            koneksi = koneksiDB.koneksiDB.getkoneksi();
            koneksi.Open();


            command = koneksi.CreateCommand();
            command.CommandText = query;
            reader = command.ExecuteReader();

            EntPelapor pelapor = new EntPelapor();

            while (reader.Read())
            {
                pelapor.id = reader["id_pelapor"].ToString();
                pelapor.otherId = reader["id_barang"].ToString();
                pelapor.nama = reader["nama_pelapor"].ToString();
                pelapor.no_telp = reader["no_telp"].ToString();
                pelapor.otherId1 = reader["id_lokasi"].ToString();

                data.Add(pelapor);
            }
            koneksi.Close();

            query = "SELECT * FROM tb_barang WHERE id_barang = ";
            
            for (int i = 0; i < data.Count; i++)
            {
                
                koneksi.Open();
                EntBarang barang = new EntBarang();
                command = koneksi.CreateCommand();
                command.CommandText = query + $"'{data[i].otherId}';";
                reader = command.ExecuteReader();

                reader.Read();
                pelapor.jenis = reader["jenis_barang"].ToString();
                pelapor.nama_barang = reader["nama_barang"].ToString();
                barang.status = reader["status"].ToString();

                data1.Add(barang);
                koneksi.Close();
            }

            for (int i = 0; i < data.Count; i++)
            {
                dgvPelapor.Rows.Add();
                dgvPelapor[0, i].Value = data[i].id;
                dgvPelapor[1, i].Value = data[i].otherId1;
                dgvPelapor[2, i].Value = data[i].otherId;
                dgvPelapor[3, i].Value = data[i].nama;
                dgvPelapor[4, i].Value = data[i].jenis;
                dgvPelapor[5, i].Value = data[i].nama_barang;
                dgvPelapor[6, i].Value = data[i].no_telp;
                dgvPelapor[7, i].Value = data1[i].status;
            }
        }
    }
}
