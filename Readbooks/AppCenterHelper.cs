using System;
using System.Collections.Generic;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace Readbooks
{
    public class AppCenterHelper
    {
        public static void TrackError(Exception exception, Dictionary<String,String> properties = null) {
            Crashes.TrackError(exception, properties);

        }

        public static void TrackEvent(string eventName, Dictionary<String, String> properties = null)
        {
            Analytics.TrackEvent(eventName,properties);
        }
    }
}
