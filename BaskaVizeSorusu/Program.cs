using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BaskaVizeSorusu
{
    class Program
    {
        static void Main(string[] args)
        {
            Kronometre kr = new Kronometre(4200);
            kr.MyEvent += new EventHandler(Bilgi);
            
            while(kr.Saniye > 0)
            {
                kr.Saniye--;
                Thread.Sleep(1000);
            }
        }
        public static void Bilgi(object gonderen, EventArgs e)
        {
            Kronometre kr = (Kronometre) gonderen;

            int saat = 0;
            int dakika = 0;
            int saniye = 0;

            // kr.Saniye = 4200;

            // dakika = 70
            dakika = (int) kr.Saniye / 60;
            // saniye = 0
            saniye = kr.Saniye % 60;

            // saat = 1
            saat = (int)dakika / 60;
            // dakika = 10
            dakika = dakika % 60;

            // saat=1, dakika=10, saniye=0
            Console.WriteLine("{0}:{1}:{2}", saat, dakika, saniye);
        }
    }
}
