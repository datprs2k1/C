using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Bai_1
{
    internal class BookList
    {
        private List<Book> list= new List<Book>();

        public void addBook()
        {
            Book a = new Book();
            a.Input();

            list.Add(a);
        }

        public void showBooks()
        {
            Console.Write("----------------------------------\n");
            Console.WriteLine("Sort by ISBN");
            list.Sort();

            foreach(Book a in list)
            {
                a.Show();
            }

            Console.Write("----------------------------------\n");
            Console.WriteLine("Sort by name");

            list.Sort(new BookNameComparer());

            foreach (Book a in list)
            {
                a.Show();
            }

            Console.Write("----------------------------------\n");
            Console.WriteLine("Sort by author");

            list.Sort(new BookAuthorComparer());

            foreach (Book a in list)
            {
                a.Show();
            }

        }

        public void inputList()
        {
            Console.Write("Quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < quantity; i++)
            {
                addBook();
            }
        }
    }
}
