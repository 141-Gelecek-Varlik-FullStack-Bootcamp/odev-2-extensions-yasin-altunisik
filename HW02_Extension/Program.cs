using System;
using HW02;

namespace HW02_Extension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var amount = 1;

            //Dollar equation
            Console.WriteLine("1 Dolar : " + Extension.ToTl(amount));
            Console.ReadLine();
        }
    }
}
