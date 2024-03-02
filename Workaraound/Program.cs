using Entities.Concrete;
using Business;
using System;
using Business.Concrete;

namespace Workaraound
{
    public class Program
    {
        static void Main(string[] args)
        {
            SelamVer("engin");
            SelamVer("Ahmet");
            SelamVer();

            int sonuc = Topla(3, 5);
            int sonuc2 = Topla();

            //Diziler

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "Said Semih";
            person1.LastName = "Yalçın";
            person1.DateOfBirthYear = 2001;
            person1.NationalIdentity = 50482116164;

            Person person2 = new Person();
            person2.FirstName = "Mae";
            Console.WriteLine("------------");
            foreach (var sehir in sehirler2)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara", "İstanbul", "İzmir" };
            yeniSehirler1.Add("Adana 1");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }
        
            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        static void SelamVer(String isim = "isimsiz")
        {
            Console.WriteLine("Merhaba" + isim);
        }
        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Sonucunuz: " + sonuc);
            return sonuc;
        }

    }


}
