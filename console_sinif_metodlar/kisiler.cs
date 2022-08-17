using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_sinif_metodlar
{
    internal class kisiler
    {
        public void kisiliste(string adsoyad)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Merhaba "+ adsoyad);
            }
        }
    }
}
