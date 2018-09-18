using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Biblioteca.Models
{
    public class Connection
    {

        private SqlConnection c = new SqlConnection();    
        
        public Connection()
        {
            c = new SqlConnection();
            c.ConnectionString = "Data Source = servidor; Initial Catalog: nomeBanco; User ID = usuario; Password: senha;";
            c.Open();
        }

        public void insert(string query)
        {
            var command = new SqlCommand();
            command.Connection = c;
            command.CommandText = String.Format(query);
            command.ExecuteNonQuery();

            closeConnection();
        }

        public void closeConnection()
        {
            c.Close();

        }

    }
}
