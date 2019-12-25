using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project.Entity;
using MySql.Data.MySqlClient;

namespace Final_Project.Implementation {

    class ImpPenemu : Interface.IntPenemu {

        MySqlConnection koneksi;
        MySqlCommand command;
        MySqlDataReader reader;

        String query;
        Boolean status;

        public ImpPenemu()
        {
            koneksi = koneksiDB.koneksiDB.getkoneksi();
        }

        public bool DeleteData(string[] id)
        {
            try
            {
                query = $"DELETE FROM tb_penemu WHERE id_penemu = '{id[0]}';" +
                    $"DELETE FROM tb_lokasi WHERE id_penemu = '{id[1]}';" +
                    $"DELETE FROM tb_barang WHERE id_penemu = '{id[2]}';" +
                    $"UPDATE tb_ruang SET status_ruang = 'Kosong' WHERE id_ruang = '{id[3]}';";

                koneksi.Open();
                command = koneksi.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                koneksi.Close();

                status = true;
            }
            catch (MySqlException er)
            {
                status = false;
                MessageBox.Show(er.ToString());
            }
            return status;
        }

        public bool InsertData(EntPenemu p, EntLokasi loc, EntRuang r, EntBarang b)
        {
            MessageBox.Show(p.id_barang + " " + r.id);
            try
            {
                query = $"UPDATE tb_ruang SET status_ruang = '{r.status}' WHERE id_ruang = '{r.id}';" +
                $"INSERT INTO tb_lokasi VALUES('{loc.id}', '{loc.sector}', '{loc.lantai}');" +
                $"INSERT INTO tb_barang VALUES('{p.id_barang}', '{r.id}', '{b.jenis}', '{b.nama}', '{b.status}');" +
                $"INSERT INTO tb_penemu VALUES('{p.id}', '{p.id_barang}', '{p.nama}', '{loc.id}', '{p.id_admin}');";

                koneksi.Open();
                command = koneksi.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                koneksi.Close();

                status = true;
            }catch(MySqlException er)
            {
                status = false;
                MessageBox.Show(er.ToString());
            }

            return status;
        }

        public EntData Search(string nama)
        {
            EntData data = new EntData();
            List<EntBarang> listBarang = new List<EntBarang>();
            List<EntPenemu> listPenemu = new List<EntPenemu>();
            List<EntRuang> listRuang = new List<EntRuang>();

            query = $"SELECT tb_penemu.id_penemu, tb_penemu.id_barang, tb_penemu.nama_penemu, " +
                $"tb_barang.jenis_barang, tb_barang.nama_barang,tb_ruang.nama_ruang, tb_penemu.id_admin, tb_penemu.id_lokasi, tb_barang.status " +
                $"FROM tb_penemu " +
                $"INNER JOIN tb_barang ON tb_penemu.id_barang = tb_barang.id_barang " +
                $"INNER JOIN tb_ruang ON tb_barang.id_ruang = tb_ruang.id_ruang " +
                $"where tb_penemu.nama_penemu Like '%{nama}%' OR tb_barang.nama_barang LIKE '%{nama}%' ";
            koneksi.Open();
            command = koneksi.CreateCommand();
            command.CommandText = query;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                EntBarang barang = new EntBarang();
                EntPenemu penemu = new EntPenemu();
                EntRuang ruang = new EntRuang();

                penemu.id = reader["id_penemu"].ToString();
                barang.id = reader["id_barang"].ToString();
                penemu.nama = reader["nama_penemu"].ToString();
                barang.jenis = reader["jenis_barang"].ToString();
                barang.nama = reader["nama_barang"].ToString();
                ruang.nama = reader["nama_ruang"].ToString();
                penemu.id_admin = reader["id_admin"].ToString();
                penemu.id_lokasi = reader["id_lokasi"].ToString();
                barang.status = reader["status"].ToString();

                listBarang.Add(barang);
                listRuang.Add(ruang);
                listPenemu.Add(penemu);
            }
            koneksi.Close();

            data.dataBarang = listBarang;
            data.dataPenemu = listPenemu;
            data.dataRuang = listRuang;

            return data;
        }

        public bool UpdateData(EntBarang b, EntPenemu pen, EntPelapor p)
        {
            Boolean status;
            try
            {
                query = $"UPDATE tb_ruang SET status_ruang = 'Kosong' WHERE nama_ruang = '{pen.ruang}';" +
               $"UPDATE tb_barang SET status = 'Diambil' WHERE id_barang = '{b.id}';" +
               $"INSERT INTO tb_pelapor VALUES('{p.id}', '{b.id}', '{p.nama}', '{p.no_telp}', '{p.otherId}', '{p.id_admin}');";

                koneksi.Open();
                command = koneksi.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();

                status = true;
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.ToString());
                status = false;
            }

            return status;
        }
    }
}
