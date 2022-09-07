using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class PrintusingSingleton
    {
        private static int counter = 0;

        private static PrintusingSingleton instance = null;
        public static PrintusingSingleton GetInstance
        {
            get {

                if (instance == null)
                {
                    instance = new PrintusingSingleton();
                }
                return instance;
            
            }
        }

        private PrintusingSingleton()
        {
            counter++;
            Console.WriteLine("counter value is : "+counter);
        }
        public void printmessage(string message)
        {
            Console.WriteLine(message);
        }

        public void savemessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
