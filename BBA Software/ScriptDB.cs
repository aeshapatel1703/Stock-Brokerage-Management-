using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBA_Software
{
    internal class ScriptDB
    {
        public int script_id { get; set; }
        public string script_name { get; set; }
        public DateTime script_created_by { get; set; }
        public DateTime script_created_on { get; set; }

    }
}
