//Kelly Vu
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, num4;
            num1 = 51;
            num2 = 785;
            num3 = 83;
            num4 = 98;

            double result = Add(num1, num2);
            Console.WriteLine($"{num1} + {num2} = {result}");

            result = Subtract(num3, num4);
            Console.WriteLine();
            Console.ReadKey();

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        static public double Add(double val1, double val2)
        {
            var sum = val1 + val2;
            return sum;
            
        }

        static double Subtract(double val1, double val2)
        {
            return val1 - val2;
        }

        static public double Add(double[] values)
        {
            //while
            double sum = 0;
            int counter = 0;
            while (counter < values.Length)
            {
                sum += values[counter];
                counter++;
            }



            foreach (var item in collection)
            {

            }
            return 0;
        }
    }
}
