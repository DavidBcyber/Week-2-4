using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c; // int
            Console.WriteLine("Welcome to Hypotenuse Calculator"); // the calculator
            Console.WriteLine("Enter the length of the first side (a): "); // first length
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the length of the second side (b): "); // second length
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Sqrt(c = a * a + b * b)); // the total for c

            Console.WriteLine($"the length of the hypotenuse is {c}"); // result
            Console.WriteLine("thank you for using the Hypotenuse Calculator"); // thank you

            Console.ReadLine(); //read line
        }
    }
}
