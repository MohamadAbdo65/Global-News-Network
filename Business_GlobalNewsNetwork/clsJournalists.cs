using Data_GlobalNewsNetwork;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_GlobalNewsNetwork
{
    public class clsJournalists
    {

        public enum enMode { AddMode, UpdateMode }
        public enMode Mode;

        public System.Int32 JournalistsID     { get; set; }
        public System.Int32 UserID            { get; set; }
        public int? NewsAgencyID              { get; set; }
        public System.Byte YearsExp           { get; set; }

        public string JournalistFullName
        {
            get
            {
                string AgencyName = (NewsAgencyID == null) ? "مستقل" : "اسم الوكالة";
                return UserInfo.PersonInfo.FullName + " - " + AgencyName;
            }
        }

        public clsUsers UserInfo { get;  }


        public clsJournalists()
        {
            Mode = enMode.AddMode;

            this.JournalistsID = 0;
            this.UserID = 0;
            this.NewsAgencyID = 0;
            this.YearsExp = 0;
        }

        private clsJournalists(System.Int32 JournalistsID, System.Int32 UserID, 
            System.Int32? NewsAgencyID, System.Int32 Catagories_Binary, System.Byte YearsExp)
        {
            Mode = enMode.UpdateMode;

            this.JournalistsID = JournalistsID;
            this.UserID = UserID;
            this.NewsAgencyID = NewsAgencyID;
            this.YearsExp = YearsExp;


            UserInfo = clsUsers.FindByUserID(UserID);
        }


        public static clsJournalists FindByUserID(int UserID)
        {
            int JournalistsID = 0, Catagories_Binary = 0;
            int? NewsAgencyID = null;
            byte YearsExp = 0;

            if(clsDataJournalists.FindJournalistsByUserID(ref JournalistsID , UserID , ref NewsAgencyID , ref Catagories_Binary , ref YearsExp))
            {
                return new clsJournalists(JournalistsID , UserID , NewsAgencyID , Catagories_Binary , YearsExp);
            }
            return null;
        }

        public static clsJournalists FindByJournalistID(int JournalistID)
        {
            System.Int32 UserID = 0;
            int? NewsAgencyID = null;
            System.Int32 Catagories_Binary = 0;
            System.Byte YearsExp = 0;

            if (clsDataJournalists.FindJournalistsByJournalistsID(JournalistID , ref UserID , ref NewsAgencyID , ref YearsExp))
            {
                return new clsJournalists(JournalistID , UserID , NewsAgencyID , Catagories_Binary , YearsExp);
            }
            return null;
        }

        public static DataTable GetAllJournalists()
        {
            return clsDataJournalists.GetAllJournalists();
        }

    }
}
