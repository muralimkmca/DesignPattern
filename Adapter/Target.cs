using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Target
    {
        public string GetRequestedValue()
        {
            return "Requested value returned";
        }
    }
}
