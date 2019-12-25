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

        public bool Search(string nama)
        {
            throw new NotImplementedException();
        }

        public bool UpdateData(EntRuang r)
        {
            throw new NotImplementedException();
        }
    }
}
