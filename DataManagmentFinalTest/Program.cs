using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalTest;

namespace DataManagmentFinalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone p1 = new Phone("Samsung_520", 500, "Android", "/images/android.png", "/images/s20.jpg");
            Phone p2 = new Phone("iPhone 11", 600, "IOS", "/images/apple.png", "/images/iphone11.jpg");

            Console.WriteLine("added To database");
            Console.ReadLine();

        }
    }
}
