using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.API.Test.Data.Queries.Gardiner
{
    public class PLSAAvailableFunds : DBConnect
    {
        public enum ControlCode { APGARDINER, APREAD, APFTC, APFES, APWVHOPE }
        public enum ProgramCode { Gardiner, Reading, FTC, FES, WVHOPE }

        public async Task GetStudentWithAvailableFunds()
        {
            // Specify the path to your SQL file
            string sqlFilePath = "C:\\Users\\mpajaro\\DevTools\\Foundation-QA\\AutomationFramework\\AutomationFramework.API.Test\\Data\\Queries\\Gardiner\\PLSA Available funds - EPICOR.sql";

            //// Read the SQL file
            string sqlContent = File.ReadAllText(sqlFilePath);
            var cmd = new SqlCommand
            {
                CommandText = sqlContent
            };
            cmd.Parameters.AddWithValue("@GLControlCode", ControlCode.APGARDINER);
            cmd.Parameters.AddWithValue("@ProgramCode", ProgramCode.Gardiner);
            cmd.Parameters.AddWithValue("@StudentId", "4");

            var reader = await Query(Server.EPICOR, cmd);

            while (await reader.ReadAsync())
            {
                var id = reader.GetString(0);
                var name = reader.GetString(1);
            }
        }

    }
}
