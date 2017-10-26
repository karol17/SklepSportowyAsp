using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SklepSportowy.Helpers
{
    public class AppConfig
    {
        private static string _obrazyFolder = ConfigurationManager.AppSettings["ObrazyFolder"];
        public static string ObrazyFolder
        {
            get { return _obrazyFolder; }
        }
    }
}