using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrithmatic_Calculator
{
  
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Addition Claculator");

                //Ask the user to enter the first number
                Console.Write("Enter the first number: ");
                int a = Convert.ToInt32(Console.ReadLine());

                //Ask the user to enter the second number
                Console.Write("Enter the second number: ");
                int b = Convert.ToInt32(Console.ReadLine());

                int result = a + b;

                Console.WriteLine("The total is: " + result);

                Console.Read();

                Console.WriteLine("Arithmetic Calculator");
            }Console.WriteLine("Thank you for using the calculator.");
        }
    
}
