using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Bai_1
{
    internal class Book : IBook, IComparable<Book>
    {
        private int isbn;
        private string Name;
        private string Author;
        private string Publish;
        private string PublishYear;
        private ArrayList chapters = new ArrayList();
        public string this[int index]
        {
            get
            {
                if (index < 0 && index > chapters.Count)
                {
                    throw new IndexOutOfRangeException();
                }

                return (string)chapters[index];
            }
            set
            {
                if (index < 0 && index > chapters.Count)
                {
                    throw new IndexOutOfRangeException();
                }

                if (index == chapters.Count)
                {
                    chapters.Add(value);
                }
                else
                {
                    chapters[index] = value;
                }
            }
        }

        public int ISBN { get => isbn; set => isbn = value; }
        public string name { get => Name; set => Name = value; }
        public string author { get => Author; set => Author = value; }
        public string publish { get => Publish; set => Publish = value; }
        public string publishYear { get => PublishYear; set => PublishYear = value; }

        public void Show()
        {
            Console.Write("----------------------------------\n");
            Console.WriteLine("ISBN: {0}", isbn);
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Author: {0}", Author);
            Console.WriteLine("Publiser: {0}", Publish);
            Console.WriteLine("Year: {0}", PublishYear);
            Console.WriteLine("List Chapter");
            for (int i = 0; i < chapters.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, chapters[i]);
            }
        }

        public void Input()
        {
            Console.Write("----------------------------------\n");
            Console.Write("ISBN: ");
            isbn = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Author: ");
            Author = Console.ReadLine();
            Console.Write("Publisher: ");
            Publish = Console.ReadLine();
            Console.Write("Year: ");
            PublishYear = Console.ReadLine();
            Console.Write("----------------------------------\n");
            Console.Write("Chapters: ");

            int quantity = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < quantity; i++)
            {
                Console.Write("Title: ");
                chapters.Add(Console.ReadLine());
            }
        }

        public int CompareTo(Book other)
        {
            return this.isbn.CompareTo(other.isbn);
        }
    }
}
