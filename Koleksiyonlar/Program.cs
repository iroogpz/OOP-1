using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diziler");
            string[] isimler = new string[] { "Yakup", "Fatih", "Arif", "Tugay" };
            foreach (string s in isimler)
            {
                Console.WriteLine(s);
            }
           
            //İçinde 4 veri olan bu diziye 5. elemanı eklemek istersek hata vericektir

            Console.WriteLine("----------------------------------");

            Console.WriteLine("Listeler");
            List<string> isimler2 = new List<string> { "Yakup", "Fatih", "Arif", "Tugay" };
            isimler2.Add("Berat"); // listeler sonradan eleman ekleme yapmaya izin verir
            foreach (var listem in isimler2)
            {
                Console.WriteLine(listem);
            }
            Console.ReadLine();
        }
    }
}
