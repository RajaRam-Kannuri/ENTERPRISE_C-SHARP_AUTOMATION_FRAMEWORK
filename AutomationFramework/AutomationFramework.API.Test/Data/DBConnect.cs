using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.API.Test.Data
{
    public class DBConnect
    {
        public enum Server
        {
            SUFS,
            PLSA,
            EPICOR
        }

        private const string ConnectionString = "Data Source=.;Initial Catalog={0};User ID=JenkinsQA_SQLUser;password=sdenGD-34!snY;Integrated Security=false;Server={1}; Database={2};Pooling=true;";

        public async Task<SqlDataReader> Query(Server server, SqlCommand sqlCmd)
        {
            SqlDataReader tableResults;
            var connectionString = GetConnectionString(server);
            using (var sqlCon = new SqlConnection(connectionString))
            {
                await sqlCon.OpenAsync();
                using (sqlCmd)
                {
                    sqlCmd.Connection = sqlCon;
                    sqlCmd.CommandTimeout = 60;
                    tableResults = await sqlCmd.ExecuteReaderAsync();
                }

            }
            return tableResults;
        }

        public async Task<SqlDataReader> Query(Server server, string sqlCmd)
        {
            SqlDataReader tableResults;
            var connectionString = GetConnectionString(server);
            using (var sqlCon = new SqlConnection(connectionString))
            {
                await sqlCon.OpenAsync();
                using (var cmd = sqlCon.CreateCommand())
                {
                    cmd.CommandText = sqlCmd;
                    cmd.CommandTimeout = 60;
                    tableResults = await cmd.ExecuteReaderAsync();
                }
            }
            return tableResults;
        }

        public async Task<string> Query(Server server, string sqlCmd, int row, string column)
        {
            var reader = await Query(server, sqlCmd);
            var tableValue = "";
            int counter = 1;
            while (await reader.ReadAsync())
            {
                tableValue = reader[column].ToString();

                if (counter == row)
                    break;

                counter++;

                //break loop if number of iterations exceeds 100 - will use value of 100th row
                if (counter > 100)
                    break;
            }
            return tableValue;
        }

        

        private string GetConnectionString(Server server)
        {
            var environment = ConfigurationManager.AppSettings["Environment"];
            string serverName;
            switch (server)
            {
                case Server.SUFS:
                    serverName = ConfigurationManager.AppSettings[$"DB_{environment}"];
                    return string.Format(ConnectionString, "", serverName, "SUFS");
                case Server.PLSA:
                    serverName = ConfigurationManager.AppSettings[$"DB_{environment}"];
                    return string.Format(ConnectionString, "", serverName, "PLSA");
                case Server.EPICOR:
                    serverName = ConfigurationManager.AppSettings[$"EPICOR_{environment}"];
                    return string.Format(ConnectionString, "SUFS", serverName, "EpicorERP");
                default:
                    return string.Format(ConnectionString, "", "dev-sqlc1n1\\test", "SUFS");
            }            
        }

    }
}
