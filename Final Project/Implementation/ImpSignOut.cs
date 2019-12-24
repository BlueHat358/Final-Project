using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Implementation {
    class ImpSignOut {

        MySqlConnection koneksi;
        MySqlCommand command;
        //MySqlDataReader reader;
        String query, id;

        Boolean status = false;

        public ImpSignOut()
        {
            koneksi = koneksiDB.koneksiDB.getkoneksi();
        }

        public Boolean SignOut()
        { 
            koneksi.Open();
            query = "UPDATE tb_admin SET status_admin = 0 WHERE status_admin = 1;";
            command = koneksi.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();

            koneksi.Close();
            return status;
        }
    }
}
