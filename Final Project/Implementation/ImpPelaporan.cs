using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project.Entity;
using Final_Project.Interface;
using MySql.Data.MySqlClient;

namespace Final_Project.Implementation
{
    class ImpPelaporan : IntPelaporan {

        MySqlConnection koneksi;
        MySqlDataReader reader;
        MySqlCommand command;
        Boolean status;
        String query;

        public ImpPelaporan()
        {
            koneksi = koneksiDB.koneksiDB.getkoneksi();
        }

        public bool DeleteData(string[] id)
        {
            status = false;

            try
            {
                query = $"DELETE FROM tb_pelapor WHERE id_pelapor = '{id[0]}';" +
                    $"DELETE FROM tb_lokasi WHERE id_lokasi = '{id[1]}';" +
                    $"DELETE FROM tb_barang WHERE id_barang = '{id[2]}';";

                koneksi.Open();

                command = koneksi.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                status = true;
                koneksi.Close();
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.ToString());
            }

            return status;
        }

        public bool InsertData(EntPelapor e, EntLokasi loc)
        {
            EntPelapor pelapor = new EntPelapor();
            EntLokasi lokasi = new EntLokasi();
            pelapor = e;
            lokasi = loc;
            status = false;

            try
            {
                query = $"INSERT INTO tb_barang VALUES ('{pelapor.otherId}',null,'{pelapor.jenis}','{pelapor.nama_barang}','{pelapor.status}');"
                    + $"INSERT INTO tb_lokasi VALUES ('{lokasi.id}','{lokasi.sector}','{lokasi.lantai}');"
                    + $"INSERT INTO tb_pelapor VALUES ('{pelapor.id}','{pelapor.otherId}','{pelapor.nama}','{pelapor.no_telp.ToString()}','{lokasi.id}','{e.id_admin}');";

                koneksi.Open();

                MessageBox.Show(pelapor.id);
                command = koneksi.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                status = true;
                koneksi.Close();
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.ToString());
            }

            return status;
        }

        public bool UpdateData(EntPelapor e)
        {
            EntPelapor pelapor = new EntPelapor();
            pelapor = e;
            status = false;

            try
            {
                query = $"UPDATE tb_barang SET tb_barang.status = '{e.status}', ', nama_barang = '{e.nama_barang}', jenis_barang = '{e.jenis}' WHERE id_barang = '{e.otherId}';" +
                    $"UPDATE tb_pelapor SET nama_pelapor = '{e.nama}', no_telp = '{e.no_telp}' WHERE id_pelapor = '{e.id}';";

                koneksi.Open();

                command = koneksi.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                status = true;
                koneksi.Close();
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.ToString());
            }

            return status;
        }
    }
}
