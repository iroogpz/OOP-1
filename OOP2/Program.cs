using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "123456";
            musteri1.Ad = "Yakup";
            musteri1.SoyAd = "Karaca";
            musteri1.TcNo = "123456789";

            TuzelMusteri tuzelMusteri1 = new TuzelMusteri();
            tuzelMusteri1.Id = 2;
            tuzelMusteri1.MusteriNo = "12345678";
            tuzelMusteri1.VergiNo = "456789";
            tuzelMusteri1.SirketAdi = "xXx";


        }
    }
}
