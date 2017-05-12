using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cit195TheAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("Enter Operand 1: ");
            double operand1 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Enter Operand 2: ");
            double operand2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine($"{operand1} + {operand2} = {Add(operand1, operand2)}");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        static double Add(double operand1, double operand2)
        {
            return operand1 + operand1;
        }
    }
}
