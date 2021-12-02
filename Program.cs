using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql;
using System.Data;

namespace mysql_777
{
    class Program
    {
        private static MySqlConnection newSQL;
        static void Main(string[] args)
        {
            mysql_baglanti();
            Console.ReadKey();
        }
        static void mysql_baglanti()
        {
            newSQL = new MySqlConnection("Server=localhost;Database="database_name";charset=utf8;uid=root");
            try
            {
                newSQL.Open();
                if (newSQL.State == ConnectionState.Open)
                {
                    Console.WriteLine("Mysql Database bağlantısı sağlandı.");
                }
                newSQL.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);


            }
            Console.ReadKey();
        }   


    }
}

