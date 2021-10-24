using System;

namespace DataTypesAndVariables
{
    enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int number1;
            number1 = 17;
            Console.WriteLine(number1);
            Console.WriteLine("Number 1 is " + number1);
            Console.WriteLine("Number 1 is {0}", number1);

            int number2 = 888;
            Console.WriteLine("Number 1 =" + number1 + ", Number 2 = " + number2);
            Console.WriteLine("Number 1 is {0}, Number 2 is {1}", number1, number2);        
            Console.WriteLine(int.MinValue + "..." + int.MaxValue);
            //Console.ReadLine();

            long sayi1 = 500;     //  long bigint c# tanımı ~-9 kentilyon  - ~9 kentilyon
            Console.WriteLine("Sayı 1:" + sayi1);

            short sayi2 =-546; //~-32000 -  ~32000
            Console.WriteLine("Sayı 2:" + sayi2);

            byte b1 = 192; // 0 - 255
            Console.WriteLine(b1);

            bool durum; //boolean: true(1), false(0) 
            durum = true;
            durum = false;
            Console.WriteLine(durum);
            //Console.ReadLine();

            uint uSayi1 = 123;

            ulong uSayi2 = 0; // 0 ve - sayilari tutar 

            ushort uSayi3 = 65000;

            sbyte sSayi4 = 127;

            char karakter = 'A'; //tek bir veriyi tutar

            Console.WriteLine("A karakter " + karakter + "-- Sayısal değeri " + (int)karakter);

            double d1 = 1.56; // double float dan daha genis veri tutar

            Console.WriteLine("Ondalık " + d1);

            float f1 = -5.0F;
            Console.WriteLine(f1); // -5.0

            decimal dec1 = 123.12345m; // dobule ve floattan daha büyük verileri tutar
            Console.WriteLine(dec1);

            Console.WriteLine("Pazartesi");

            string gun1 = "Pazartesi"; // string referans veri tipidir
            Console.WriteLine(gun1);
            Console.WriteLine(Gunler.Cuma + " - " + (int)Gunler.Cuma);

            var adSoyad = "Çağıl Alsaç";


            Console.ReadLine();


        }
    }
}
