using System;
using System.Collections.Specialized;
using System.Configuration;

namespace ConfigApp.Model
{
    internal class Config
    {
        public string[] KeyValueStore()
        {
            var appSettings = ConfigurationManager.GetSection("appSettings") as NameValueCollection;
            string[] connectionStrings = new string[appSettings.Count];
            int i = 0;
            foreach (var key in appSettings.AllKeys)
            {
                connectionStrings[i++]=appSettings[key];
            }
            return connectionStrings;
        }
    }
}
