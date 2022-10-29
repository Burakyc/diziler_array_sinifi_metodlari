# diziler_array_sinifi_metodlari
using System;

namespace diziler_array_sinifi_metodlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sort
            int[] sayiDizisi = {23,12,4,86,72,3,11,17};

            Console.WriteLine("********sırasız dizi **********");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
                
            }

            Console.WriteLine("********sıralı dizi **********");

            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
                
            // clear
            Console.WriteLine("******** Array Clear **********");
            // sayidizisi elemanlarını kullanarak 2.index ten itibaren 2 tane elemanı 0'lar
            Array.Clear(sayiDizisi,2,2);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //Reverse
            Console.WriteLine("******** Array reverse **********");
            Array.Reverse(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //Indexof
            Console.WriteLine("******** Array Indexof **********");
           
            Console.WriteLine( Array.IndexOf(sayiDizisi,23));

            //resize
            Console.WriteLine("******** Array resize **********");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }


        }
    }
}
