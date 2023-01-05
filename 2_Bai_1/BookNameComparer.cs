using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Bai_1
{
    internal class BookNameComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.name.CompareTo(y.name);
        }
    }
}
