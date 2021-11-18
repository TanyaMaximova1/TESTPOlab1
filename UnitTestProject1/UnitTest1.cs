using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace UnitTestProject1
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Calculator calc = new Calculator();
    //        Console.WriteLine(calc.sum(2, 3));
    //        Console.WriteLine(calc.div(8, 0));
    //        Console.ReadKey();
    //    }
    //}

    //public class Calculator
    //{
    //    public int sum(int a, int b)
    //    {
    //        return a + b;
    //    }

    //    public int div(int a, int b)
    //    {
    //        return a / b;
    //    }
    //}

    //[TestFixture]
    //public class UnitTest1
    //{
    //    Calculator calc;

    //    [SetUp]
    //    public void SetUp()
    //    {
    //        calc = new Calculator();
    //    }

    //    [Test]
    //    public void SumTest()
    //    {
    //        Assert.AreEqual(5, calc.sum(2, 3));
    //        Assert.AreEqual(0, calc.sum(0, 0));
    //    }

    //    [Test]
    //    public void DivTest()
    //    {
    //        Assert.AreEqual(2.5, calc.div(2, 5));
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine("Расчитать сумму заказа.");
            Console.WriteLine(calc.sum(500, 600));

            double c;
            Console.WriteLine("Расчитать скидку.");
            Console.WriteLine("Введите цену: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(calc.discounts(c, 0.15));

            string s;
            Console.WriteLine("Вывести цену");
            Console.WriteLine("Введите название услуги: (Замена масла) или (Замена рулевых реек)");
            s = Convert.ToString(Console.ReadLine());
            Console.WriteLine(calc.price(s));

            Console.WriteLine("Расчитать среднюю цену.");
            Console.WriteLine(calc.avarage(500, 600));

            Console.ReadKey();
        }
    }

    public class Calculator
    {
        public int sum(int a, int b)
        {
            return a + b;
        }

        public double discounts(double c, double d)
        {
            return c * d;
        }

        public string price(string name)

        {
            string l = " ";
            if (name == "Замена масла")
            {
                l = "500 руб";
                Console.WriteLine(l);
            }

            else
            {
                if (name == "Замена рулевых реек")
                {
                    l = "600 руб";
                    Console.WriteLine(l);
                }
            }
            return name;
        }

        public int avarage(int a, int b)
        {
            return ((a + b)/2);
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
            Assert.AreEqual(1100, calc.sum(500, 600));
            Assert.AreEqual(0, calc.sum(0, 0));
        }

        [Test]
        public void DiscountsTest()
        {
            Assert.AreEqual(0, calc.discounts(0, 0.15));
            Assert.AreEqual(0, calc.discounts(0, 0));
        }

        //[Test] //???
        //public void PriceTest()
        //{
        //    Assert.AreEqual(5, calc.discounts(0, 0.15));
        //    Assert.AreEqual(0, calc.discounts(0, 0));
        //}


    }
}
