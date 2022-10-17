
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KonutKredisi konutKredisi = new KonutKredisi();
            IKrediManager tasitKredisi = new TasitKredisi();
            BasvuruManager basvuruManager = new BasvuruManager();
            DatabaseLoggerService databaseLoggerService = new DatabaseLoggerService();
            FileLoggerService fileLoggerService = new FileLoggerService();
            

            Console.WriteLine("Kredi Başvurusunda Gelen");
            basvuruManager.BasvuruYap(tasitKredisi ,databaseLoggerService);
            basvuruManager.BasvuruYap(konutKredisi, fileLoggerService);

            Console.WriteLine("Liste ile gelen veriler");
            List<IKrediManager> krediler = new List<IKrediManager>()
            {
                tasitKredisi,konutKredisi
            };

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            Console.ReadLine();
        }
    }
}
