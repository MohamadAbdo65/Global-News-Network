using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Connection_GlobalNewsNetwork;

namespace Data_GlobalNewsNetwork
{
    public static class clsDataCountries
    {
        //Code Of Get All : 
        public static DataTable GetAllCountries()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnectionSettings.ConnectionSettings))
            {
                using (SqlCommand command = new SqlCommand("SP_Countries_GetAll", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

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
                    finally { connection.Close(); }
                }
            }
            return dataTable;
        }

        //Code Of Find : 
        public static bool FindCountriesByCountryName(ref System.Int32 CountryID,  System.String CountryName)
        {
            bool IsFound = false;
            string Connection = clsConnectionSettings.ConnectionSettings;

            using (SqlConnection connection = new SqlConnection(Connection))
            {
                using (SqlCommand command = new SqlCommand("SP_Countries_FindBy", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CountryName", CountryName);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                CountryID = (int)reader["CountryID"];
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
        public static bool FindCountriesByCountryID( System.Int32 CountryID, ref System.String CountryName)
        {
            bool IsFound = false;
            string Connection = clsConnectionSettings.ConnectionSettings;

            using (SqlConnection connection = new SqlConnection(Connection))
            {
                using (SqlCommand command = new SqlCommand("SP_Countries_FindByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CountryID", CountryID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                CountryName = (System.String)reader["CountryName"];
                                IsFound = true;
                            }
                        }
                    }
                    catch { }
                }
            }
            return IsFound;
        }





    }
}
