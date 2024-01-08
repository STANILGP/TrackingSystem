using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackingSystem.Storage;

namespace TrackingSystem.Services
{
    public class DataBaseHelper
    {
        public int SearchForIDEmployee(string nameOfEmnployee, SqlConnection sqlConnection, SqlCommand sqlcommand )
        {
            int returnID = 0;
            string Query = "Select * From Employee WHERE name= '" + nameOfEmnployee + "'";
            sqlcommand = new SqlCommand(Query, sqlConnection);
            using (SqlDataReader reader = sqlcommand.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        returnID = reader.GetInt32(reader.GetOrdinal("ID"));
                    }
                }
            }
            return returnID;
        }
        public int SearchForIDTask(string nameOfTask, SqlConnection sqlConnection, SqlCommand sqlcommand)
        {
            int returnID = 0;
            string Query = "Select * From Task WHERE name= '" + nameOfTask + "'";
            sqlcommand = new SqlCommand(Query, sqlConnection);
            using (SqlDataReader reader = sqlcommand.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        returnID = reader.GetInt32(reader.GetOrdinal("ID"));
                    }
                }
            }
            return returnID;
        }
    }
}
