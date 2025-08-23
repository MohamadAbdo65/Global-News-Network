using Connection_GlobalNewsNetwork;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_GlobalNewsNetwork
{
    public static class clsDataAdmins
    {

        //Code Of Find : 
        public static bool FindAdminsByUserID(ref System.Int32 AdminID,  System.Int32 UserID, 
            ref System.DateTime JoinDate, ref System.Int32 permissions_Binary)
        {
            bool IsFound = false;
            string Connection = clsConnectionSettings.ConnectionSettings;

            using (SqlConnection connection = new SqlConnection(Connection))
            {
                using (SqlCommand command = new SqlCommand("SP_Admins_FindBy", connection))
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
                                AdminID = (System.Int32)reader["AdminID"];
                                JoinDate = (System.DateTime)reader["JoinDate"];
                                permissions_Binary = (System.Int32)reader["permissions_Binary"];
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
        public static bool DeleteInAdminsByAdminID(System.Int32 AdminID)
        {
            int RowEffected = 0;
            string Connection = clsConnectionSettings.ConnectionSettings;
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                using (SqlCommand command = new SqlCommand("SP_Admins_Delete", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AdminID", AdminID);

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
