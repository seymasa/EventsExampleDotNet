using System;

namespace EventDelegateSorusuVize
{
    delegate void eventhandler(Test t);
    class Test
    {
        public event eventhandler myevent; // olayların eklenecegi yer
        public int Number;

        public int number
        {
            get { return Number; }
            set
            {
                Number = value;
                if (value != 0 && value % 3 == 0)
                {
                    myevent(this);
                }
            }
        }
        

    }
}
