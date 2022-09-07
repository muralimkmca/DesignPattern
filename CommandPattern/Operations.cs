using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Operations
    {
        public string Open()
        {
            return "Document has been Opened";
        }

        public string Save()
        {
            return "Document has been Saved";
        }

        public string Close()
        {
            return "Document has been Closed";
        }

    }
}
