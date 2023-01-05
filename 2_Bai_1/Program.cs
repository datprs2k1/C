using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Bai_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookList a = new BookList();
            a.inputList();
            Console.Clear();
            a.showBooks();

            Console.ReadLine();
        }
    }
}
