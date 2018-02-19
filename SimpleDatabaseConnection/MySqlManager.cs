using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace SimpleDatabaseConnection
{
    public class MySqlManager
    {
        private MySqlConnection connection;

        public bool IsConnected { get; private set; }
        public string ResponseMessage { get; private set; }

        public void ConnectToServer(string adress, string port, string database, string username, string password)
        {
            try
            {
                string connectionString = String.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};", adress, port, database, username, password);
                connection = new MySqlConnection(connectionString);
                IsConnected = true;
                ResponseMessage = "Connection successfull";
            }
            catch (MySqlException e)
            {
                Console.Write(e.Message);
                IsConnected = false;
                ResponseMessage = e.Message;
            } 
        }

        public List<List<string>> SqlCommand(string cmd)
        {
            if (connection == null)
            {
                ResponseMessage = "No server connection! Run 'ConnectToServer' before calling 'SqlCommand'!";
                return null;
            }

            MySqlCommand sql;
            MySqlDataReader reader;
            List<List<string>> response = new List<List<string>>();

            try
            {
                connection.Open();
                sql = new MySqlCommand(cmd, connection);
                reader = sql.ExecuteReader();

                while (reader.Read())
                {
                    List<string> fields = new List<string>();

                    for (int i = 0; i < reader.FieldCount; i++)
                        fields.Add(reader.GetString(i));

                    response.Add(fields);
                }
                ResponseMessage = "MySqlCommand successfully executed";
            }
            catch (MySqlException e)
            {
                Console.Write(e.Message);
                ResponseMessage = e.Message;
                return null;
            }

            connection.Close();
            return response;
        }
    }
}
