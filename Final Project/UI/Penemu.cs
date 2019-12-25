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

        String query, id;
        EntPenemu pen;

        public frmPenemu()
        {
            koneksi = koneksiDB.koneksiDB.getkoneksi();

            InitializeComponent();

            getRuangKosong();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            this.Hide();
            LokasiPenemu frm = new LokasiPenemu(getPenemu(), GetBarang());
            frm.ShowDialog();
            this.Dispose();
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
            }

            koneksi.Close();
        }

        public EntPenemu getPenemu()
        {
            query = "SELECT id_admin FROM tb_admin WHERE status_admin = 1;";

            koneksi.Open();
            command = koneksi.CreateCommand();
            command.CommandText = query;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                id = reader["id_admin"].ToString();
            }

            pen = new EntPenemu();
            pen.id = kodeBaru("penemu");
            pen.id_barang = kodeBaru("barang");
            pen.nama = txtNamaPenemu.Text;
            pen.ruang = cmbRuang.Text;
            pen.id_admin = id;

            koneksi.Close();

            return pen;
        }

        public EntBarang GetBarang()
        {
            EntBarang barang = new EntBarang();
            barang.jenis = cmbJenisBarang.Text;
            barang.nama = txtNamaBarang.Text;
            barang.status = "Penemu";

            return barang;
        }

        private String kodeBaru(String kodes)
        {
            koneksi.Close();
            int kode = 0;
            String newKode = "", first = "";
            try
            {
                if (kodes == "penemu")
                {
                    query = "SELECT MAX(RIGHT(id_penemu,3)) FROM tb_penemu";

                    koneksi.Open();
                    command = koneksi.CreateCommand();
                    command.CommandText = query;
                    reader = command.ExecuteReader();

                    first = "PN";
                }
                else if (kodes == "lokasi")
                {
                    query = "SELECT MAX(RIGHT(id_lokasi,3)) FROM tb_lokasi";

                    koneksi.Open();
                    command = koneksi.CreateCommand();
                    command.CommandText = query;
                    reader = command.ExecuteReader();

                    first = "LC";
                }
                else
                {
                    query = "SELECT MAX(RIGHT(id_barang,3)) FROM tb_barang";

                    koneksi.Open();
                    command = koneksi.CreateCommand();
                    command.CommandText = query;
                    reader = command.ExecuteReader();

                    first = "BR";
                }

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
