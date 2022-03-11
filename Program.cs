using System;

namespace donguler
{
    class Program{
     static void Main(string[] args)
     {
            // Console.WriteLine("Bir sayi giriniz:");
            // int sayi = int.Parse(Console.ReadLine());

            // int sayac = 1;
            // int toplam = 0;

            // while( sayac <= sayi){
            //     toplam += sayac;
            //     sayac ++;
            // }
            // Console.WriteLine("ortalama " + toplam / sayac);
            

            // char harf = 'a';

            // while ( harf < 'z'){
            //     Console.WriteLine(harf);
            //     harf ++;
            // }
            

            //For Each 

            string[] arabalar  = {"ford","fiat","toyota","Nissan"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
     }
}
