using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Анкета и индекс массы тела";
            Console.Write("Как вас зовут? ");
            string name = Console.ReadLine();

            Console.Write("Ваша фамилия? ");
            string sname = Console.ReadLine();

            Console.Write("Сколько вам лет? ");
            string ag = Console.ReadLine();
            int age = int.Parse(ag);

            Console.Write("Какой у вас рост? ");
            string hgt = Console.ReadLine();
            int height = int.Parse(hgt);
            double inphgt = Convert.ToDouble(hgt);
            double meters = inphgt / 100;

            Console.Write("Какой у вас вес? ");
            string wgt = Console.ReadLine();
            int weight = int.Parse(wgt);



            Console.WriteLine("Вас зовут: " + name + " Ваша фамилия: " + sname + " Вам: " + age + " Ваш рост: " + height + " Вы весите: " + weight);
            Console.WriteLine("Вас зовут: {0} Ваша фамилия: {1} Вам: {2} Ваш рост: {3} Вы весите: {4}", name, sname, age, height, weight);
            Console.WriteLine($"Вас зовут: {name} Ваша фамилия: {sname} Вам: {age} Ваш рост: {height} Вы весите: {weight}");

            double l = weight / (meters * meters);
            int imt = Convert.ToInt32(l);
            Console.WriteLine("Ваш индекс массы тела: " + imt);


            int a = 1;
            int b = 2;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"Переменная a = {a}, переменная b = {b} ");


            Console.ReadLine();



        }
    }
}
