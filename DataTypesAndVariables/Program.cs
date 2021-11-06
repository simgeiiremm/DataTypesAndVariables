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
            #region Value Types //kodları gruplamamızı sağlar
            Console.WriteLine("Hello World!");
            int number1; //declaration
            number1 = 17; //assignment, set
            Console.WriteLine(number1);
            Console.WriteLine("Number 1 is " + number1);
            Console.WriteLine("Number 1 is {0}", number1);

            int number2 = 888;
            // Int32 number2 = 888;
            Console.WriteLine("Number 1 =" + number1 + ", Number 2 = " + number2);
            Console.WriteLine("Number 1 is {0}, Number 2 is {1}", number1, number2);
            Console.WriteLine(int.MinValue + "..." + int.MaxValue);
            Console.WriteLine($"Max : {int.MaxValue} - Min {int.MinValue}");


            //Console.ReadLine();

            long sayi1 = 500;     //  long bigint c# tanımı ~-9 kentilyon  - ~9 kentilyon //Int64
            Console.WriteLine("Sayı 1:" + sayi1);

            short sayi2 = -546; //~-32000 -  ~32000  //Int16
            Console.WriteLine("Sayı 2:" + sayi2);

            byte b1 = 192; // 0 - 255 //Byte
            Console.WriteLine(b1);

            bool durum; //boolean: true(1), false(0) 
            durum = true;
            durum = false;
            Console.WriteLine(durum);
            //Console.ReadLine();

            uint uSayi1 = 123;

            ulong uSayi2 = 0; // 0 ve - sayilari tutar 

            ushort uSayi3 = 65000;

            sbyte sSayi4 = 127; // -128 ve 127 sayılarını tutar

            char karakter = 'A'; //tek bir veriyi tutar

            Console.WriteLine("A karakter " + karakter + "-- Sayısal değeri " + (int)karakter); //casting işlemi

            double d1 = 1.56; // double float dan daha genis veri tutar //64 bit

            Console.WriteLine("Ondalık " + d1);

            float f1 = -5.0F; // 32 bit
            Console.WriteLine(f1); // -5.0

            decimal dec1 = 123.12345m; // dobule ve floattan daha büyük verileri tutar 192 bit
            Console.WriteLine(dec1);

            Console.WriteLine("Pazartesi");

            string gun1 = "Pazartesi"; // string referans veri tipidir
            Console.WriteLine(gun1);
            Console.WriteLine(Gunler.Cuma + " - " + (int)Gunler.Cuma);


            #endregion

            #region Reference Types

            string adSoyad = "Çağıl Alsaç";
            Console.WriteLine("Ad soyadı: " + adSoyad);
            var adSoyadi = "Çağıl Alsaç";

            #endregion

            #region Escape Sequences (Escape Characters)

            string sehir = "\" Ankara \""; //"Ankara"
            Console.WriteLine(sehir);

            /*
             \": Çift tırnak
            \n: new line (alt satır)
            \r: carriage return (satır başı) --\n\r
            \\: slash: C:\Program Files\Rockstar Games \GTA V
            \t: tab
             */
            Console.WriteLine("Çağıl\nAlsaç");

            string dosyaYolu = "C:\\Program Files\\Rockstar Games \\GTA V";
            Console.WriteLine(dosyaYolu);
            dosyaYolu = @"D:\Cagil\GTA V";
            Console.WriteLine(dosyaYolu);

            #endregion

            Console.ReadLine();


        }
    }
}
