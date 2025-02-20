using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAid
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /**Problem Statement
            Given the following problem background, write a C# program that included the following 
            functions:

             A function that calculated and return monthly premium. This function must receive 
            the monthly income, number of adult dependants and number of child dependants.
             A function that calculated and return penalties. This function must receive main 
            member’s age and monthly premium (without penalties).

            To test your functions, write the main function that will prompt the user to enter, for each 
            member: the member name, age, the number of adult dependants, the number of child 
            dependants and monthly income. 
            
            The main function must then use the first function to calculate monthly premium 
            (excl. penalties), and the second function to calculate premium penalties. 
           
            The returned monthly premium and premium penalties must be added before 
            calculating the total monthly contributions of all the members. Provide data of different 
            available members until a sentinel is used to stop. 
            
            Display all output in the main function
            */

            string MembersName = "";
            int Age = 0;
            int AdultDep = 0;
            int ChildDep = 0;
            double MonthlyIncome = 0;
            int Count = 0;
            Program program = new Program();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("*                     Welcome To The Medical Aid Scheme                  *");
            Console.WriteLine("**************************************************************************");

            do
            {
                Console.WriteLine("Enter members name (or enter ZZZ to terminate): ");
                MembersName = Console.ReadLine();

                if (MembersName.ToUpper() == "ZZZ")
                {
                    break;
                }

                Console.WriteLine("Enter members age: ");
                Age = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the number of adult dependents: ");
                AdultDep = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the number of child dependents: ");
                ChildDep = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the members monthly income: ");
                MonthlyIncome = double.Parse(Console.ReadLine());

                // This function receive the monthly income, number of adult dependants and number of child dependants.
                double monthlyPremium = program.MonthlyPremium(MonthlyIncome, AdultDep, ChildDep);

                // This function receive main member’s age and monthly premium(without penalties)
                double premiumPenalties = program.PremiumPenalties(Age, monthlyPremium);

                // Monthly Premium with Penalties
                double TotalMonthlyPremium = monthlyPremium + premiumPenalties;


                Console.WriteLine($"\n{++Count}. {MembersName} ({Age} yrs old) has {AdultDep} " +
                                  $"adult dependent(s) and {ChildDep} children. " +
                                  $"They will pay R{TotalMonthlyPremium:F2} per month.\n");

            }
            while (true);

            Console.WriteLine("\n==========================================================================\n");
            Console.WriteLine("Done");
            Console.WriteLine("\n==========================================================================\n");
        }

        public double MonthlyPremium(double MonthlyIncome, int AdultDep, int ChildDep)
        {
            /***   A function that calculated and return monthly premium. This function must receive 
            the monthly income, number of adult dependants and number of child dependants.*/

            double monthlyPremium = 0;
            int MemberFee = 0;
            int AdultFee = 0;
            int ChildFee = 0;

            // Rates per Monthly Income

            if(MonthlyIncome <= 7000)
            {
                MemberFee = 582;
                AdultFee = 476;
                ChildFee = 264;
            }
            else if (MonthlyIncome >= 7001 && MonthlyIncome <= 12000)
            {
                MemberFee = 868;
                AdultFee = 709;
                ChildFee = 470;
            }
            else
            {
                MemberFee = 1084;
                AdultFee = 887;
                ChildFee = 586;
            }

            if(ChildDep <= 3)
            {
                monthlyPremium = ((MemberFee * 1) + (AdultFee * AdultDep) + (ChildFee * ChildDep));
            }
            else
            {
                monthlyPremium = ((MemberFee * 1) + (AdultFee * AdultDep) + (ChildFee * 3));
            }

            return monthlyPremium;
        }

        /**   A function that calculated and return penalties. This function must receive main 
            member’s age and monthly premium (without penalties).
*/
        public double PremiumPenalties(int age, double monthlyPremium)
        {
            /**Furthermore, premium penalties will be applied to members over the age of 35 years joining 
               for the first time. Increase the monthly premium with the following percentage based on the 
               number of years after the age of 35 years:*/

            double PremiumCharge = 0;

            if(age <= 35)
            {
                PremiumCharge = 0;
            }
            else if(age > 35 && age <= 39)
            {
                //  1 - 4 years add 5% to the relevant premium
                PremiumCharge = monthlyPremium * 0.05;
            }
            else if (age > 39 && age <= 48)
            {
                //  5 - 14 years add 15% to the relevant premium
                PremiumCharge = monthlyPremium * 0.15;
            }
            else if (age > 48 && age <= 57)
            {
                //  15 - 24 years add 25% to the relevant premium
                PremiumCharge = monthlyPremium * 0.25;
            }
            else
            {
                //  25 + years add 35% to the relevant premium
                PremiumCharge = monthlyPremium * 0.35;
            }

            return PremiumCharge;
        }
    }
}
