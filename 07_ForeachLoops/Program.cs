using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string city in cities) Console.WriteLine(city);

            //int[] numbers = {45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach ( int i in numbers) Console.WriteLine(i);

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach( var i in numbers )
            //{
            //    if (i % 2 == 0) Console.WriteLine(i);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //int total = 0;

            //foreach(var i in numbers) total += i;

            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5
            //};
            //foreach (int number in numbers) Console.WriteLine(number);

            //string word = "Merhaba";

            //foreach (char c in word) Console.WriteLine(c);

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.WriteLine("***** C# Eğitim Kampı Sınava Uygulaması *****");

            Console.WriteLine();
            Console.Write("Sınıftaki öğrenci sayısını giriniz: ");
            int studentsCount = int.Parse(Console.ReadLine());
            string[] student = new string[studentsCount];


            for (int i = 0; i < studentsCount; i++)
            {
                Console.Write($"Lütfen {i}. Öğrenci Adını Giriniz: ");
                string studentName = Console.ReadLine();
                Console.WriteLine();
                Console.Write("1. Sınav Notunu Giriniz: ");
                int exam1 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("2. Sınav Notunu Giriniz: ");
                int exam2 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                int result = (exam1 + exam2) / 2;

                Console.WriteLine();
                student[i] = $"Öğrenci Adı: {studentName}  1. Sınavı: {exam1}   2. Sınavı {exam2}  Ortalaması: {result}";
                

            }

            foreach (var i in student)
            {
                Console.WriteLine("**********************************************************************************");
                Console.WriteLine();
                Console.WriteLine(i);
                Console.WriteLine();
                Console.WriteLine("**********************************************************************************");

            }



            #endregion

            Console.ReadKey();
        }
    }
}
