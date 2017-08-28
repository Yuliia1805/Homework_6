using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter any two numbers and we'll show you arithmetic middling, and if this result odd or even");

            double firstnumber;
            double secondnumber;
            double summ = 0;
            double arithmeticmiddling = 0;
            
            
            Console.WriteLine("Enter the first number: ");
            firstnumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            secondnumber = double.Parse(Console.ReadLine());

            for (double i = firstnumber; i <= secondnumber; i++)
            {
                summ += secondnumber;
                arithmeticmiddling = (firstnumber + secondnumber) / 2;
                int result = Convert.ToInt32(Math.Floor(arithmeticmiddling));
            }
            
            Console.WriteLine("The summ is: " + summ);
            Console.WriteLine("The arithmeticmiddling is: " + arithmeticmiddling);

            if (arithmeticmiddling % 2 == 0)
            {
                Console.WriteLine("The result is even");
            }
            else
            {
                Console.WriteLine("The result is odd");
            }
  


            Console.ReadLine();
        }
    }
}
