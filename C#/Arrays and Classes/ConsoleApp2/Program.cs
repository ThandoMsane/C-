using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Mad-max mechanic runs a factory and employs workers who are paid one of the three hourly 
            rates depending on their shift, 
            first shift R23 per hour, 
            second shift, R24,50 and 
            the third shift, R29 per hour. 
            
            Each factory worker might work any number of hours per week; any hours 
            greater than 40 are paid at one and one-half times the usual rate. 
            In addition, second and third shift worker can elect to participate in the retirement plan, for which 3% of the worker 
            Software gross pay is deducted from the pay checks. 
            
            Write a program that asks the user for the hours worked and the shift number; 
            if the shift is 2 or 3, prompt the user to enter the worker’s choice to participate in the 
            retirement plan. Display (1) the hours worked, (2) the shift, (3) the hourly rate pay, 
            (4) the regular pay, (5) overtime pay, (6) total of regular and overtime pay, 
            (7) the retirement deduction, if any, and (8) the net pay. Save project as TUT1_Question2.
            * **/

            int hoursWorked;
            int shiftNo;
            string retirementPlan = "";
            double retirementDeduction = 0;
            double hourlyRatePay = 0;
            double regularPay = 0;
            double overtime = 0;
            double overtimePay = 0;

            Console.WriteLine("*****************************************************");
            Console.WriteLine("*                       Welcome                      *");
            Console.WriteLine("*****************************************************");

            // hours worked
            Console.Write("What are your hours worked: ");
            hoursWorked = int.Parse(Console.ReadLine());

            // shift number 
            Console.Write("What is your shift number: ");
            shiftNo = int.Parse(Console.ReadLine());

            // Calculate values based on shift
            switch (shiftNo)
            {
                case 1:
                    hourlyRatePay = 23;
                    break;
                case 2:
                    hourlyRatePay = 24.50;
                    break;
                case 3:
                    hourlyRatePay = 29;
                    break;
                default:
                    Console.WriteLine("Invalid shift number.");
                    return;
            }

            // Calculate overtime and pay
            if (hoursWorked > 40)
            {
                overtime = hoursWorked - 40;
                overtimePay = overtime * hourlyRatePay * 1.5;
                regularPay = 40 * hourlyRatePay;
            }
            else
            {
                regularPay = hoursWorked * hourlyRatePay;
            }

            double totalPay = regularPay + overtimePay;

            // Retirement plan for shift 2 and 3
            if (shiftNo == 2 || shiftNo == 3)
            {
                Console.Write("Do you want to participate in the retirement plan (Y for yes & N for no): ");
                retirementPlan = Console.ReadLine();

                if (retirementPlan == "Y")
                {
                    retirementDeduction = totalPay * 0.03;
                }
            }

            double netPay = totalPay - retirementDeduction;

            // Display results
            Console.WriteLine($"(1) The hours worked are: {hoursWorked}");
            Console.WriteLine($"(2) The shift number is: {shiftNo}");
            Console.WriteLine($"(3) The hourly rate pay is: {hourlyRatePay}");
            Console.WriteLine($"(4) The regular pay is: {regularPay}");
            Console.WriteLine($"(5) The overtime pay is: {overtimePay}");
            Console.WriteLine($"(6) Total of regular and overtime pay: {totalPay}");
            Console.WriteLine($"(7) The retirement deduction: {retirementDeduction}");
            Console.WriteLine($"(8) The net pay: {netPay}");

        }

    }
}
