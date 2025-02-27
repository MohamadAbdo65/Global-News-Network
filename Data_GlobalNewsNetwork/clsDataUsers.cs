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
    public static class clsDataUsers
    {

        //Code Of Insert : 
        public static bool AddInUsers(ref System.Int32 UserID, System.Int32 PersonID, System.Int32 Catagories_Binary)
        {
            bool IsAdded = false;

            string connectionString = clsConnectionSettings.ConnectionSettings;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_Users_Insert", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@Catagories_Binary", Catagories_Binary);


                    SqlParameter outputIdParam = new SqlParameter("@UserID", SqlDbType.Int) { Direction = ParameterDirection.Output };

                    command.Parameters.Add(outputIdParam);

                    try
                    {

                        connection.Open();
                        command.ExecuteNonQuery();
                        UserID = (int)command.Parameters["@UserID"].Value;
                        IsAdded = true;
                    }
                    catch { }
                }
            }
            return IsAdded;
        }


        //Code Of Update : 
        public static bool UpdateInUsers(System.Int32 UserID, System.Int32 PersonID, System.Int32 Catagories_Binary)
        {
            short RowEffected = 0;

            string connectionString = clsConnectionSettings.ConnectionSettings;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_Users_Update", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@Catagories_Binary", Catagories_Binary);


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


        //Code Of Get All : 
        public static DataTable GetAllUsers()
        {
            DataTable dataTable = new DataTable();
            string StConnection = clsConnectionSettings.ConnectionSettings;
            using (SqlConnection connection = new SqlConnection(StConnection))
            {
                using (SqlCommand command = new SqlCommand("SP_Users_GetAll", connection))
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
        public static bool FindUsersByPersonID(ref System.Int32 UserID, ref System.Int32 PersonID, ref System.Int32 Catagories_Binary)
        {
            bool IsFound = false;
            string Connection = clsConnectionSettings.ConnectionSettings;

            using (SqlConnection connection = new SqlConnection(Connection))
            {
                using (SqlCommand command = new SqlCommand("SP_Users_FindByPersonID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                UserID = (System.Int32)reader["UserID"];
                                Catagories_Binary = (System.Int32)reader["Catagories_Binary"];
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
        public static bool FindUsersByUserID( System.Int32 UserID, ref System.Int32 PersonID, ref System.Int32 Catagories_Binary)
        {
            bool IsFound = false;
            string Connection = clsConnectionSettings.ConnectionSettings;

            using (SqlConnection connection = new SqlConnection(Connection))
            {
                using (SqlCommand command = new SqlCommand("SP_Users_FindByUserID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", UserID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                PersonID = (System.Int32)reader["PersonID"];
                                Catagories_Binary = (System.Int32)reader["Catagories_Binary"];
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
        public static bool DeleteDeleteUserWithRelationships(int AdminID = -1, int Journalist = -1 ,
            int TechnichalID = -1, int UserID = - 1, int PersonID = -1)
        {
            bool isSuccess = false;
            string Connection = clsConnectionSettings.ConnectionSettings;

            using (SqlConnection connection = new SqlConnection(Connection))
            {
                using (SqlCommand command = new SqlCommand("SP_DeleteUser_WithRelationships", connection))
                {
                    command.CommandType= CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@IAdminID", AdminID );
                    command.Parameters.AddWithValue("@IJournalistID", Journalist );
                    command.Parameters.AddWithValue("@ITechnichalID", TechnichalID );
                    command.Parameters.AddWithValue("@IUserID", UserID);
                    command.Parameters.AddWithValue("@IPersonID", PersonID );

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        isSuccess = result != null && Convert.ToInt32(result) == 1;
                    }
                    catch { }
                }
            }
            return isSuccess;
        }







    }
}
