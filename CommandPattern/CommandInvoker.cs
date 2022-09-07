using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class CommandInvoker
    {
        private ICommand Open;
        private ICommand Close;
        private ICommand Save;
        public CommandInvoker(ICommand Open,ICommand Save, ICommand Close)
        {
            this.Open = Open;
            this.Close = Close;
            this.Save = Save;
        }

        public string ClickOpen()
        {
            return Open.Execute();
        }

        public string ClickSave()
        {
            return Save.Execute();
        }

        public string ClickClose()
        {
            return Close.Execute();
        }
    }
}
