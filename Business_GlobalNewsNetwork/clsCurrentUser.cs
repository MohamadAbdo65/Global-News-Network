

using Data_GlobalNewsNetwork;

namespace Business_GlobalNewsNetwork
{
    public static class clsCurrentUser
    {

        private static clsPeople _Person = null;
        public static clsPeople Person
        {
            get { return _Person; }
            set { _Person = value; }
        }

        //**

        private static clsUsers _User = null;
        public static clsUsers User
        {
            get { return _User; }
            set { _User = value; }
        }

        //**

        private static clsAdmins _Admin = null;
        public static clsAdmins Admin
        {
            get { return _Admin; }
            set { _Admin = value; }
        }

        //**

        private static clsTechnicians _Tech = null;
        public static clsTechnicians Technichal
        {
            get { return _Tech; }
            set { _Tech = value; }
        }

        //**    

        private static clsJournalists _Journalist = null;
        public static clsJournalists Journalist
        {
            get { return _Journalist; }
            set { _Journalist = value; }
        }


        public static void LogOut()
        {
            Person = null;
            User = null;
            Admin = null;
            Journalist = null;
            Technichal = null;
        }

        public static void LogIn(clsPeople P, clsUsers U, clsTechnicians T, clsAdmins A, clsJournalists J)
        {
            Person = P;
            User = U;
            Admin = A;
            Journalist = J;
            Technichal = T;
        }


        public static bool DeleteAccount()
        {
            int  A = -1,
                 J = -1,
                 T = -1,
                 U = -1,
                 P = -1;

            if (clsCurrentUser.Admin != null)
                A = clsCurrentUser.Admin.AdminID;

            if (clsCurrentUser.Journalist != null)
                J = clsCurrentUser.Journalist.JournalistsID;

            if (clsCurrentUser.Technichal != null)
                T = clsCurrentUser.Technichal.TechnicalID;

            if (clsCurrentUser.User != null)
                U = clsCurrentUser.User.UserID;

            if (clsCurrentUser.Person != null)
                P = clsCurrentUser.Person.PersonID;


            return clsDataUsers.DeleteDeleteUserWithRelationships(A , J , T , U , P);
        }

    }
}
