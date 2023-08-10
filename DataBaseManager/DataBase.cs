using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseManager
{
    internal class DataBase
    {
        public string ConnectionServer { get; set; } = "localhost";
        public string ConnectionString { get; private set; }
        public SqlDataAdapter sAdapter { get; private set; }
        public SqlCommand sCommand { get; private set; }
        public SqlCommandBuilder sBuilder { get; private set; }
        public DataSet sDs { get; private set; }
        public DataTable sTable { get; private set; }
        string databaseName = "master";
        public DataBase(string ConnectionServer)
        {
            this.ConnectionServer = ConnectionServer;
            ConnectionString = $"Server={ConnectionServer};Database={databaseName};Trusted_Connection=True;";
        }
        public bool CheckConnect()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                }
                return true;
            }
            catch
            {
                return false;
            }

        }
        public List<string> GetDatabaseNames()
        {
            List<string> databaseNames = new List<string>();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT * FROM sys.databases", connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            databaseNames.Add(reader.GetString(0));
                        }
                    }
                }
            }
            return databaseNames;
        }
        public List<string> GetTableNames(string databaseName)
        {
            ConnectionString = $"Server={ConnectionServer};Database={databaseName};Trusted_Connection=True;";
            List<string> tableNames = new List<string>();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"USE [{databaseName}] SELECT name FROM sys.Tables ", connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            tableNames.Add(reader.GetString(0));
                        }
                    }
                }
            }
            return tableNames;
        }
        public void GetTableContent(string databaseName, string tableName)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            sCommand = new SqlCommand($"SELECT * FROM [{tableName}]", connection);
            sAdapter = new SqlDataAdapter(sCommand);
            sBuilder = new SqlCommandBuilder(sAdapter);
            sDs = new DataSet();
            sAdapter.Fill(sDs, $"[{tableName}]");
            sTable = sDs.Tables[$"[{tableName}]"];
            connection.Close();
        }
        public void ExecuteSqlQuery(string sql, out int countRowAffected)
        {
            countRowAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    countRowAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
