using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Program
    {
        static void Task1()
        {
            Complex complex1;
            Console.Write("Введите re первого комплексного числа: ");
            complex1.re = double.Parse(Console.ReadLine());
            Console.Write("Введите im первого комплексного числа: ");
            complex1.im = double.Parse(Console.ReadLine());
            Complex complex2;
            Console.Write("Введите re второго комплексного числа: ");
            complex2.re = double.Parse(Console.ReadLine());
            Console.Write("Введите im второго комплексного числа: ");
            complex2.im = double.Parse(Console.ReadLine());
            Complex complex3 = complex1.Plus(complex2);
            Console.WriteLine($"Сложение коплексных чисел {complex1} и {complex2} = {complex3}");
            Console.WriteLine("Для выхода в меню: нажмите любую клавишу\n");
            Console.ReadLine();
            Console.Clear();
        }
        static void Task2()
        {
            Complex complex1;
            Console.Write("Введите re первого комплексного числа: ");
            complex1.re = double.Parse(Console.ReadLine());
            Console.Write("Введите im первого комплексного числа: ");
            complex1.im = double.Parse(Console.ReadLine());
            Complex complex2;
            Console.Write("Введите re второго комплексного числа: ");
            complex2.re = double.Parse(Console.ReadLine());
            Console.Write("Введите im второго комплексного числа: ");
            complex2.im = double.Parse(Console.ReadLine());
            Complex complex3 = Complex.Minus(complex1, complex2);
            Console.WriteLine($"Вычитание коплексных чисел {complex1} и {complex2} = {complex3}");
            Console.WriteLine("Для выхода в меню: нажмите любую клавишу\n");
            Console.ReadLine();
            Console.Clear();
        }
        static void Task3()
        {
            Complexclass complex1 = new Complexclass(0, 0);
            Console.Write("Введите re первого комплексного числа: ");
            complex1.Re = double.Parse(Console.ReadLine());
            Console.Write("Введите im первого комплексного числа: ");
            complex1.Im = double.Parse(Console.ReadLine());
            Complexclass complex2 = new Complexclass(0, 0);
            Console.Write("Введите re второго комплексного числа: ");
            complex2.Re = double.Parse(Console.ReadLine());
            Console.Write("Введите im второго комплексного числа: ");
            complex2.Im = double.Parse(Console.ReadLine());
            Complexclass complex3 = Complexclass.Mult(complex1, complex2);
            Console.WriteLine($"Произведение коплексных чисел {complex1} и {complex2} = {complex3}");
            Console.WriteLine("Для выхода в меню: нажмите любую клавишу\n");
            Console.ReadLine();
            Console.Clear();
        }
        static void Task4()
        {
            Console.WriteLine("Вводите числа по одному, для завершения введите 0: ");

            int AmountOfOddNumbers = 0;
            int summ = 0;
            while (true)
            {
                int number = GetInt();
                if (number == 0)
                {
                    break;
                }
                else if (number > 0 && number % 2 == 1)
                {
                    summ += number;
                    AmountOfOddNumbers++;
                }
            }

            Console.WriteLine("Количество чисел: " + AmountOfOddNumbers);
            Console.WriteLine("Сумма чисел: " + summ);
            Console.WriteLine("Для выхода в меню: нажмите любую клавишу\n");
            Console.ReadLine();
            Console.Clear();

        }


        struct Complex
        {
            public double re;
            public double im;
            public Complex Plus(Complex x)
            {
                Complex comlexres;
                comlexres.re = re + x.re;
                comlexres.im = im + x.im;
                return comlexres;

            }
            public static Complex Minus(Complex a, Complex b)
            {
                Complex comlexres;
                comlexres.re = a.re - b.re;
                comlexres.im = a.im - b.im;
                return comlexres;

            }
            public override string ToString()
            {
                return $"{re} + {im}i";

            }
        }
        static int GetInt()
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Неверный ввод (требуется числовое значение).\nПожалуйста, повторите ввод: ");
                else return x;
        }
        class Complexclass
        {
            private double re;
            private double im;

            public double Re
            {
                get { return re; }

                set { re = value; }
            }
            public double Im
            {
                get { return im; }
                set { im = value; }
            }

            public Complexclass(double re, double im)
            {
                this.re = re;
                this.im = im;

            }
            public Complexclass Plus(Complexclass x)
            {
                Complexclass comlexres = new Complexclass(re + x.re, im + x.im);
                return comlexres;

            }
            public static Complexclass Minus(Complexclass a, Complexclass b)
            {
                Complexclass comlexres = new Complexclass(a.re - b.re, a.im - b.im);
                return comlexres;

            }
            public static Complexclass Mult(Complexclass a, Complexclass b)
            {
                Complexclass comlexres = new Complexclass(a.re * b.re, a.im * b.im);
                return comlexres;

            }
            public override string ToString()
            {
                return $"{re} + {im}i";

            }
        }
        static void Main(string[] args)
        {

            bool f = true;
            while (f)
            {
                Console.WriteLine("Задачи:");
                Console.WriteLine("===============================================");
                Console.WriteLine("|1 = Задача 1 - Сложение комплексных чисел    |");
                Console.WriteLine("===============================================");
                Console.WriteLine("|2 = Задача 2 - Вычитание комплексных чисел   |");
                Console.WriteLine("===============================================");
                Console.WriteLine("|3 = Задача 3 - Произведение комплексных чисел|");
                Console.WriteLine("===============================================");
                Console.WriteLine("|4 = Задача 4 - Сумма нечётных полож. чисел.  |");
                Console.WriteLine("===============================================");
                Console.WriteLine("|0 = Завершение работы.                       |");
                Console.WriteLine("===============================================");


                Console.Write("Введите номер задачи: ");
                int number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
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

                }

            }

        }

    }
}
