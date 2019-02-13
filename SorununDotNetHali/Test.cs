using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorununDotNetHali
{
    class SeymaEventArgs : EventArgs
    {
        public int number;
    }

    class Test
    {
        public event EventHandler MyEvent;
        public int number;

        public int Number
        {
            get { return number; }
            set { if(value % 3 == 0)
                {
                    SeymaEventArgs eventargs = new SeymaEventArgs();
                    eventargs.number = value;
                    MyEvent(this,eventargs);
                } }
        }
    }
}
