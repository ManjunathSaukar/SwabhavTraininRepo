using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConfigReaderUsingOOPsApp.Model
{
    internal class ConnectionConfig
    {
        public string Connection1 { get; set; }
        public string Connection2 { get; set; }

        public ConnectionConfig()
        {
            var appSettings = ConfigurationManager.AppSettings;
            Connection1 = appSettings["connection1"];
            Connection2 = appSettings["connection2"];
        }
    }
}
