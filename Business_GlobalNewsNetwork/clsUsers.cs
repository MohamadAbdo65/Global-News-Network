using Data_GlobalNewsNetwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_GlobalNewsNetwork
{
    public class clsUsers
    {
        enum enMode { AddMode, UpdateMode }
        enMode Mode;

        public System.Int32 UserID { get; set; }
        public System.Int32 PersonID { get; set; }
        public System.Int32 Catagories_Binary { get; set; }

        public clsPeople PersonInfo { get; }
        

        public clsUsers()
        {
            Mode = enMode.AddMode;

            this.UserID = 0;
            this.PersonID = 0;
            this.Catagories_Binary = 0;
        }

        private clsUsers(System.Int32 UserID, System.Int32 PersonID, System.Int32 Catagories_Binary)
        {
            Mode = enMode.UpdateMode;

            this.UserID = UserID;
            this.PersonID = PersonID;
            this.Catagories_Binary = Catagories_Binary;

            PersonInfo = clsPeople.Find(PersonID);
        }


        public static bool CreateAccoutn(string FirstName , string LastName , bool Gender , DateTime DateOfBirth , 
            int CountryuID , string Email , string Password , string Image , int Categories )
        {

            clsPeople Person = new clsPeople();

            Person.FirstName = FirstName;
            Person.LastName = LastName;
            Person.Gender = Gender;
            Person.DateOfBirth = DateOfBirth;
            Person.CountryID = CountryuID;
            Person.Email = Email;
            Person.Password = Password;
            Person.Image = Image;
            Person.DateOfCreateAccount = DateTime.Now;
            Person.DateOfLastLogin = new DateTime(1900, 1, 1);

            if(!Person.Save())
                return false;


            // now we have Person ID
            // you can create User

            clsUsers User = new clsUsers();

            User.PersonID = Person.PersonID;
            User.Catagories_Binary = Categories;

            if(!User.Save())
                return false ;


            return true;
        }


        private bool _AddNewUser()
        {
            int InsertedID = -1;
            if(clsDataUsers.AddInUsers(ref InsertedID , PersonID , Catagories_Binary))
            {
                this.UserID = InsertedID;
                return true;
            }
            return false;
        }
        private bool _UpdateUser()
        {
            return clsDataUsers .UpdateInUsers(UserID , PersonID , Catagories_Binary);
        }

        public bool Save()
        {
            if (Mode == enMode.AddMode)
            {
                if (_AddNewUser())
                {
                    Mode = enMode.UpdateMode;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (Mode == enMode.UpdateMode)
            {

                return _UpdateUser();
            }
            return false;
        }

        public static clsUsers FindByPersonID(int PersonID)
        {
            int UserId = -1, Catagories_Binary = -1;

            if(clsDataUsers.FindUsersByPersonID(ref UserId , ref PersonID , ref Catagories_Binary))
            {
                return new clsUsers(UserId , PersonID , Catagories_Binary );
            }
            return null;
        }

        public static clsUsers FindByUserID(int UserID)
        {
            int PersonID = -1, Catagories_Binary = -1;

            if (clsDataUsers.FindUsersByUserID(UserID, ref PersonID, ref Catagories_Binary))
            {
                return new clsUsers(UserID, PersonID, Catagories_Binary);
            }
            return null;
        }



    }
}
