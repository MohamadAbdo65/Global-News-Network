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
    public static class clsDataNews
    {

        //Code Of Get All : 
        public static DataTable GetAllNewsByCategories(int UserCategories , int PageNumber)
        {
            DataTable dataTable = new DataTable();
            string StConnection = clsConnectionSettings.ConnectionSettings;
            using (SqlConnection connection = new SqlConnection(StConnection))
            {
                using (SqlCommand command = new SqlCommand("SP_News_GetAllByUserCategory", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FavsUser", UserCategories);
                    command.Parameters.AddWithValue("@PageNumber", PageNumber);

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
        public static DataTable GetAllNewsByViews()
        {
            DataTable dataTable = new DataTable();
            string StConnection = clsConnectionSettings.ConnectionSettings;
            using (SqlConnection connection = new SqlConnection(StConnection))
            {
                using (SqlCommand command = new SqlCommand("SP_News_GetAllByViews", connection))
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

        //Code Of Get All : 
        public static DataTable GetAllNewsBySearch(string Text)
        {
            DataTable dataTable = new DataTable();
            string StConnection = clsConnectionSettings.ConnectionSettings;
            using (SqlConnection connection = new SqlConnection(StConnection))
            {
                using (SqlCommand command = new SqlCommand("SP_News_GetAllBySearch", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Text", Text);

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


        //Code Of Insert : 
        public static bool AddInNews(ref System.Int32 NewsID, System.Int32 JournalistID, System.String NewsTitle,
            System.String NewsContent, System.Int32 NewsCatagories_Binary, System.Int32 CountryID, 
            System.DateTime PublishDateTime, System.String Image, System.Int32 CountView)   
        {
            bool IsAdded = false;

            string connectionString = clsConnectionSettings.ConnectionSettings;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_News_Insert", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@JournalistID", JournalistID);
                    command.Parameters.AddWithValue("@NewsTitle", NewsTitle);
                    command.Parameters.AddWithValue("@NewsContent", NewsContent);
                    command.Parameters.AddWithValue("@NewsCatagories_Binary", NewsCatagories_Binary);
                    command.Parameters.AddWithValue("@CountryID", CountryID);
                    command.Parameters.AddWithValue("@PublishDateTime", PublishDateTime);
                    command.Parameters.AddWithValue("@Image", Image);
                    command.Parameters.AddWithValue("@CountView", CountView);


                    SqlParameter outputIdParam = new SqlParameter("@NewsID", SqlDbType.Int) { Direction = ParameterDirection.Output };

                    command.Parameters.Add(outputIdParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        NewsID = (int)command.Parameters["@NewsID"].Value;
                        IsAdded = true;
                    }
                    catch { }
                }
            }
            return IsAdded;
        }


        //Code Of Update : 
        public static bool UpdateInNews(System.Int32 NewsID, System.Int32 JournalistID, 
            System.String NewsTitle, System.String NewsContent, System.Int32 NewsCatagories_Binary,
            System.Int32 CountryID, System.DateTime PublishDateTime, System.String Image, System.Int32 CountView)
        {
            short RowEffected = 0;

            string connectionString = clsConnectionSettings.ConnectionSettings;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_News_Update", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@NewsID", NewsID);
                    command.Parameters.AddWithValue("@JournalistID", JournalistID);
                    command.Parameters.AddWithValue("@NewsTitle", NewsTitle);
                    command.Parameters.AddWithValue("@NewsContent", NewsContent);
                    command.Parameters.AddWithValue("@NewsCatagories_Binary", NewsCatagories_Binary);
                    command.Parameters.AddWithValue("@CountryID", CountryID);
                    command.Parameters.AddWithValue("@PublishDateTime", PublishDateTime);
                    command.Parameters.AddWithValue("@Image", Image);
                    command.Parameters.AddWithValue("@CountView", CountView);


                    try
                    {
                        connection.Open();
                        RowEffected = (short)command.ExecuteNonQuery();
                    }
                    catch { }
                }
            }
            return (RowEffected > 0) ? true : false;
        }



        // code of count view : 
        public static bool CountView(int NewsID)
        {
            short RowEffected = 0;

            string connectionString = clsConnectionSettings.ConnectionSettings;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_NEWS_CountView", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@NewsID", NewsID);
                   
                    try
                    {
                        connection.Open();
                        RowEffected = (short)command.ExecuteNonQuery();
                    }
                    catch { }
                }
            }
            return (RowEffected > 0) ? true : false;
        }



    }
}
