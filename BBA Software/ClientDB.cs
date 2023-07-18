using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBA_Software
{
    internal class ClientDB
    {
        public int client_id { get; set; }
        public string client_name { get; set; }
        public string phone_no { get; set; }
        public string address { get; set; }
        public string state { get; set; }
        public float brokerage_ratio { get; set; }
        public DateTime client_created_by { get; set; }
        public DateTime client_created_on { get; set; }
        public DateTime client_updated_by { get; set; }
        public DateTime client_updated_on { get; set; }
        public string client_status { get; set; }
    }
}
