using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Final_Project.koneksiDB
{
    class koneksiDB
    {
        public static MySqlConnection getkoneksi()
        {
            string strCon = "SERVER = localhost; PORT = 3306; " +
                        "UID = root; PWD = ; " +
                        "DATABASE = db_fp;";
            return new MySqlConnection(strCon);
        }
    }
}
