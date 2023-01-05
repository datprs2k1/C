using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Bai_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccountList a = new AccountList();

            int choose = 0;

            do
            {
                Console.Write("----------------------------------\n");
                Console.WriteLine("1. New Account");
                Console.WriteLine("2. Save File");
                Console.WriteLine("3. Load File");
                Console.WriteLine("4. Report");
                Console.WriteLine("0. Exit");

                Console.Write("Select: ");
                choose = Convert.ToInt32(Console.ReadLine());

                switch(choose)
                {
                    case 1:
                        Console.Clear();
                        a.NewAccount();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        a.SaveFile();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        a.LoadFile();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        a.Report();
                        break;
                    default:
                        break;
                }
            } while (choose != 0);


        }
    }
}
