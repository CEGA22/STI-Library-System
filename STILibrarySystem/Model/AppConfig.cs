using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STILibrarySystem
{
    public class AppConfig
    {
        public static string DBConnection()
        {
            return ConfigurationManager.ConnectionStrings["STILibrarySystem"].ToString();
           
        }
    }
}
