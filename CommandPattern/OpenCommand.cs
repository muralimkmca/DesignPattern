using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class OpenCommand : ICommand
    {

        private Operations Operations;
        public OpenCommand(Operations operations)
        {
            Operations = operations;
        }        

        public string Execute()
        {
            return Operations.Open();
        }
    }
}
