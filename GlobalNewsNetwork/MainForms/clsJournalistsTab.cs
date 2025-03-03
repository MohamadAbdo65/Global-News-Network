using Business_GlobalNewsNetwork;
using GlobalNewsNetwork.UserCTRls.Journalists;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalNewsNetwork.MainForms
{
    // JournalistsTab : 
    public partial class frmHomePage
    { 

        private void _LoadJournalistsTab()
        {
            _LoadJournalists();
        }

        private void _LoadJournalists()
        {

            DataTable Journalists = clsJournalists.GetAllJournalists();


            foreach (DataRow J in Journalists.Rows) 
            {

                clsJournalists journalist = new clsJournalists();

                journalist.JournalistsID = (int)J["JournalistsID"];
                journalist.UserID = (int)J["UserID"];
                journalist.NewsAgencyID = (J["NewsAgencyID"] == DBNull.Value) ? -1: (int)J["NewsAgencyID"];
                journalist.YearsExp = (byte)J["YearsExp"];

                journalist.Mode = clsJournalists.enMode.UpdateMode;

                ctrlJournalistsInterface ctrlJournalists = new ctrlJournalistsInterface();
                ctrlJournalists.LoadJournalistData(journalist);

                flpJournalists.Controls.Add(ctrlJournalists);

            }
        }

    }
}
