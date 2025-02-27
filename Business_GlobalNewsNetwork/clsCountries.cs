using System;
using System.Collections.Generic;
using System.Data;
using Data_GlobalNewsNetwork;

namespace Business_GlobalNewsNetwork
{
    public class clsCountries
    {
        public int CountryID { get;  }
        public string CountryName { get; }

        private clsCountries(int CountryID , string CountryName) 
        {
            
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }


        public static DataTable GetAllCountries()
        {
            return clsDataCountries.GetAllCountries();
        }

        public static clsCountries FindCountry(string CountryName)
        {
            int countryID = -1;

            if (clsDataCountries.FindCountriesByCountryName(ref countryID ,  CountryName))
            {
                return new clsCountries(countryID , CountryName);
            }
            return null;
        }

        public static clsCountries FindCountry(int CountryID)
        {
            string CountryName = "";

            if (clsDataCountries.FindCountriesByCountryID(CountryID, ref CountryName))
            {
                return new clsCountries(CountryID, CountryName);
            }
            return null;
        }

    }
}
