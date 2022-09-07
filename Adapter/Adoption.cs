using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Adoption : IAdapter
    {
        private readonly Target target;
        public Adoption(Target target)
        {
            this.target = target;
        }
        public string GetRequestInformation()
        {
            return "This request is from" + this.target.GetRequestedValue();
        }
    }
}
