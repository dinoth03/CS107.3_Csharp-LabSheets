using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, sum = 0;

            Console.Write("Enter a positive number:");
            number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                for (int i = 1; 1 < +number; i++)
                {
                    sum = sum + 1;
                    //sum+=1
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}