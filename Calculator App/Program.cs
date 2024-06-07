using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Input your first number");
            var firstAsText = Console.ReadLine();
            var number1 = int.Parse(firstAsText);

            Console.WriteLine("Input your second number");
            var secondAsText = Console.ReadLine();
            var number2 = int.Parse(secondAsText);

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[A]dd numbers");
            Console.WriteLine("[S]ubtract numbers");
            Console.WriteLine("[M]ultiply numbers");
            var choice = Console.ReadLine();

            if (choice == "A" || choice == "a")
            {
                var sum = number1 + number2;
                Console.WriteLine(
                    number1 + " + " + number2 + " = " + sum
                    );
            }
            else if (choice == "S" || choice == "s")
            {
                var difference = number1 - number2;
                Console.WriteLine(
                    number1 + " - " + number2 + " = " + difference
                    );
            }
            else if (choice == "M" || choice == "m")
            {
                var multiplied = number1 * number2;
                Console.WriteLine(
                    number1 + " * " + number2 + " = " + multiplied
                    );
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }

            Console.ReadKey();
        }
    }
}
