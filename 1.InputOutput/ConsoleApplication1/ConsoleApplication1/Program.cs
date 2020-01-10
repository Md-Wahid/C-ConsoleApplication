using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            string rep;

            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; ++i)
            {
                numbers[i] = (i + 1) * (i + 1);
            }
            for (int i = 0; i < numbers.Length; ++i)
            {
                Console.WriteLine((i+1)+"X"+(i+1)+" = "+numbers[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Hello World");
            Console.WriteLine();

            Console.Write("Enter number 1: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result: "+(number1+number2));
            Console.WriteLine();

            Console.WriteLine("Sum of numbers[0] to numbers[9] is "+sum(numbers));
            Console.ReadKey();
        }

        static int sum(int[] number)
        {
            int result = 0;
            for (int i = 0; i < number.Length; ++i)
            {
                result += number[i];
            }
            return result;
        }
    }
}
