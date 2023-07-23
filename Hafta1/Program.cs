using System;

namespace Hafta1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi; //declaration : değişken tanımlama
            sayi = 12; //assign : değer atama
            int sayi2 = 1234;
            Console.WriteLine(sayi);

            {
                //kapsam1
                int a = 19;
                Console.WriteLine(a);
                {
                    //kapsam2
                    //short a = 34;
                    Console.WriteLine(a);
                }

            }
            {
                //kapsam3
                int a = 345;
                Console.WriteLine(a);
            }

            Console.ReadKey();
        }

    }
}



