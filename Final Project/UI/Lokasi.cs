using Final_Project.Entity;
using Final_Project.Implementation;

using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using WinForm;

namespace Final_Project.UI {
    public partial class Lokasi : Form {

        private MySqlConnection koneksi;
        private MySqlCommand command;
        private MySqlDataReader reader;
        private String query;

        EntPelapor pelapor;

        public Lokasi(EntPelapor e)
        {

            pelapor = new EntPelapor();
            pelapor = e;

            koneksi = koneksiDB.koneksiDB.getkoneksi();

            InitializeComponent();
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            ImpPelaporan pelaporan = new ImpPelaporan();
            Boolean status = pelaporan.InsertData(pelapor, getData());
            if (status)
                MessageBox.Show("Input Berhasil");
            else
            {
                MessageBox.Show("Input Gagal");
            }

            MessageBox.Show(pelapor.id_admin);

            this.Hide();
            frmPelapor frm = new frmPelapor();
            frm.ShowDialog();
            this.Dispose();
        }

        private EntLokasi getData()
        {
            EntLokasi loc = new EntLokasi();
            loc.id = kodeBaru("lokasi");
            loc.lantai = Convert.ToInt32(txtLantai.Text);
            loc.sector = txtNamaSector.Text;
            loc.otherId = kodeBaru("ruang");

            return loc;
        }

        private String kodeBaru(String kodes)
        {
            int kode = 0;
            String newKode = "", first = "";
            try
            {
                if (kodes == "lokasi")
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
                    query = "SELECT MAX(RIGHT(id_ruang,3)) FROM tb_ruang";

                    koneksi.Open();
                    command = koneksi.CreateCommand();
                    command.CommandText = query;
                    reader = command.ExecuteReader();

                    first = "RU";
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

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKehilangan frm = new frmKehilangan();
            frm.ShowDialog();
            this.Dispose();
        }

        private void BtnPenemu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPenemu frm = new frmPenemu();
            frm.ShowDialog();
            this.Dispose();
        }

        private void BtnRuang_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRuang frm = new frmRuang();
            frm.ShowDialog();
            this.Dispose();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
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
