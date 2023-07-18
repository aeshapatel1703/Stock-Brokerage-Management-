using System;
using System.Collections.Generic;
//using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBA_Software
{

    class DB
    {
        public int user_Id { get; set; }
        public string user_name { get; set; }
        public string user_emailid { get; set; }
        public string user_mobile_no { get; set; }
        public string user_password { get; set; }
        public DateTime user_created_on { get; set; }
        public DateTime user_updated_on { get; set; }
    }
}
