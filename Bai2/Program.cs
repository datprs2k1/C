using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        public static int xM, yM, a, b, c;
        public static double distance;
        static void Main(string[] args)
        {
            Input();
            CalculateDistance();
            Output();
        }

        public static void Input()
        {
            Console.Clear();
            Console.Write("----------------------------------\n");
            Console.Write("\nNhap diem M\n");
            Console.Write("xM= ");
            xM = Convert.ToInt32(Console.ReadLine());

            Console.Write("yM= ");
            yM = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.Write("----------------------------------\n");
            Console.Write("\nNhap doan thang\n");

            Console.Write("a= ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("b= ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("c= ");
            c = Convert.ToInt32(Console.ReadLine());
        }

        public static void CalculateDistance()
        {
            distance = (Math.Abs((a * xM) + (b * yM) + c) / (Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))));
        }

        public static void  Output()
        {
            Console.Clear();
            Console.Write("----------------------------------\n");
            Console.Write("\nKhoang cach= {0}\n", distance);
            Console.ReadKey();
        }
    }
}
