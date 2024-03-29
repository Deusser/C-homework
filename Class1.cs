﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace lesson2
{
    internal class Sample02
    {


        static void Task1()
        {
            int min;
            Console.WriteLine("===================");
            Console.WriteLine("Выполнение задачи 1");
            Console.WriteLine("===================");
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите c: ");
            int c = int.Parse(Console.ReadLine());
            min = Math.Min(a, Math.Min(b, c));
            Console.Write("Минимальное число: " + min + "\n");
            Console.WriteLine("Для выхода в меню: нажмите любую клавишу\n");
            Console.ReadLine();
            Console.Clear();    
        }
        static void Task2()
        {
            Console.WriteLine("===================");
            Console.WriteLine("Выполнение задачи 2");
            Console.WriteLine("===================");
            Console.Write("Введите число : ");
            long num = long.Parse(Console.ReadLine());
            int i = 0;
            while (num > 0)
            {
                i++;
                num /= 10;
            }
            Console.WriteLine("Количество цифр введенного числа : {0}", i);
            Console.WriteLine("Для выхода в меню: нажмите любую клавишу\n");
            Console.ReadLine();
            Console.Clear();
        }
        static void Task3()
        {
            int numbers;
            int sum = 0;
            Console.WriteLine("===================");
            Console.WriteLine("Выполнение задачи 3");
            Console.WriteLine("==================="); 

            while (true)
            {
                Console.Write("Введите число(0 для выхода): ");
                numbers = int.Parse(Console.ReadLine());
                if (numbers % 2 != 0)
                {
                    sum += numbers;
                    
                }
                if (numbers == 0)
                {
                    Console.WriteLine("Выход из программы");
                    break;
                }
            }
            Console.WriteLine("Сумма нечетных чисел: " + sum);
            Console.WriteLine("Для выхода в меню: нажмите любую клавишу\n");
            Console.ReadLine();
            Console.Clear();
        }
        static void Task4()
        {
            Console.WriteLine("===================");
            Console.WriteLine("Выполнение задачи 4");
            Console.WriteLine("===================");
            int goodnumcount = 0;
            int minnum = 1;
            int maxnum = 1000000;
            int temp;
            int testnum;
            DateTime start = DateTime.Now;
            for (int num = minnum; num <= maxnum; num++)
            {
                temp = 0;
                testnum = num;
                while (testnum != 0)
                {
                    temp += testnum % 10;
                    testnum /= 10;
                }
                if (num % temp == 0) goodnumcount++;
            }
            TimeSpan finishtime = DateTime.Now - start;
            Console.WriteLine("Сумма хороших чисел: " + goodnumcount);
            Console.WriteLine("Программа выполнилась за: {0} секунд",finishtime);
            Console.WriteLine("Для выхода в меню: нажмите любую клавишу\n");
            Console.ReadLine();
            Console.Clear();
        }
            static void Main(string[] args)
        {
            int attempt = 0;
            string login = "root";
            string pass = "GeekBrains";
            string ulogin;
            string upass;
            do
            {
                Console.Write("Количество попыток: " + (3 - attempt) + "\n");
                Console.Write("Введите логин: ");
                ulogin = Console.ReadLine();
                Console.Write("Введите пароль: ");
                upass = Console.ReadLine();
                attempt++;
                Console.Write("Не правильный логин или пароль.\n");
                if (login == ulogin && pass == upass)
                {
                    Console.Write("Вход в программу.\n");
                    Console.Clear();
                    bool f = true;
                    while (f)
                    {
                        Console.WriteLine("Задачи:");
                        Console.WriteLine("===========================================");
                        Console.WriteLine("|1 = Задача 1 - минимальное из трех чисел.|");
                        Console.WriteLine("===========================================");
                        Console.WriteLine("|2 = Задача 2 - количество цифр числа.    |");
                        Console.WriteLine("===========================================");
                        Console.WriteLine("|3 = Задача 3 - сумма нечетных чисел.     |");
                        Console.WriteLine("===========================================");
                        Console.WriteLine("|4 = Задача 4 - поиск хорошего числа.     |");
                        Console.WriteLine("===========================================");
                        Console.WriteLine("|0 = Завершение работы.                   |");
                        Console.WriteLine("===========================================");


                        Console.Write("Введите номер задачи: ");
                        int number = int.Parse(Console.ReadLine());

                        switch (number)
                        {
                            case 1:
                                Task1();
                                break;
                            case 4:
                                Task4();
                                break;
                            case 0:
                                f = false;
                                Console.WriteLine("Завершение работы приложения, нажмите любую клавишу.");
                                Console.ReadLine();
                                Environment.Exit(0);
                                break;

                            case 3:
                                Task3();
                                break;

                            case 2:
                                Task2();
                                break;
                            default:
                                Console.WriteLine("Не правильный ввод \nПовторите ввод.");
                                break;

                        }
                    }

                }
            }

            while (attempt < 3);
            {
               
                if (attempt == 3)
                {
                    Console.WriteLine("Попытки ввода логина и пароля закончились. Завершение работы приложения.");

                }

            }


            


            

            Console.ReadLine();

        }
    }
}
