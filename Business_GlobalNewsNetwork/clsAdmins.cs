using Data_GlobalNewsNetwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_GlobalNewsNetwork
{
    public class clsAdmins
    {
        enum enMode { AddMode, UpdateMode }
        enMode Mode;

        public System.Int32 AdminID { get; set; }
        public System.Int32 UserID { get; set; }
        public System.DateTime JoinDate { get; set; }
        public System.Int32 permissions_Binary { get; set; }


        public clsAdmins()
        {
            Mode = enMode.AddMode;

            this.AdminID = 0;
            this.UserID = 0;
            this.JoinDate = new DateTime(1900,1,1);
            this.permissions_Binary = 0;
        }

        private clsAdmins(System.Int32 AdminID, System.Int32 UserID, System.DateTime JoinDate, System.Int32 permissions_Binary)
        {
            Mode = enMode.UpdateMode;

            this.AdminID = AdminID;
            this.UserID = UserID;
            this.JoinDate = JoinDate;
            this.permissions_Binary = permissions_Binary;
        }


        public static clsAdmins FindByUserID(int UserID)
        {
            int AdminID = 0, Permissions = 0;
            DateTime JoinDate = new DateTime(1900, 1, 1);

            if(clsDataAdmins.FindAdminsByUserID(ref AdminID , UserID , ref JoinDate , ref Permissions))
            {
                return new clsAdmins(AdminID, UserID, JoinDate, Permissions);   
            }
            return null;
        }

 

    }
}
