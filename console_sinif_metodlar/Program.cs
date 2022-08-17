using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_sinif_metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //geriye değer döndürmeyen metodun kullanımı
            metin msj=new metin();
            msj.mesaj();

            string ads;
            Console.Write("İsim Giriniz:");
            ads = Console.ReadLine(); //console.readline() komutu ile ekrana veri girişi yapabiliriz.
            kisiler ks = new kisiler();
            ks.kisiliste(ads); //ekrana girdiğimiz isme kisiler sınıfında tanımladığımız işlemleri uygular.

            Console.Read();

        }
    }
}
