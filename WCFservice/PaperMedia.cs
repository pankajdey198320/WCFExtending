using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFservice
{
    public class PaperMedia : IMedia
    {
        public string GetMediaName()
        {
            return "This is test name";
        }
    }
}