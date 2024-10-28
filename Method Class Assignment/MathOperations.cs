using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment
{
    public class MathOperations
    {
        public void PerformOperation(int num1, int num2)
        {
            // Perform a math operation on the first integer (add 10 to it)
            int result = num1 + 10;

            // Display the result of the operation
            Console.WriteLine($"The result of adding 10 to {num1} is: {result}");

            // Display the second integer
            Console.WriteLine($"The second integer is: {num2}");
        }
    }
}
