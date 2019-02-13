using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaskaVizeSorusu
{
    class Kronometre
    {
        public event EventHandler MyEvent = delegate { };
        private int saniye;

        public Kronometre(int saniye)
        {
           Saniye = saniye;
        }

        public int Saniye
        {
            get { return saniye; }
            set
            {
                saniye = value;
                MyEvent(this,new EventArgs());
            }
        }


    }
}
