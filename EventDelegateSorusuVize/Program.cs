using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegateSorusuVize
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.myevent += new eventhandler(mymetot);

            for(int i = 1; i < 10; i++)
            {
                t.number = i;
            }
            Console.ReadLine();
        }

        static public void mymetot(Test t)
        {
            Console.WriteLine("Event Tetiklendi. Number 3'ün "+t.Number/3+" katı.");
        }
    }
}
