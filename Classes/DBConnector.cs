using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace AllTours
{
    class DBConnector
    {
        SqlConnection connection;
        public DBConnector()
        {
#if DEBUG
            string workingDirectory = Environment.CurrentDirectory;
            string path = Directory.GetParent(workingDirectory).Parent.FullName;
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
#endif
#if !DEBUG
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
#endif
        }
        public void Connect()
        {
            connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DBs\\MegaDatabase.mdf;Integrated Security=True");
            connection.Open();
            //var commannd = new SqlCommand("INSERT INTO Clients (Name) VALUES ('Sam');", connection);
            //commannd.ExecuteNonQuery();
            //connection.Close();
        }
        public void Close()
        {
            connection.Close();
        }
        public void Insert(string sqlCommand)
        {
            var command = new SqlCommand(sqlCommand, connection);
            command.ExecuteNonQuery();
        }
        public bool IsAccountValid(string username, string password)
        {
            SqlConnection securityConnection = new SqlConnection();
            string sql_command = $"SELECT count(*) FROM Accounts WHERE name = {username};";
            bool SqlUserExists;

            using (SqlCommand command = new SqlCommand(sql_command, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.GetValue(0).ToString() == "1")
                        {
                            SqlUserExists = true;
                        }
                    }
                }
            }
            SqlUserExists = false;


            if (SqlUserExists)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=.;" + "User id=" + username + ";Password=" + password + ";";
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    MessageBox.Show("Data Base is unavailable", "DB connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Dispose();
                    return false;
                }

            }
            else
            {
                return true;
            }
        }

        private void Disconnect(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }
        private bool IsAvailable()
        {
            try
            {
                connection.Open();
                connection.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Data Base is unavailable", "DB connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public void CreateAccount(string username, string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\Desktop\\ИСПРО\\AllTours\\DBs\\UserDatabase.mdf;Integrated Security=True";
            conn.Open();
            var command = new SqlCommand($"INSERT INTO Accounts (username, password) VALUES ('{username}', '{savedPasswordHash}');", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
        public bool Login(string username, string password)
        {
            if (username.Length < 1 || password.Length < 1)
                return false;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\Desktop\\ИСПРО\\AllTours\\DBs\\UserDatabase.mdf;Integrated Security=True";
            conn.Open();
            var command = new SqlCommand($"Select password FROM Accounts Where username = '{username}'", conn);
            /* Fetch the stored value */
            string savedPasswordHash;
            using(SqlDataReader reader = command.ExecuteReader())
            {
                if (!reader.HasRows)
                {
                    MessageBox.Show("Incorrect username or password", "Authentication has failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    reader.Read();
                    savedPasswordHash = reader.GetString(0);
                }
            }
            /* Extract the bytes */
            byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);
            /* Get the salt */
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            /* Compute the hash on the password the user entered */
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);
            /* Compare the results */
            for (int i = 0; i < 20; i++)
                if (hashBytes[i + 16] != hash[i])
                {
                    MessageBox.Show("Incorrect username or password", "Authentication has failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    return false;
                }
            conn.Close();
            return true;
        }

        public void AddInfoIntoDatabase (Order order)
        {
            Insert($"INSERT INTO Clients VALUES ({Counter.id}, N'{order.client.name}', '{order.client.phone}', '{order.client.email}');");
            Insert($"INSERT INTO Tickets VALUES ({Counter.id}, '{order.ticket.id}', N'{order.ticket.ticketType}');");
            string sqlFormattedDate = order.orderTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
            if (order.tour is BusinessTour)
                Insert($"INSERT INTO Orders VALUES ({Counter.id}, {Counter.id}, {Counter.id}, '{sqlFormattedDate}', N'{order.tour.name}', {order.price}, 1, N'От организации {((BusinessTour)order.tour).organization}');");
            else
                Insert($"INSERT INTO Orders VALUES ({Counter.id}, {Counter.id}, {Counter.id}, '{sqlFormattedDate}', N'{order.tour.name}', {order.price}, 1, '');");


        }

        public void ClearAllInfo()
        {
            var command = new SqlCommand("TRUNCATE TABLE Orders; DELETE FROM Clients; DELETE FROM Tickets;", connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Базы данных были очищены.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
