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
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            String id, id1;
            query = $"SELECT id_ruang FROM tb_barang WHERE id = '{dgvPenemu.SelectedRows[0].Cells[1].ToString()}';";

            koneksi.Open();
            command = koneksi.CreateCommand();
            command.CommandText();
            reader = command.ExecuteReader();

            reader.Read();
            id = reader["id_ruang"].ToString();
            koneksi.Close();

            query = $"SELECT id_lokasi FROM tb_penemu WHERE id = '{dgvPenemu.SelectedRows[0].Cells[0].ToString()}';";

            koneksi.Open();
            command = koneksi.CreateCommand();
            command.CommandText();
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
    }
}
