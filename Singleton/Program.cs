using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var printusingSingletonObj = PrintusingSingleton.GetInstance;
            printusingSingletonObj.printmessage("print message1");

            var printusingSingletonObj1 = PrintusingSingleton.GetInstance;
            printusingSingletonObj1.printmessage("print message2");

            var printusingSingletonObj2 = PrintusingSingleton.GetInstance;
            printusingSingletonObj2.printmessage("print message3");
            
            var printusingSingletonObj3 = PrintusingSingleton.GetInstance;
            printusingSingletonObj3.printmessage("print message3");
            
            var printusingSingletonObj4 = PrintusingSingleton.GetInstance;
            printusingSingletonObj4.printmessage("print message4");

            var printusingSingletonObj5 = PrintusingSingleton.GetInstance;
            printusingSingletonObj5.savemessage("Message has been saved");

            Console.ReadKey();
        }
    }
}
