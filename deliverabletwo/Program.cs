//Aaron Anderson

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deliverabletwo
{
    class Program
    {

        private static Int32 inputActivity = 0;
        private static Int32 inputNmPeople = 0;

        static void Main(string[] args)
        {

            Console.WriteLine("Hello! What are you in the mood for today?");

            while (inputActivity == 0)
            {
                Int32 input = 0;
                Console.WriteLine("Here are your options: \n 1)Action \n 2) Chill times \n 3) Danger \n 4) Good food");
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Input was not a number");
                    input = 0;
                    continue;
                }
                if (input == 1 || input == 2 || input == 3 || input == 4)
                {
                    inputActivity = input;
                }
                else
                {
                    Console.WriteLine("Input was not understood");
                }
            }

            while (inputNmPeople == 0)
            {
                Int32 input = 0;
                Console.WriteLine("How many other people plan on going?");
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Input was not a number");
                    input = 0;
                    continue;
                }
                if (input >= 0)
                {
                    inputNmPeople = input;
                }
                else
                {
                    Console.WriteLine("Input not understood");
                }
            }

            Console.Write("Okay! If you are in the mood for ");

            switch (inputActivity)
            {
                case 1:
                    Console.Write("action, you could go watch Stock Car Racing. ");
                    break;
                case 2:
                    Console.Write("chill times, hiking can be very relaxing. ");
                    break;
                case 3:
                    Console.Write("Danger, are you feeling brave enough for sky diving? ");
                    break;
                case 4:
                    Console.Write("Good food, the closest Taco bell is open till 2:00 am. ");
                    break;
            }

            if (inputNmPeople == 0)
            {
                Console.Write("You should walk in sneakers.");
            }else if (inputNmPeople > 0 && inputNmPeople <= 4)
            {
                Console.Write("You should travel in a sedan. ");
            }else if (inputNmPeople > 4 && inputNmPeople <= 10)
            {
                Console.Write("You should travel in a Volkswagen bus. ");
            }
            else if (inputNmPeople > 10)
            {
                Console.Write("You should travel in an airplane. ");
            }


            Console.ReadLine();
        }
    }
}
