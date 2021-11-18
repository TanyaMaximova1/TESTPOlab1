using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class SpareParts
    {
        public string name { get; set; }
        public string price { get; set; }
        public string presence { get; set; } //наличие
        public string quantiry { get; set; } //кол-во

        public List<SpareParts> spareparts { get; set; }


        public void Print()
        {
            Console.WriteLine($"Название запчасти: {name}");
            Console.WriteLine($"Цена: {price}");
            Console.WriteLine($"Наличие: {presence}");
            Console.WriteLine($"Колличество запчастей: {quantiry}");
        }
    }
}
