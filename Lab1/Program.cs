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
        public class SpareParts
        {
            public string Name { get; set; }
            public string Presence { get; set; }
            public string Price { get; set; }
            public string Quantiry { get; set; }
        }

        static void Main(string[] args)
        {
            List<SpareParts> spare_parts = new List<SpareParts>(4);
            spare_parts.Add(new SpareParts() { Name = "Генератор", Presence = "В наличии", Price = "5000 тыс", Quantiry = "5 шт" });
            spare_parts.Add(new SpareParts() { Name = "Шины", Presence = "В наличии", Price = "7000 тыс", Quantiry = "40 шт" });
            spare_parts.Add(new SpareParts() { Name = "Тормозные диски", Presence = "В наличии", Price = "3000 тыс", Quantiry = "60 шт" });
            spare_parts.Add(new SpareParts() { Name = "Сцепление", Presence = "В наличии", Price = "5000 тыс", Quantiry = "13 шт" });
            spare_parts.Add(new SpareParts() { Name = "Глушитель", Presence = "Нет в наличии", Price = "4000 тыс", Quantiry = "9 шт" });

            foreach (SpareParts p in spare_parts)
            {
                Console.WriteLine($"Название запчасти: {p.Name}");
                Console.WriteLine($"Наличие: {p.Presence}");
                Console.WriteLine($"Цена: {p.Price}");
                Console.WriteLine($"Колличество запчастей: {p.Quantiry}");
                Console.WriteLine();
            }



            spare_parts.RemoveAt(1);
            spare_parts.Add(new SpareParts() { Name = "Движок", Presence = "В наличии", Price = "5000 тыс", Quantiry = "9 шт" }); ;
            Console.WriteLine("Обновленный список после удаления: ");

            foreach (SpareParts p in spare_parts)
            {
                Console.WriteLine($"Название запчасти: {p.Name}");
                Console.WriteLine($"Наличие: {p.Presence}");
                Console.WriteLine($"Цена: {p.Price}");
                Console.WriteLine($"Колличество запчастей: {p.Quantiry}");
                Console.WriteLine();
            }

            Console.ReadLine();

            Calculator calc = new Calculator();

            Console.WriteLine("Расчитать сумму заказа.");
            Console.WriteLine("Введите первое число для сложения:");
            int s = Convert.ToInt32(Console.ReadLine());
            int a = Convert.ToInt32(s);

            Console.WriteLine("Введите второе число для сложения:");
            int s2 = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(s2);
            Console.WriteLine("Сумма заказа: " + calc.sum(s, s2));

            double c;
            Console.WriteLine("Расчитать скидку.");
            Console.WriteLine("Введите цену: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Скидка: " + calc.discounts(c, 0.15));

            Console.ReadKey();
        }

        public void Change(List<SpareParts> empList)
        {
            foreach (SpareParts p in empList)
            {
                if (p.Presence == "Нет в наличии")
                {
                    Console.WriteLine(p.Presence + "В наличии");
                }
            }
        }
    }

    public class Calculator
    {
        public int sum(int s, int s2)
        {
            return s + s2;
        }

        public double discounts(double c, double d) //скидка
        {
            return c * d;
        }
    }

    [TestFixture]
    public class UnitTest1
    {
        Calculator calc;

        [SetUp]
        public void SetUp()
        {
            calc = new Calculator();
        }

        [Test]
        public void SumTest()
        {
            Assert.AreEqual(1100, calc.sum(500, 600)); //правильный тест
            //Assert.AreEqual(700, calc.sum(500, 600)); //неправельный тест
        }

        [Test]
        public void DiscountsTest()
        {
            Assert.AreEqual(165, calc.discounts(1100, 0.15)); //правильный тест
            //Assert.AreEqual(75, calc.discounts(1100, 0.15)); //неправельный тест
        }


        //private SpareParts data;

        [Test]
        public void Add()
        {
            var expected = new List< String >();
            expected.AddRange(new[] { "Движок", "В наличии", "5000 тыс", "9 шт" });

            var actual = new List<String>();
            actual.AddRange(new[] { "Движок", "В наличии", "5000 тыс", "9 шт" });

            //Assert.AreEqual(spareparts, sparepartsTwo);
            CollectionAssert.AreEqual(expected, actual);
            //Assert.IsTrue(spareparts.SequenceEqual(sparepartsTwo));
        }   
    }
}
