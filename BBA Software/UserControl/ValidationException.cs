using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBA_Software.UserControl
{
    internal class ValidationException : Exception
    {
        public ValidationException(string msg) : base(msg)
        {

        }
    }
}
