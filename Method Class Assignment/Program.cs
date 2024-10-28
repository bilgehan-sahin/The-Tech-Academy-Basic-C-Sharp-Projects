using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the 'MathOperations' class
            MathOperations mathOps = new MathOperations();

            // Call the 'PerformOperation' method, passing in two numbers
            mathOps.PerformOperation(5, 30);

            // Call the 'PerformOperation' method again, specifying the parameters by name
            mathOps.PerformOperation(num1: 7, num2: 20);

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
