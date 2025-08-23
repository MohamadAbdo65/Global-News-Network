using Data_GlobalNewsNetwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_GlobalNewsNetwork
{
    public class clsTechnicians
    {
        enum enMode { AddMode, UpdateMode }
        enMode Mode;

        public System.Int32 TechnicalID { get; set; }
        public System.Int32 UserID { get; set; }
        public System.DateTime JoinDate { get; set; }
        public System.Int32 Permissions_Binary { get; set; }


        public clsTechnicians()
        {
            Mode = enMode.AddMode;

            this.TechnicalID = 0;
            this.UserID = 0;
            this.JoinDate = new DateTime(1900,1,1);
            this.Permissions_Binary = 0;
        }

        private clsTechnicians(System.Int32 TechnicalID, System.Int32 UserID,
            System.DateTime JoinDate, System.Int32 Permissions_Binary)
        {
            this.TechnicalID = TechnicalID;
            this.UserID = UserID;
            this.JoinDate = JoinDate;
            this.Permissions_Binary = Permissions_Binary;

            Mode = enMode.UpdateMode;
        }


        public static clsTechnicians FindByUserID(int UserID)
        {
            int TechID = 0, Permissions_Binary = 0;
            DateTime JoinDate = new DateTime(1900,1,1);

            if(clsDataTechnicians.FindTechniciansByUserID(ref TechID , UserID , ref JoinDate , ref Permissions_Binary))
            {
                return new clsTechnicians(TechID , UserID , JoinDate , Permissions_Binary);
            }
            return null;
        }

    }
}
