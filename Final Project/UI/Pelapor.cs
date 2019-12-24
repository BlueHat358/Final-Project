using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project.Entity;
using Final_Project.Implementation;
using MySql.Data.MySqlClient;
using WinForm;

namespace Final_Project.UI
{
    public partial class frmPelapor : Form
    {
        private MySqlConnection koneksi;
        private MySqlCommand command;
        private MySqlDataReader reader;
        private String query, id;
        private Boolean status;

        EntPelapor e;

        public frmPelapor(Boolean show = false)
        {
            koneksi = koneksiDB.koneksiDB.getkoneksi();

            InitializeComponent();

            if (!show)
            {
                panel2.Size = new Size(408, 209);
            }
            else
            {
                panel2.Size = new Size(408, 264);
                btnSimpan.Text = "Update";
                btnTampilkan.Visible = false;
            }

            lbIdBarang.Visible = show;
            lbStatus.Visible = show;
            lbIdPelapor.Visible = show;
            txtIdBarang.Visible = show;
            txtIdBarang.Enabled = false;
            txtIdPelapor.Visible = show;
            txtIdPelapor.Enabled = false;
            rbDiambil.Visible = show;
            rbPelaporan.Visible = show;
        }

        private void btnLanjut_Click(object sender, EventArgs ev)
        {
            if(btnSimpan.Text == "LANJUT")
            {
                Lokasi lokasi = new Lokasi(getData());
                this.Hide();
                lokasi.ShowDialog();
                this.Dispose();
            }
            else
            {
                String st = "";
                if (rbDiambil.Checked)
                {
                    st = "Diambil";
                }
                else
                {
                    st = "Pelaporan";
                }

                e = new EntPelapor();
                ImpPelaporan pelaporan = new ImpPelaporan();
                e.nama = txtNamaPelapor.Text;
                e.jenis = cmbJenisBarang.Text;
                e.nama_barang = txtNamaBarang.Text;
                e.no_telp = txtNoTelp.Text;
                e.status = st;
                e.id = txtIdPelapor.Text;
                e.otherId = txtIdBarang.Text;
                pelaporan.UpdateData(e);

                this.Hide();
                frmPelapor2 frm = new frmPelapor2();
                MessageBox.Show("Update Berhasil");
                frm.ShowDialog();
                this.Dispose();
            }
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPelapor2 frm = new frmPelapor2();
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

        private void btnPenemu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPenemu frm = new frmPenemu();
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

        private void btnLogOut_Click(object sender, EventArgs ev)
        {
            ImpSignOut signOut = new ImpSignOut();
            signOut.SignOut();

            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Dispose();
        }

        public EntPelapor getData()
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

            e = new EntPelapor();
            e.id = kodeBaru("pelapor");
            e.otherId = kodeBaru("barang");
            e.nama = txtNamaPelapor.Text;
            e.jenis = cmbJenisBarang.Text;
            e.nama_barang = txtNamaBarang.Text;
            e.no_telp = txtNoTelp.Text;
            e.ruang = null;
            e.status = "Pelaporan";
            e.id_admin = id;

            koneksi.Close();

            return e;
        }

        private String kodeBaru(String kodes)
        {
            koneksi.Close();
            int kode = 0;
            String newKode = "", first = "";
            try
            {
                if (kodes == "pelapor")
                {
                    query = "SELECT MAX(RIGHT(id_pelapor,3)) FROM tb_pelapor";

                    koneksi.Open();
                    command = koneksi.CreateCommand();
                    command.CommandText = query;
                    reader = command.ExecuteReader();

                    first = "PL";
                }else if(kodes == "lokasi")
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

        public void getChangeData(EntPelapor e)
        {
            txtIdBarang.Text = e.otherId;
            txtIdPelapor.Text = e.id;
            txtNamaBarang.Text = e.nama_barang;
            txtNamaPelapor.Text = e.nama;
            cmbJenisBarang.Text = e.jenis;
            txtNoTelp.Text = e.no_telp;
        }
    }
}
