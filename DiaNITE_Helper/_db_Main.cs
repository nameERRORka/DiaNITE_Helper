using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaNITE_Helper
{
    class _db_Main
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;username=root;password=root;database=_db_dianite");
        MySqlConnection connectionNonDB = new MySqlConnection("server=localhost;port=3307;username=root;password=root");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

       
        public void closeConnectionNonDB()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
        public void openConnectionNonDB()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connectionNonDB.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connectionNonDB.Close();
            }
        }

        public MySqlConnection getConnectionNonDB()
        {
            return connectionNonDB;
        }
    }
}
