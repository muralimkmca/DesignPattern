using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operations operations = new Operations();
            ICommand opencommand = new OpenCommand(operations);
            ICommand savecommand = new SaveCommand(operations);
            ICommand closecommand = new CloseCommand(operations);

            CommandInvoker menu = new CommandInvoker(opencommand, savecommand, closecommand);

            Console.WriteLine(menu.ClickOpen());
            Console.WriteLine(menu.ClickSave());
            Console.WriteLine(menu.ClickClose());
            Console.ReadKey();
        }
    }
}
