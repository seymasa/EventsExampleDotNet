using System;

namespace SorununDotNetHali
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.MyEvent += new EventHandler(MyMetot);

            for (int i = 1; i < 10; i++)
            {
                t.number = i;
            }
            Console.ReadLine();
        }

        public static void MyMetot(object kimden, EventArgs args)
        {
            SeymaEventArgs arg = (SeymaEventArgs)args;
            Console.WriteLine("Event tetiklendi. Number 3' ün {0}",arg.number/3," katı.");
        }
    }
}