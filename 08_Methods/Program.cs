﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            //()
            //Geriye Değer Döndürmeyen Metotlar
            //Customer--> Listele, ekle, sil, güncelle
            //Void

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}
            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);

            //}
            //Sum();
            #endregion

            #region Geriye Değer Dödürmeyen String Parametreli Metotlar

            //void WriteMethod(string name) 
            //{
            //    Console.WriteLine(name);
            //}

            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine($"Müşteri: {name} {surname}");
            //}

            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşeşgül", "Kaya");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);
            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali ";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());
            #endregion

            #region Geriye Değer Döndüren Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = $"Ülke: {countryName} \nBaşkent:{capital} \nBayrak Rengi: {flagColor}";
            //    return cardInfo;
            //}

            //string x, y, z;

            //Console.Write("Ülke Adı Girin: ");
            //x = Console.ReadLine();
            //Console.WriteLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();
            //Console.WriteLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar
            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45,98));
            //Console.WriteLine(Sum(35,25));
            //Console.WriteLine(Sum(44,36));
            //Console.WriteLine(Sum(14,20));
            #endregion

            string ExamResult(string student,int exam1, int exam2, int exam3) 
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if(result >= 50)
                {
                    return $"{student} sınavı geçti oratlama: {result}";
                }
                else
                {
                    return $"{student}  Kaldı oratlama: {result}";
                }
            }

            Console.WriteLine(ExamResult("Ali", 45, 21, 55));
            Console.WriteLine(ExamResult("Ayşe", 36, 88, 33));

            Console.Read();
        }
    }
}
