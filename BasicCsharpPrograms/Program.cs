using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Basic C# programs");
            Console.WriteLine("Please choose the any one of the following:");
            Console.WriteLine("1.Calculator,\n2.FibonoccieSeries");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Calculator.AddTwoNumbers();
                    Calculator.SubstractTwoNumber();
                    Console.WriteLine("Please enter 1st number:");
                    double x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter 2nd number");
                    double y = Convert.ToDouble(Console.ReadLine());
                    Calculator.DivideTwoNumber(x, y);
                    break;
                 case 2:
                    Console.WriteLine("Please enter the number you want to generate:");
                    int n = Convert.ToInt32(Console.ReadLine());
                    FibonoccieSeries.GenerateFibonoccieNumb(n);
                    break;
                 default:
                    Console.WriteLine("Please choose existing program only.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
