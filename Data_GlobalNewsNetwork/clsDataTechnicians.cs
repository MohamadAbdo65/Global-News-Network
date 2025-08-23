using Connection_GlobalNewsNetwork;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_GlobalNewsNetwork
{
    public static class clsDataTechnicians
    {
        //Code Of Find : 
        public static bool FindTechniciansByUserID(ref System.Int32 TechnicalID,  System.Int32 UserID,
            ref System.DateTime JoinDate, ref System.Int32 Permissions_Binary)
        {
            bool IsFound = false;
            string Connection = clsConnectionSettings.ConnectionSettings;

            using (SqlConnection connection = new SqlConnection(Connection))
            {
                using (SqlCommand command = new SqlCommand("SP_Technicians_FindByUserID", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", UserID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                TechnicalID = (System.Int32)reader["TechnicalID"];
                                JoinDate = (System.DateTime)reader["JoinDate"];
                                Permissions_Binary = (System.Int32)reader["Permissions_Binary"];
                                IsFound = true;
                            }
                        }
                    }
                    catch { }
                }
            }
            return IsFound;
        }

        //Code Of Delete : 
        public static bool DeleteInTechniciansByTechnicalID(System.Int32 TechnicalID)
        {
            int RowEffected = 0;
            string Connection = clsConnectionSettings.ConnectionSettings;

            using (SqlConnection connection = new SqlConnection(Connection))
            {
                using (SqlCommand command = new SqlCommand("SP_Technicians_Delete", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TechnicalID", TechnicalID);

                    try
                    {
                        connection.Open(); RowEffected = command.ExecuteNonQuery();
                    }
                    catch { }
                }
            }
            return (RowEffected > 0) ? true : false;
        }






    }
}
