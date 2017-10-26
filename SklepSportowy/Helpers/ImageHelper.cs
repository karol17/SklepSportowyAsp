using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SklepSportowy.Helpers
{
    public static class ImageHelper
    {
        public static string ImagePath(this UrlHelper helper,string imageName)
        {
            var imageFolder = AppConfig.ObrazyFolder;
            var path = Path.Combine(imageFolder, imageName);
            var absolutePath = helper.Content(path);
            return absolutePath;
        }
    }
}