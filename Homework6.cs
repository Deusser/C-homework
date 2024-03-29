﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    internal class Homework6
    {
        class Student
        {
            public string lastName;
            public string firstName;
            public string university;
            public string faculty;
            public int course;
            public string department;
            public int group;
            public string city;
            public int age;
            // Создаем конструктор
            public Student(string firstName, string lastName, string university, string faculty, string department, int age, int course, int group, string city)
            {
                this.lastName = lastName;
                this.firstName = firstName;
                this.university = university;
                this.faculty = faculty;
                this.department = department;
                this.course = course;
                this.age = age;
                this.group = group;
                this.city = city;
            }
        }
        class StudentCount
        {
            static int AgeCompare(Student st1, Student st2)    
            {
                return String.Compare(st1.age.ToString(), st2.age.ToString());      
            }

            static int CourceAndAgeCompare(Student st1, Student st2)
            {
                if (st1.course > st2.course)
                    return 1;
                if (st1.course < st2.course)
                    return -1;
                if (st1.age > st2.age)
                    return 1;
                if (st1.age < st2.age)
                    return -1;
                return 0;
            }

            static void Main(string[] args)
            {
                int magistr1 = 0;
                int magistr2 = 0;
                List<Student> list = new List<Student>();
                DateTime dt = DateTime.Now;
                Dictionary<int, int> cousreFrequency = new Dictionary<int, int>();
                StreamReader sr = new StreamReader("..\\..\\students.csv");
                while (!sr.EndOfStream)
                {
                    try
                    {
                        string[] s = sr.ReadLine().Split(';');
                        list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                        if (int.Parse(s[6]) == 5) magistr1++; else if (int.Parse(s[6]) == 6) magistr2++;
                        if (int.Parse(s[5]) > 17 && int.Parse(s[5]) < 21)
                        {
                            if (cousreFrequency.ContainsKey(int.Parse(s[6])))
                                cousreFrequency[int.Parse(s[6])] += 1;
                            else
                                cousreFrequency.Add(int.Parse(s[6]), 1);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                        if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                    }
                }
                sr.Close();
                Console.WriteLine("Всего студентов:" + list.Count);
                Console.WriteLine("Магистров первого курса:{0}", magistr1);
                Console.WriteLine("Магистров второго курса:{0}", magistr2);
                Console.WriteLine("\nПокажем сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся.");
                ICollection<int> keys = cousreFrequency.Keys;
                String result = String.Format("{0,-10} {1,-10}\n", "Курс", "Количество студентов");
                foreach (int key in keys)
                    result += String.Format("{0,-10} {1,-10:N0}\n",
                                       key, cousreFrequency[key]);
                Console.WriteLine($"\n{result}");

                list.Sort(new Comparison<Student>(AgeCompare));
                Console.WriteLine("Отсортируем студентов по возрасту: ");
                foreach (var v in list) Console.WriteLine($"{v.firstName} {v.age}");

                list.Sort(new Comparison<Student>(CourceAndAgeCompare));
                Console.WriteLine("\nОтсортируем студентов по курсу и возрасту возрасту: ");
                foreach (var v in list) Console.WriteLine($"{v.firstName}, курс {v.course}, возраст {v.age}");
                Console.ReadKey();
            }
        }




        //class Program
        //    {
        //        public delegate double fun1(double a, double x);
        //        public static double MyFunc1(double a, double x)
        //        {
        //            return a * x * x;
        //        }
        //        public static double MyFunc2(double a, double x)
        //        {
        //            return a * Math.Sin(x);
        //        }
        //        public static void Table(fun1 F, double x, double b)
        //        {
        //            Console.WriteLine("----- X ----- Y -----");
        //            while (x <= b)
        //            {
        //                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, b));
        //                x += 1;
        //            }
        //            Console.WriteLine("---------------------");
        //        }

        //        static void Main()
        //        {
        //            Console.WriteLine("Таблица функции a*x^2:");
        //            Table(new fun1(MyFunc1), -2, 2);
        //            Console.WriteLine("Таблица функции a*sin(x):");
        //            Table(new fun1(MyFunc2), -2, 2);

        //            Console.ReadLine();
        //        }

        //    }
    }
}