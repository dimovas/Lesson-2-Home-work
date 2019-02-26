using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Home_work
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2, c = 3, d = 4;
            Console.WriteLine("a = " + a + ", b = " + b + ", c = " + c + ", d = " + d);
           // Console.ReadLine();

            //task1();
            //task2();
            task3();
            task4();
            task5();
            task6();
            //task7();
            //task8();
            //task9();
            //task10();
        }

                public static void task1()
        {
            int a = 1, b = 2, c = 3;
            double x;
            x = (b + Math.Pow((b * b + 4 * a * c), (1 / 2))) / 2 / a - Math.Pow(a, 3) * c + Math.Pow(b, (-2));
            Console.WriteLine("Task1 = "+x);

            if (x != 0.25)
            {
                Console.WriteLine("Wrong ansver. Let's try to find solution step by step.");
                double x1, x2, x3,x4,x5;
                x1 = b * b + 4 * a * c;
                Console.WriteLine("b^2 + 4ac = "+x1);
                x2 = Math.Pow(x1, 0.5);
                Console.WriteLine("discriminant root = "+x2);
                x3 = (b + x2) / 2 / a;
                Console.WriteLine("the fraction part is"+x3);
                x4 = a * a * a * c;
                Console.WriteLine("a^3 *c ="+x4);
                x5 = Math.Pow(b, (-2));
                Console.WriteLine("b^(-2) = "+x5);
                x = x3 - x4 + x5;
                Console.WriteLine("true answer is: Task1 = "+ x);
            }
            else
            {
                Console.WriteLine("Congrads!!! That's true.");
            }
            Console.ReadLine();

        }

        public static void task2()
        {
            double a = 1, b = 2, c = 3, d = 4;
            double x;
            x = a * b / (c * d)- (a * b - c) / (c*d);
            Console.WriteLine("Task2 = " + x);
            Console.ReadLine();
        }

        public static void task3()
        {
            double x = 5, y = 6, z;
            Console.WriteLine("x = "+x+", y = "+y);
            z = (Math.Sin(x) + Math.Cos(y)) / (Math.Cos(x) - Math.Sin(y)) * Math.Tan(x * y);
            Console.WriteLine("Task3 = " + z);
            Console.ReadLine();
        }

        public static void task4()
        {
            double x = 5, y = 6, z;
            Console.WriteLine("x = " + x + ", y = " + y);
            z = (x + y) / (y + 1) - (x * y - 12) / (34 + x);
            Console.WriteLine("Task4 = " + z);
            Console.ReadLine();
        }

        public static void task5()
        {
            double x, y, z;
            Console.WriteLine("Input x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input y:");
            y = Convert.ToDouble(Console.ReadLine());
            z = (3 + Math.Pow(Math.E, y - 1)) / (1 + Math.Pow(x, 2) * Math.Abs(y - Math.Tan(x)));
            Console.WriteLine("Task5 = " + z);
            Console.ReadLine();
        }

        public static void task6()
        {
            double x, z;
            Console.WriteLine("Input x:");
            x = Convert.ToDouble(Console.ReadLine());
            z = x - Math.Pow(x, 3) / 3 + Math.Pow(x, 5) / 5;
            Console.WriteLine("Task6 = " + z);
            Console.ReadLine();
        }
    }
}
