﻿using System.Web.Optimization;

namespace SklepSportowy.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                
                      "~/Content/Style.css"
                      
                      ));
        }
     }
}