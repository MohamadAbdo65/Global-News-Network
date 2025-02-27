using Connection_GlobalNewsNetwork;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_GlobalNewsNetwork
{
    public static class clsDataJournalists
    {

        //Code Of Find : 
        public static bool FindJournalistsByUserID(ref System.Int32 JournalistsID,  System.Int32 UserID,
            ref System.Int32? NewsAgencyID, ref System.Int32 Catagories_Binary, ref System.Byte YearsExp)
        {
            bool IsFound = false;
            string Connection = clsConnectionSettings.ConnectionSettings;

            using (SqlConnection connection = new SqlConnection(Connection))
            {
                using (SqlCommand command = new SqlCommand("SP_Journalists_FindByUserID", connection))
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
                                JournalistsID = (System.Int32)reader["JournalistsID"];
                                NewsAgencyID = (System.Int32)reader["NewsAgencyID"];
                                Catagories_Binary = (System.Int32)reader["Catagories_Binary"];
                                YearsExp = (System.Byte)reader["YearsExp"];
                                IsFound = true;
                            }
                        }
                    }
                    catch { }
                }
            }
            return IsFound;
        }

        //Code Of Find : 
        public static bool FindJournalistsByJournalistsID( System.Int32 JournalistsID, ref System.Int32 UserID, 
            ref System.Int32? NewsAgencyID,  ref System.Byte YearsExp)
        {
            bool IsFound = false;
            string Connection = clsConnectionSettings.ConnectionSettings;

            using (SqlConnection connection = new SqlConnection(Connection))
            {
                using (SqlCommand command = new SqlCommand("SP_Journalists_FindByJournalistID", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@JournalistsID", JournalistsID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                UserID = (System.Int32)reader["UserID"];
                                NewsAgencyID = (reader["NewsAgencyID"] == DBNull.Value) ? (int?)null : (System.Int32?)reader["NewsAgencyID"];
                                YearsExp = (System.Byte)reader["YearsExp"];
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
        public static bool DeleteInJournalistsByJournalistsID(System.Int32 JournalistsID)
        {
            int RowEffected = 0;
            string Connection = clsConnectionSettings.ConnectionSettings;
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                using (SqlCommand command = new SqlCommand("SP_Journalists_Delete", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@JournalistsID", JournalistsID);

                    try
                    {
                        connection.Open(); RowEffected = command.ExecuteNonQuery();
                    }
                    catch { }
                }
            }
            return (RowEffected > 0) ? true : false;
        }


        //Code Of Get All : 
        public static DataTable GetAllJournalists()
        {
            DataTable dataTable = new DataTable();
            string StConnection = clsConnectionSettings.ConnectionSettings;
            using (SqlConnection connection = new SqlConnection(StConnection))
            {
                using (SqlCommand command = new SqlCommand("SP_Journalists_GetAll", connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            { dataTable.Load(reader); }
                            reader.Close();
                        }
                    }
                    catch { }
                }
            }
            return dataTable;
        }




    }
}
