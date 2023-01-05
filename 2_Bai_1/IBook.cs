using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Bai_1
{
    internal interface IBook
    {
        int ISBN { get; set; }
        string name { get; set; }
        string author { get; set; }
        string publish { get; set; }
        string publishYear { get; set; }
        string this[int index] {get; set;}

        void Show();
    }
}
