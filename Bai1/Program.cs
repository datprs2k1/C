using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        public static int[,] arr_1 = new int[50,50];
        public static int[,] arr_2 = new int[50,50];
        public static int[,] arr_result = new int[50, 50];
        public static int c1, r1, c2, r2;
        
        static void Main(string[] args)
        {
            Input();
            Multiple();
            Output();
        }

        public static void Input()
        {
            Console.Clear();

            Console.Write("----------------------------------\n");

            Console.Write("\nNhap so hang va so cot cua ma tran thu nhat:\n");
            Console.Write("Nhap so hang: ");
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập so cot: ");
            c1= Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNhap so hang va so cot cua ma tran thu hai:\n");
            Console.Write("Nhap so hang: ");
            r2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            c2 = Convert.ToInt32(Console.ReadLine());

            if (c1 != r2)
            {
                Console.Write("----------------------------------\n");

                Console.Write("\nKhong the nhan hai ma tran tren !!!");
                Console.Write("\nSo cot cua ma tran thu nhat phai bang so hang cua ma tran thu hai.");
                Console.ReadKey();

                Input();
            }

            Console.Clear();

            Console.Write("----------------------------------\n");

            Console.Write("\nNhap ma tran thu nhat:\n");

            for(int i = 0; i < r1; i++)
            {
                for(int j = 0; j < c1; j++)
                {
                    Console.Write("A[[{0}],[{1}]]= ", i, j);
                    arr_1[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Clear();

            Console.Write("----------------------------------\n");

            Console.Write("\nNhap ma tran thu hai:\n");

            for (int i = 0; i < r2; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    Console.Write("A[[{0}],[{1}]]= ", i, j);
                    arr_2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }


        public static void Multiple()
        {
            for (int i = 0; i < r1; i++)
                for (int j = 0; j < c2; j++)
                    arr_result[i, j] = 0;

            for (int i = 0; i < r1; i++)    
            {
                for (int j = 0; j < c2; j++)   
                {
                    int sum = 0;
                    for (int k = 0; k < c1; k++)
                        sum = sum + arr_1[i, k] * arr_2[k, j];
                    arr_result[i, j] = sum;
                }
            }
        }

        public static void Output()
        {
            Console.Clear();

            Console.Write("----------------------------------\n");

            Console.Write("\nKet qua\n");

            for (int i = 0; i < r1; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < c2; j++)
                {
                    Console.Write("{0}\t", arr_result[i, j]);
                }
            }
            Console.Write("\n\n");

            Console.ReadKey();
        }
        
    }
}
