using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace division_with_remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int divident, divisor;
            Console.Write("Enter the divident :");
            divident = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the divisor :");
            divisor = Convert.ToInt32(Console.ReadLine());
            //divisor = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Quotient: " + divident / divisor);
            Console.WriteLine("Remainder: " + divident % divisor);
            Console.ReadLine();
        }

    }
}
