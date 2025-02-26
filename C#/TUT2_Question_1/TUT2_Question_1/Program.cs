using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUT2_Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
            Write an application for UJ Hotel; the program determines the price of a room. Prompt the
            user to choose 1 for queen bed, 2 for a king or 3 for a king and a pull-out couch. The output
            echoes the input and displays the price of the room: R450 for queen, R690 for king, and R800
            for a suit with a king bed and a pull-out couch. If the user enters an invalid code, display an
            appropriate message and set price to 0. Save project as TUT2_Question1.
            **/

            Console.WriteLine("Choose a room type:");
            Console.WriteLine("1. Queen Bed");
            Console.WriteLine("2. King Bed");
            Console.WriteLine("3. King Bed with Pull-out Couch");

            int choice = Convert.ToInt32(Console.ReadLine());
            int price = 0;

            switch (choice)
            {
                case 1:
                    price = 450;
                    Console.WriteLine("You chose a Queen Bed. Price: R" + price);
                    break;
                case 2:
                    price = 690;
                    Console.WriteLine("You chose a King Bed. Price: R" + price);
                    break;
                case 3:
                    price = 800;
                    Console.WriteLine("You chose a King Bed with Pull-out Couch. Price: R" + price);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Price: R" + price);
                    break;
            }

        }
    }
}
