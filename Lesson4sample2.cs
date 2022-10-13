using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class Lesson4sample2
    {

        class MyArray
        {
            public int[] MainArray { get; set; }
            public int Maxcout { get; set; }

            public MyArray(int count, int start, int step)
            {
                for (int i = 0; i < count; i++)
                {
                    MainArray[i] = start + (step * i);
                }
            }

            public int Sum(int[] arr)
            {
                int s = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    s += arr[i];
                }
                return s;
            }

            public int[] Inverse(int[] arr)
            {
                int[] newArr = new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    newArr[i] = -arr[i];
                }

                return newArr;
            }

            public int[] Multi(int[] arr, int mlt)
            {
                int[] newArr = new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    newArr[i] = mlt * arr[i];
                }

                return newArr;
            }

            public int MaxCounter(int[] arr)
            {
                int max = arr.Max();
                int s = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == max)
                        s += 1;
                }
                return s;
            }

        }
        public static string DBLogIn = AppDomain.CurrentDomain.BaseDirectory + "dblogin.txt";
        public static string dbusername = string.Empty;
        public static string dbpassword = string.Empty;
        public static int again = 0;
        public static int re = 0;
        static void Main(string[] args)
        {
            do
            {
                string[] db = new string[100];
                Console.WriteLine("Введите лоигин:");
                string username = Console.ReadLine();
                Console.WriteLine("Введите пароль:");
                string password = Console.ReadLine();
                using (StreamReader sr = new StreamReader(DBLogIn))
                    for (int i = 0; i < db.Length; i++)
                        db[i] = sr.ReadLine();
                for (int i = 0; i < db.Length; i++)
                {
                    if (db[i] == null)
                        break;
                    int to = db[i].IndexOf(';');
                    dbusername = db[i].Substring(0, to);
                    dbpassword = db[i].Substring(++to);
                    if (username == dbusername && password == dbpassword)
                    {
                        Console.WriteLine("Привет: " + dbusername);
                        re = 0;

                        MyArray a = new MyArray(10, 0, 100);
                        Console.WriteLine(a);

                        break;
                    }
                    else
                        re++;
                }
                if (re++ > 0)
                {
                    again++;
                    Console.WriteLine("Не правильный логин или пароль. Введите еще раз!");
                }
            } while (again < 3);
            Console.ReadLine();
        }
    }
}

