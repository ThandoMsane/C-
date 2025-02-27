using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUT2_Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
            Light Company is increasing the salaries of its employees according to their department, as
            can be seen in the table below.

            Department Code Percentage increase
            A 5.2
            B 4.8
            other 4.3

            Write a C# application that prompts the user for department code and annual salary of the
            employee. Calculate and display the increased monthly salary. Use a nested if-statements
            without. Save project as TUT2_Question2.
            */
            string DepartmentCode = "";
            double AnnualPay = 0;
            double PercentageIncrease = 0;
            double Increased_Monthly_Salary = 0;

            Console.WriteLine("Enter Your department code: ");
            DepartmentCode = Console.ReadLine();

            Console.WriteLine("Enter Your Annual Salary: ");
            AnnualPay = double.Parse(Console.ReadLine());

            if (DepartmentCode.ToUpper() == "A")
            {
                PercentageIncrease = 5.2 / 100;
            }
            else if (DepartmentCode.ToUpper() == "B")
            {
                PercentageIncrease = 4.8 / 100;
            }
            else
            {
                PercentageIncrease = 4.3 / 100;
            }

            Increased_Monthly_Salary = (AnnualPay + (AnnualPay * PercentageIncrease)) / 12;

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine($"- Your Increased Monthly Salary is {Increased_Monthly_Salary} -");
            Console.WriteLine("---------------------------------------------------------");
        }
    }
}
