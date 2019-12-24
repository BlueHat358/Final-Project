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
    public partial class frmPenemu : Form
    {

        MySqlConnection koneksi;
        MySqlDataReader reader;
        MySqlCommand command;

        List<EntRuang> entRuang;

        String query;

        public frmPenemu()
        {
            koneksi = koneksiDB.koneksiDB.getkoneksi();

            InitializeComponent();

            getRuangKosong();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPenemu2 frm = new frmPenemu2();
            frm.ShowDialog();
            this.Dispose();
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

        private void getRuangKosong()
        {
            entRuang = new List<EntRuang>();

            EntRuang ruang = new EntRuang();
            koneksi.Open();


            query = "SELECT * FROM tb_ruang WHERE status_ruang = 'Kosong';";

            command = koneksi.CreateCommand();
            command.CommandText = query;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                ruang.id = reader["id_ruang"].ToString();
                ruang.nama = reader["nama_ruang"].ToString();
                ruang.status = reader["status_ruang"].ToString();

                cmbRuang.Items.Add(ruang.nama);

                entRuang.Add(ruang);
            }

            koneksi.Close();
        }
    }
}
