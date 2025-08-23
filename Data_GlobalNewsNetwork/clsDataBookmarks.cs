using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connection_GlobalNewsNetwork;

namespace Data_GlobalNewsNetwork
{
    public static class clsDataBookmarks
    {

        //Code Of Insert : 
        public static bool AddInBookmarks(ref System.Int32 BookmarkID, System.Int32 UserID,
            System.Int32 NewsID, System.DateTime SaveDate)
        {
            bool IsAdded = false;

            string connectionString = clsConnectionSettings.ConnectionSettings;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_Bookmarks_Insert", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@NewsID", NewsID);
                    command.Parameters.AddWithValue("@SaveDate", SaveDate);


                    SqlParameter outputIdParam = new SqlParameter("@BookmarkID", SqlDbType.Int) { Direction = ParameterDirection.Output };

                    command.Parameters.Add(outputIdParam);

                    try
                    {

                        connection.Open();
                        command.ExecuteNonQuery();
                        BookmarkID = (int)command.Parameters["@BookmarkID"].Value;
                        IsAdded = true;
                    }
                    catch { }
                }
            }
            return IsAdded;
        }


        //Code Of Get All : 
        public static DataTable GetAllBookmarksForUser(int UserID)
        {
            DataTable dataTable = new DataTable();
            string StConnection = clsConnectionSettings.ConnectionSettings;
            using (SqlConnection connection = new SqlConnection(StConnection))
            {
                using (SqlCommand command = new SqlCommand("SP_Bookmarks_GetAllForUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserID", UserID);

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


        //Code Of Delete : 
        public static bool DeleteInBookmarksByUserID(int UserID , int NewsID)
        {
            int RowEffected = 0;
            string Connection = clsConnectionSettings.ConnectionSettings;
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                using (SqlCommand command = new SqlCommand("SP_Bookmarks_Delete", connection))
                {
                    command.CommandType=CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@NewsID", NewsID);

                    try
                    {
                        connection.Open(); RowEffected = command.ExecuteNonQuery();
                    }
                    catch { }
                }
            }
            return (RowEffected > 0) ? true : false;
        }


        //Code Of Is Exist : 
        public static bool BookmarksIsExistByUserID(System.Int32 UserID , int NewsID)
        {
            bool IsFound = false;
            string Connection = clsConnectionSettings.ConnectionSettings;
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                using (SqlCommand command = new SqlCommand("SP_Bookmarks_IsExist", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@NewsID", NewsID);

                    try
                    {
                        connection.Open();
                        IsFound = ((int)command.ExecuteScalar() == 1) ? true : false;
                    }
                    catch { }
                }
            }
            return IsFound;
        }






    }
}
