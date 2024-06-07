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
        }
    }
}
