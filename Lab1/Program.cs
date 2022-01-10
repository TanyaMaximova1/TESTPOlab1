using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Lab1
{
    class Program
    {
        //public class NameSpareParts
        //{
        //    public string Name { get; set; }
        //    public string Presence { get; set; }
        //    public double Price { get; set; }
        //    public int Quantiry { get; set; }
        //}

        //public class Shop
        //{
        //    public string NameSpareParts { get; set; }
        //}

        public class SparePart
        {
            public string Name { get; set; }
            public string Presence { get; set; }
            public double Price { get; set; }
            public int Quantiry { get; set; }
        }

        public class SpareParts
        {
            List<SparePart> spare_parts = new List<SparePart>();

            public int countParts()
            {
              return spare_parts.Count;
            }

            public void addPart(SparePart spare) 
            {
                spare_parts.Add(spare);
            }
            public void removePart(int countSpare)
            {
                spare_parts.RemoveAt(countSpare);
            }
        }

        class Tests
        {
            SpareParts spareTest = new SpareParts();

            [Test]
            public void addPartsTest()
            {
                spareTest.addPart(new SparePart() { Name = "Генератор", Presence = "В наличии", Price = 5000, Quantiry = 5 });
                spareTest.addPart(new SparePart() { Name = "Шины", Presence = "В наличии", Price = 7000, Quantiry = 40 });
                spareTest.addPart(new SparePart() { Name = "Тормозные диски", Presence = "В наличии", Price = 3000, Quantiry = 60 });
                spareTest.addPart(new SparePart() { Name = "Сцепление", Presence = "В наличии", Price = 5000, Quantiry = 13 });
                spareTest.addPart(new SparePart() { Name = "Глушитель", Presence = "Нет в наличии", Price = 4000, Quantiry = 9 });
                Assert.IsTrue(spareTest.countParts() == 5);
            }

            [Test]
            public void remuvePartsTest()
            {
                spareTest.removePart(1);
                Assert.IsTrue(spareTest.countParts() == 4);
            }
        }
        
        static void Main(string[] args)
        {

        }

    }   
}
