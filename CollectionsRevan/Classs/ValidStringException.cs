using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Classs
{
    internal class ValidStringException:Exception
    {
        public ValidStringException(string message) : base(message)
        {

        }
    }
}
