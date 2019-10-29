using System;
using System.Collections.Generic;
using Microsoft.AppCenter.Crashes;

namespace Readbooks
{
    public class Books
    {
        public string Id { get; set;}
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }


        public bool SaveBook()
        {
            //save to some db
            Dictionary<String, String> keyValuePairs = new Dictionary<string, string> {
                    {"user","jonchusGP" },
                    {"network","Cellular"}

                };
            AppCenterHelper.TrackEvent("book_saved",keyValuePairs);
            //Crashes.GenerateTestCrash();
            return true;
        }
    }
}
