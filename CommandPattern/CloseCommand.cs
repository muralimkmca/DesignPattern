using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class CloseCommand : ICommand
    {

        private Operations Operations;
        public CloseCommand(Operations operations)
        {
            Operations = operations;
        }

        public string Execute()
        {
            return Operations.Close();
        }    
    }
}
