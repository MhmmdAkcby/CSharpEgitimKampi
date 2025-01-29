using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.WriteLine("Hello World");
            //Console.WriteLine("Hi");
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion


            #region String Değişkenler
            //string
            //Değişken türü değiken adi
            //string name;
            //name = "Murat";
            //Console.WriteLine(name);
            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "Istanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine($"Müşteri: {customerName} {customerSurname} ");
            //Console.WriteLine($"İletişim: {customerPhone}");
            //Console.WriteLine($"Email: {customerEmail}");
            //Console.WriteLine($"Adres: {district}/{city}");
            //Console.WriteLine("-------------------------------------------");

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 300 80 70";
            //customerEmail = "deneme@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";
            ////Console.WriteLine(customerName);

            //Console.WriteLine();

            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine($"Müşteri: {customerName} {customerSurname} ");
            //Console.WriteLine($"İletişim: {customerPhone}");
            //Console.WriteLine($"Email: {customerEmail}");
            //Console.WriteLine($"Adres: {district}/{city}");
            //Console.WriteLine("-------------------------------------------");
            #endregion

            #region Int Değişkenler
                
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("***** Resoran Menu Fiyatları *****");
            Console.WriteLine();

            Console.WriteLine($"----Hamburger: {hamburgerPrice} TL");
            Console.WriteLine($"----Kola: {cokePrice} TL");
            Console.WriteLine($"----Su: {waterPrice} TL");
            Console.WriteLine($"----Kızartmalar: {friesPrice} TL");
            Console.WriteLine($"----Pizza: {pizzaPrice} TL");
            Console.WriteLine($"----Limonata: {lemonadePrice} TL");

            Console.WriteLine();
            #endregion

            Console.ReadLine();

        }
    }
}
