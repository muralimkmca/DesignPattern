using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Target t = new Target();
            Adoption adoption = new Adoption(t);
            Console.WriteLine(adoption.GetRequestInformation());

            Console.ReadLine();
        }
    }
}
