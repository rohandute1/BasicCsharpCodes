using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpPrograms
{
    internal class Calculator
    {
        public static void AddTwoNumbers()
        {
            Console.WriteLine("Welcome to Basic C# programs");
            Console.WriteLine("Please enter 1st number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter 2nd number:");
            int y = Convert.ToInt32(Console.ReadLine());
            int sum = x + y;
            Console.WriteLine("Sum is:{0}", sum);
        }
        public static void Substract()
        {
            Console.WriteLine("Please enter 1st number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter 2nd number:");
            int y = Convert.ToInt32(Console.ReadLine());
            int sub = x - y;
            Console.WriteLine("Substraction is:{0}", sub);
        }
    }
}
