using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AllTours
{
    class DBConnector
    {
        bool _isConnected = false;
        SqlConnection connection;
        public void Connect()
        {
            if (!_isConnected)
            {
                connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\Desktop\\ИСПРО\\AllTours\\MegaDatabase.mdf;Integrated Security=True");
                connection.Open();
                _isConnected = true;
            }
            //var commannd = new SqlCommand("INSERT INTO Clients (Name) VALUES ('Sam');", connection);
            //commannd.ExecuteNonQuery();
            //connection.Close();

        }
        public void Close()
        {
            if (_isConnected)
            {
                connection.Close();
                _isConnected = false;
            }
        }
        public void AddClientToDB(Client client)
        {
            var command = new SqlCommand();
        }
    }
}
