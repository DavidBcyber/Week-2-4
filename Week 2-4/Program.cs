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
            int a, b; // the integers for each length of the hypotenuse
            Console.WriteLine("Welcome to Hypotenuse Calculator"); // The calculator to find hypotenuse
            Console.WriteLine("Enter the length of the first side (a): "); // input for the first length "a"
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the length of the second side (b): "); // input for the second length "b"
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("the length of the hypotenuse is " + Math.Sqrt( a * a + b * b)); // The equations to find "c" length

            Console.WriteLine("thank you for using the Hypotenuse Calculator"); // thank you for using the calulator

            Console.ReadLine(); //read line
        }
    }
}
