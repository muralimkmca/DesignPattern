using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class SaveCommand : ICommand
    {

        private Operations Operations;
        public SaveCommand(Operations operations)
        {
            Operations = operations;
        }

        public string Execute()
        {
            return Operations.Save();
        }

    }
}
