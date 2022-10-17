using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class Sample3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пароль:\n");
            string message = Console.ReadLine();
            Regex regex = new Regex("^[A-Z]{1}[0-9A-Za-z]{1,10}");
            Console.WriteLine(regex.IsMatch(message));


            string s1 = "abcd";
            string s2 = "dabc";
            s1.Select(Char.ToUpper).OrderBy(x => x).SequenceEqual(s2.Select(Char.ToUpper).OrderBy(x => x));



            Console.ReadLine();
        }
    }
}   
