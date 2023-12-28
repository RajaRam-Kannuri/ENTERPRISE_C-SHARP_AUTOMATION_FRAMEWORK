using System.Data.SqlClient;

namespace Database
{
    public class DatabaseConnection
    {

        SqlConnection connection;

        private SqlConnection InitiliseConnection(string databaseName)
        {
            string Connectionstring = @"";
            connection = new SqlConnection(Connectionstring);
            connection.Open();
            return connection;
        }

        private string GetSQLValue(string sqlQuery, int columnID)
        {
            string value = "";
            SqlCommand cmd = new(sqlQuery, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                value = reader.GetValue(columnID).ToString();
            }
            return value;

        }

        private void UpdateSQLValue(string sqlQuery)
        {
            SqlDataAdapter adapter = new()
            {
                InsertCommand = new SqlCommand(sqlQuery, connection)
            };
            adapter.InsertCommand.ExecuteNonQuery();
        }

        public void KillConnection()
        {
            connection.Close();
        }
        public string GetDataFromCell(string databaseName, string sqlQuery, int coloumnID)
        {
            string value;

            InitiliseConnection(databaseName);
            value = GetSQLValue(sqlQuery, coloumnID);
            KillConnection();
            return value;
        }

        public void SendDataToDatabase(string databaseName, string sqlQuery)
        {
            InitiliseConnection(databaseName);
            UpdateSQLValue(sqlQuery);
            KillConnection();
        }
    }
}