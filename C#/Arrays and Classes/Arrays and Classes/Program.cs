using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /** 
             * Write a C# application that declares an array of type int with size of 10 called stock. Populate
               the array with user input. Determine and display the highest value and the lowest value from
               the random numbers stored in the array. Save project as TUT1_Question1.*/

            int[] stock = new int[10];

            Console.WriteLine("***************************************");
            Console.WriteLine("*              Welcome                *");
            Console.WriteLine("***************************************");

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter your {i + 1} number ");
                stock[i]= int.Parse(Console.ReadLine());



            }

            int MaximumValue = stock.Max();
            int MinValue = stock.Min();

            Console.WriteLine($"your minimum value is {MinValue} and your maximum value is {MaximumValue}");

        }
    }
}
