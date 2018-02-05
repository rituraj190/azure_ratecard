using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace azure_ratecard
{
    public class AppSettings
    {
        public string clientId { get; set; }
        public string clientSecret { get; set; }
        public string resource { get; set; }
    }
}
