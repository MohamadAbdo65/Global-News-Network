using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection_GlobalNewsNetwork
{
    public static class clsConnectionSettings
    {
        //public static string ConnectionSettings { get { return "Server=.; Database=GlobalNewsNetwork; User Id=sa; Password=sa123456;"; } }
        public static string ConnectionSettings = Environment.GetEnvironmentVariable("DATABASE_CONNECTION");

    }
}
