using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos
{
    public abstract class DB
    {
        private string _connectionstring;
        protected SqlConnection _connection;

        public DB(string server, string db, string user, string password)
        {
            _connectionstring = $"Data Source={server}; Initial Catalog={db};" +
                $"User={user};Password={password}";
        }

        public void Connect()
        {
            _connection = new SqlConnection(_connectionstring);
            _connection.Open();
        }

        public void Close()
        {
            if(_connection != null && _connection.State == System.Data.ConnectionState.Open)
                _connection.Close();
        }
    }
}
