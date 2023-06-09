﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpPrograms
{
    internal class FibonoccieSeries
    {
        public static void GenerateFibonoccieNumb(int n) 
        {
            int numb1 = 0, numb2 = 1, sum = 0;
            Console.WriteLine("Printing Fibonoccie Series");
            if (n == 1)
            {
                Console.Write("{0} ", numb1);
            }
            else if (n == 2)
            {
                Console.Write("{0} {1}", numb1, numb2);
            }
            else
            {
                //Console.Write(numb1+" "+numb2); (this is the alternate method for line no 15)
                Console.Write("{0} {1}", numb1, numb2);
                for (int i = 3; i <= n; i++)
                {
                    sum = numb1 + numb2;
                    Console.Write(" {0}", sum);
                    numb1 = numb2;
                    numb2 = sum;
                }
            }
        }
        
    }
}
