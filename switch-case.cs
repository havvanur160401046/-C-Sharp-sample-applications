using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int sayi;
             Console.WriteLine("1 ile 7 arasında bir sayi giriniz");
             sayi = Convert.ToInt16(Console.ReadLine());//kullanıcıdan sayıyı aldık

             switch(sayi)//anahtar
             {
                 case 1: Console.WriteLine("Gün=Pazartesi");
                     break;
                 case 2: Console.WriteLine("Gün=salı");
                     break;
                 case 3: Console.WriteLine("Gün=carsamba");
                     break;
                 case 4: Console.WriteLine("Gün=Persembe");
                     break;
                 case 5:Console.WriteLine("Gün=cuma");
                     break;
                 case 6:Console.WriteLine("Gün=cumartesi");
                     break;
                 case 7: Console.WriteLine("Gün=Pazar");
                     break;
                 default: Console.Write("hatalı gün girişi");
                     break;


             }
             Console.ReadLine();*/
             string mevsim;
             Console.WriteLine("mevsimi giriniz");
             mevsim = Console.ReadLine();
             switch(mevsim)
             {
                 case "yaz": Console.WriteLine("yaz mevsimi ayları: haziran temmuz agustos");
                     break;
                 case "ilkbahar": Console.WriteLine("ilkbahar  mevsimi ayları:mart nisan mayıs");
                     break;
                 case "sonbahar": Console.WriteLine("sonbahar mevsimi ayları : eylül ekim kasım");
                     break;

                 case "kıs": Console.WriteLine("kkıs mevsimi ayları: aralık ocak subat");
                     break;
                 default:Console.WriteLine("hatalı deger girdiniz");
                     break;

             }
             Console.ReadLine();
         
        }
    }
}
