using Data_GlobalNewsNetwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Business_GlobalNewsNetwork
{
    public class clsPeople
    {

        enum enMode { AddMode, UpdateMode }
        enMode Mode;

        public int PersonID                { get; set; }
        public System.String FirstName              { get; set; }
        public System.String LastName               { get; set; }
        public System.Boolean Gender                { get; set; }
        public System.DateTime DateOfBirth          { get; set; }
        public System.Int32 CountryID                { get; set; }
        public System.String Email                  { get; set; }
        public System.String Password               { get; set; }
        public System.String Image                  { get; set; }
        public System.DateTime DateOfCreateAccount { get; set; }
        public System.DateTime DateOfLastLogin     { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }
        public clsCountries CountryInfo { get; set; }
        public clsPeople()
        {
            Mode = enMode.AddMode;

            this.PersonID = 0;
            this.FirstName = string.Empty;
            this.LastName = string.Empty;
            this.Gender = false;
            this.DateOfBirth = DateTime.MinValue;
            this.CountryID = 0;
            this.Email = string.Empty;
            this.Password = string.Empty;
            this.Image = string.Empty;
            this.DateOfCreateAccount = DateTime.MinValue;
            this.DateOfLastLogin = DateTime.MinValue;
        }

        private clsPeople(System.Int32 PersonID, System.String FirstName, System.String LastName, System.Boolean Gender, System.DateTime DateOfBirth, System.Int32 CountryID, System.String Email, System.String Password, System.String Image, System.DateTime DateOfCreateAccount, System.DateTime DateOfLastLogin)
        {
            Mode = enMode.UpdateMode;

            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Gender = Gender;
            this.DateOfBirth = DateOfBirth;
            this.CountryID = CountryID;
            this.Email = Email;
            this.Password = Password;
            this.Image = Image;
            this.DateOfCreateAccount = DateOfCreateAccount;
            this.DateOfLastLogin = DateOfLastLogin;

            this.CountryInfo = clsCountries.FindCountry(CountryID);

        }

        public static bool EmailIsUsed(string Email)
        {
            return clsDataPeople.PeopleIsExistByEmail(Email);
        }

        public static bool UpdateLastLogin(int PersonID)
        {
            return false; // here method !
        }

        public bool UpdateLastLogin()
        {
            return UpdateLastLogin(this.PersonID);
        }

        private bool _AddNewPerson()
        {
            int InsertedID = -1;

            if(clsDataPeople.AddInPeople(ref InsertedID , FirstName , LastName , Gender , DateOfBirth ,
                CountryID , Email , Password , Image , DateOfCreateAccount , DateOfLastLogin))
            {
                this.PersonID = InsertedID;
                return true;
            }
            return false;
        }
        private bool _UpdatePerson()
        {
            return clsDataPeople.UpdateInPeople(PersonID, FirstName, LastName, Gender, DateOfBirth,
                CountryID, Email, Password, Image, DateOfCreateAccount, DateOfLastLogin);
        }

        public bool Save()
        {
            if(Mode == enMode.AddMode)
            {
                if(_AddNewPerson())
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
                return _UpdatePerson();
            }
            return false;
        }


        private static clsPeople FindByEmailAndPassword(string Email  , string Password)
        {
            System.Int32 PersonID = 1, CountryID = -1;
            System.String FirstName = "" , LastName = "", Image = "";
            System.Boolean Gender = false;
            System.DateTime DateOfBirth = new DateTime(1900,1,1), DateOfCreateAccount = new DateTime(1900, 1, 1), DateOfLastLogin = new  DateTime(1900, 1, 1);

            if (clsDataPeople.FindPeopleByEmailAndPassword(ref PersonID , ref FirstName, ref LastName , 
                ref Gender , ref DateOfBirth , ref CountryID , ref Email , ref  Password  , ref Image , 
                ref DateOfCreateAccount, ref DateOfLastLogin))
            {
                return new clsPeople(PersonID, FirstName, LastName, Gender, DateOfBirth, CountryID, Email, Password, Image, DateOfCreateAccount, DateOfLastLogin);
            }
            return null;
        }

        /// <summary>
        /// this method for log in the app
        /// </summary>
        /// <param name="J">return object of Journalist if he Journalist</param>
        /// <param name="A">return object of Admin if he Admin</param>
        /// <param name="T">return object of Thec if he Tech</param>
        /// <returns>Successful login = True | Failed login = False</returns>
        public static bool Login(string Email , string Password , 
            ref clsPeople P , ref clsUsers U,
            ref clsJournalists J , ref clsAdmins A , ref clsTechnicians T)
        {

            clsPeople Person = clsPeople.FindByEmailAndPassword(Email , Password);
            if (Person == null) { return  false; }


            clsUsers User = clsUsers.FindByPersonID(Person.PersonID);
            if (User == null) { return false; }



            int UserID = User.UserID;


            clsTechnicians Thecnecal = null;
            clsAdmins Admin = null;
            clsJournalists journalist = null;

            Parallel.Invoke(
            () => { Thecnecal  = clsTechnicians.FindByUserID(UserID); },
            () => { Admin      = clsAdmins     .FindByUserID(UserID); },
            () => { journalist = clsJournalists.FindByUserID(UserID); });

            P = Person;
            U = User;
            T = Thecnecal;
            A = Admin;
            J = journalist;

            return true;
        }


        public static clsPeople Find(int PersonID)
        {
            String FirstName = "";
            String LastName = "";
            Boolean Gender = false;
            DateTime DateOfBirth = DateTime.MinValue;
            Int32 CountryID = -1;
            String Email = "";
            String Password = "";
            String Image = "";
            DateTime DateOfCreateAccount = DateTime.MinValue;
            DateTime DateOfLastLogin = DateTime.MinValue;


            if (clsDataPeople.FindPeopleByPersonID(PersonID , ref FirstName , ref LastName , ref Gender , ref DateOfBirth , ref CountryID , ref Email ,ref  Password ,ref  Image ,ref  DateOfCreateAccount , ref DateOfLastLogin))
            {
                return new clsPeople(PersonID , FirstName , LastName, Gender , DateOfBirth , CountryID, Email , Password, Image , DateOfCreateAccount , DateOfLastLogin);
            }
            return null;
        }



    }
}
