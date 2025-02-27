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
    public static class clsDataPeople
    {

        //Code Of Insert : 
        public static bool AddInPeople(ref System.Int32 PersonID, System.String FirstName, System.String LastName, System.Boolean Gender, System.DateTime DateOfBirth, System.Int32 CountryID, System.String Email, System.String Password, System.String Image, System.DateTime DateOfCreateAccount, System.DateTime DateOfLastLogin)
        {
            bool IsAdded = false;

            string connectionString = clsConnectionSettings.ConnectionSettings;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_People_Insert", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@CountryID", CountryID);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@Image", Image);
                    command.Parameters.AddWithValue("@DateOfCreateAccount", DateOfCreateAccount);
                    command.Parameters.AddWithValue("@DateOfLastLogin", DateOfLastLogin);


                    SqlParameter outputIdParam = new SqlParameter("@PersonID", SqlDbType.Int) { Direction = ParameterDirection.Output };

                    command.Parameters.Add(outputIdParam);

                    try
                    {

                        connection.Open();
                        command.ExecuteNonQuery();
                        PersonID = (int)command.Parameters["@PersonID"].Value;
                        IsAdded = true;
                    }
                    catch { }
                }
            }
            return IsAdded;
        }


        //Code Of Update : 
        public static bool UpdateInPeople(System.Int32 PersonID, System.String FirstName, System.String LastName, System.Boolean Gender, System.DateTime DateOfBirth, System.Int32 CountryID, System.String Email, System.String Password, System.String Image, System.DateTime DateOfCreateAccount, System.DateTime DateOfLastLogin)
        {
            short RowEffected = 0;

            string connectionString = clsConnectionSettings.ConnectionSettings;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_People_Update", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@CountryID", CountryID);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@Image", Image);
                    command.Parameters.AddWithValue("@DateOfCreateAccount", DateOfCreateAccount);
                    command.Parameters.AddWithValue("@DateOfLastLogin", DateOfLastLogin);


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
        public static DataTable GetAllPeople()
        {
            DataTable dataTable = new DataTable();
            string StConnection = clsConnectionSettings.ConnectionSettings;
            using (SqlConnection connection = new SqlConnection(StConnection))
            {
                using (SqlCommand command = new SqlCommand("SP_People_GetAll", connection))
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
        public static bool FindPeopleByPersonID( System.Int32 PersonID, ref System.String FirstName,
            ref System.String LastName, ref System.Boolean Gender, ref System.DateTime DateOfBirth,
            ref System.Int32 CountryID, ref System.String Email, ref System.String Password, ref System.String Image,
            ref System.DateTime DateOfCreateAccount, ref System.DateTime DateOfLastLogin)
        {
            bool IsFound = false;
            string Connection = clsConnectionSettings.ConnectionSettings;

            using (SqlConnection connection = new SqlConnection(Connection))
            {
                using (SqlCommand command = new SqlCommand("SP_People_FindByID", connection))
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
                                FirstName = (System.String)reader["FirstName"];
                                LastName = (System.String)reader["LastName"];
                                Gender = (System.Boolean)reader["Gender"];
                                DateOfBirth = (System.DateTime)reader["DateOfBirth"];
                                CountryID = (System.Int32)reader["CountryID"];
                                Email = (System.String)reader["Email"];
                                Password = (System.String)reader["Password"];
                                try { Image = (System.String)reader["Image"]; } catch { }
                                DateOfCreateAccount = (System.DateTime)reader["DateOfCreateAccount"];
                                DateOfLastLogin = (System.DateTime)reader["DateOfLastLogin"];
                                IsFound = true;
                            }
                        }
                    }
                    catch { }
                }
            }
            return IsFound;
        }


        //Code Of Is Exist : 
        public static bool PeopleIsExistByEmail(System.String Email)
        {
            bool IsFound = false;
            string Connection = clsConnectionSettings.ConnectionSettings;
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                using (SqlCommand command = new SqlCommand("SP_People_IsExist", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Email", Email);

                    try
                    {
                        connection.Open();
                        IsFound = (command.ExecuteScalar().ToString() == "1") ? true : false;
                    }
                    catch { }
                }
            }
            return IsFound;
        }


        //Code Of Find : 
        public static bool FindPeopleByEmailAndPassword(ref System.Int32 PersonID, ref System.String FirstName, 
            ref System.String LastName, ref System.Boolean Gender, ref System.DateTime DateOfBirth, 
            ref System.Int32 CountryID, ref System.String Email, ref System.String Password, ref System.String Image,
            ref System.DateTime DateOfCreateAccount, ref System.DateTime DateOfLastLogin)
        {
            bool IsFound = false;
            string Connection = clsConnectionSettings.ConnectionSettings;

            using (SqlConnection connection = new SqlConnection(Connection))
            {
                using (SqlCommand command = new SqlCommand("SP_People_FindByEmailAndPassword", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Password", Password);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                PersonID = (int)reader["PersonID"];
                                FirstName = (System.String)reader["FirstName"];
                                LastName = (System.String)reader["LastName"];
                                Gender = (System.Boolean)reader["Gender"];
                                DateOfBirth = (System.DateTime)reader["DateOfBirth"];
                                CountryID = (System.Int32)reader["CountryID"];
                                Image = (System.String)reader["Image"];
                                DateOfCreateAccount = (System.DateTime)reader["DateOfCreateAccount"];
                                DateOfLastLogin = (System.DateTime)reader["DateOfLastLogin"];
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
        public static bool DeleteInPeopleByPersonID(System.Int32 PersonID)
        {
            int RowEffected = 0;
            string Connection = clsConnectionSettings.ConnectionSettings;
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                // fix SP name
                using (SqlCommand command = new SqlCommand("SP_People_DeleteByID", connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);

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
