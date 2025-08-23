using Connection_GlobalNewsNetwork;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_GlobalNewsNetwork
{
    public static class clsDataCatagories
    {

        //Code Of Get All : 
        public static DataTable GetAllCategories()
        {
            DataTable dataTable = new DataTable();
            string StConnection = clsConnectionSettings.ConnectionSettings;

            using (SqlConnection connection = new SqlConnection(StConnection))
            {
                using (SqlCommand command = new SqlCommand("SP_Categories_GetAll", connection))
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
                }
            }
            return dataTable;
        }


        //Code Of Find : 
        public static bool FindCategoriesByCategoryID( System.Int32 CategoryID, ref System.String CategoryName, 
            ref System.Int32 Category_BinaryN, ref System.String ImagePath)
        {
            bool IsFound = false;
            string Connection = clsConnectionSettings.ConnectionSettings;

            using (SqlConnection connection = new SqlConnection(Connection))
            {
                using (SqlCommand command = new SqlCommand("SP_Categories_FindByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CategoryID", CategoryID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                CategoryName = (System.String)reader["CategoryName"];
                                Category_BinaryN = (System.Int32)reader["Category_BinaryN"];
                                ImagePath = (System.String)reader["ImagePath"];
                                IsFound = true;
                            }
                        }
                    }
                    catch { }
                }
            }
            return IsFound;
        }


        //Code Of Get All : 
        public static DataTable GetAllCategoriesUserFavorites(int UserCategories)
        {
            DataTable dataTable = new DataTable();
            string StConnection = clsConnectionSettings.ConnectionSettings;
            using (SqlConnection connection = new SqlConnection(StConnection))
            {
                using (SqlCommand command = new SqlCommand("SP_Categories_GetAllForUser", connection))
                {
                    command.CommandType=CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FavsUser", UserCategories);

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

        //Code Of Get All : 
        public static DataTable GetAllCategoriesUserUnfavorite(int UserCategories)
        {
            DataTable dataTable = new DataTable();
            string StConnection = clsConnectionSettings.ConnectionSettings;
            using (SqlConnection connection = new SqlConnection(StConnection))
            {
                using (SqlCommand command = new SqlCommand("SP_Categories_GetAll_OtherCategories", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FavsUser", UserCategories);

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
