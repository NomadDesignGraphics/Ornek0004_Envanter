using System;
using System.IO;

/*
             * Eğer yukarıdaki "iksirAdi" string array ındaki içerik adedi ile string den int e dönüştürmeden sıralama yaptırmak
             * istersem direkt olarak içerik uzunluğu komutu olan
             * "değişkenAdı.Lenght" yap
             * o hemen senin amacını anlıyor ve ona göre string'i int e çevirmeden neyi ne yapacağını anlıyor 
*/

namespace Envanter
{
    internal class Program
    {

        public static Random sayi = new Random();

        //PARA
        public static string para_yeri = @"F:\Kendi_Orneklerim\C#\Ornek0004_Envanter\Envanter\data\para.txt";

        //İKSİR
        public static string iksir_yeri = @"F:\Kendi_Orneklerim\C#\Ornek0004_Envanter\Envanter\data\iksir.txt";

        //ZIRH
        public static string zirh_yeri = @"F:\Kendi_Orneklerim\C#\Ornek0004_Envanter\Envanter\data\zırh.txt";

        //SİLAH
        public static string silah_yeri = @"F:\Kendi_Orneklerim\C#\Ornek0004_Envanter\Envanter\data\silah.txt";


        public static void IksirA()
        {
            

            int iksirAdet;
            int i = 0;

            string[] iksirTipi = { "Health", "Mana", "Revive", "Stamina", "Power", "Stability", "Cloack integre" };
            
            int[] adet = new int[iksirTipi.Length];


            foreach (var item in adet) adet[i] = sayi.Next(7, 50);
            

            int toplam = 0;
            for (int a = 0; a < adet.Length; ++a) toplam += adet[a];


            iksirAdet = toplam;

            using(StreamWriter sw = File.AppendText(iksir_yeri))
            {
                sw.WriteLine(iksirAdet);
            }
        }

        public static void Silah()
        {
            int i=0;
            string[] silahTipi = { "Sword", "Claymore", "Yay", "Mage Tool" };
            int[] tipA = new int[silahTipi.Length];

            foreach (var item in tipA) tipA[i] = sayi.Next(1, 35);
            int toplam = 0;
            for (int a = 0; a < tipA.Length; a++) toplam += tipA[a];

            int silahsayisi = toplam;

            using (StreamWriter sw = File.AppendText(silah_yeri)) 
            {
                sw.WriteLine(silahsayisi);
            }

        }

        public static void Zirh()
        {
            int i = 0;
            string[] zirhTipi = { "Miğfer", "Gövde", "Pantolon", "Ayakkabı" }; 
            int[] tipA = new int[zirhTipi.Length];

            foreach (var item in tipA) tipA[i] = sayi.Next(1, 20);
            int toplam = 0;
            for (int a = 0; a < tipA.Length; a++) toplam += tipA[a];

            int zirhsayisi = toplam;

            using (StreamWriter sw = File.AppendText(zirh_yeri))
            {
                sw.WriteLine(zirhsayisi);
            }
        }

        public static void PARA()
        {
            var para = sayi.Next(0, 999999);

            using (StreamWriter sw = File.AppendText(para_yeri))
            {
                sw.WriteLine(para);
            }
        }

        public static void Envanter()
        {
            //                      0               1           2          3           4
            string[] isimler = { "EnvanterID", "Cüzdan", "İksir Adeti", "Silah Adeti", "Zırh Adeti" };

            int ID;
            //veri isimleri ama değişken olacak şekilde
            string para,iksirA, silahA, zirhA;

            //Dİrekt envanter id si

            // oyuncu parası
            para = File.ReadAllText(para_yeri);

            //iksir adeti
            iksirA = File.ReadAllText(iksir_yeri);

            //Silah adeti
            silahA = File.ReadAllText(silah_yeri);

            //Zırh adeti
            zirhA = File.ReadAllText(zirh_yeri);

            int envanterAdet = 0;

            ID = envanterAdet+1;

            //Envanter ID yazdırma
            for (envanterAdet = 0; envanterAdet < ID; envanterAdet++)
            {
                //ID += 1;
                Console.WriteLine("Envanter adedi: " + ID);
            }


            string[] Goruntu;
            Goruntu = new string[] { 
                ID.ToString() ,
                para,
                iksirA ,
                silahA ,
                zirhA };


            foreach (var item in isimler)
            {
                Console.Write(item+"      ");
            }

            Console.WriteLine("");
            foreach (var item in Goruntu)
            {
                Console.Write("     "+item + "      ");
            }


            Console.Read();
        }

        static void Main(string[] args)
        {
            Console.Title = "Envanter";
            Program.IksirA();
            Program.Silah();
            Program.Zirh();
            Program.PARA();
            Program.Envanter();

        }


    }
}
