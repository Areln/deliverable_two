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
        private static bool hasActivity = false;
        private static bool hasNmPeople = false;

        private static string inputActivity = "";
        private static string inputNmPeople = "";

        static void Main(string[] args)
        {

            Console.WriteLine("Hello! What are you in the mood for today?");

            while (!hasActivity)
            {
                Console.WriteLine("Here are your options: \n 1)Action \n 2) Chill times \n 3) Danger \n 4) Good food");
                inputActivity = Console.ReadLine();
                if (inputActivity == "1" || inputActivity == "2" || inputActivity == "3" || inputActivity == "4")
                {
                    hasActivity = true;
                }
                else
                {
                    Console.WriteLine(inputActivity + " Input not understood");
                }
            }

            while (!hasNmPeople)
            {
                Console.WriteLine("How many other people plan on going? \n 1) 0 \n 2) 1-4 \n 3) 5-10 \n 4) 11+");
                inputNmPeople = Console.ReadLine();
                if (inputNmPeople == "1" || inputNmPeople == "2" || inputNmPeople == "3" || inputNmPeople == "4")
                {
                    hasNmPeople = true;
                }
                else
                {
                    Console.WriteLine(inputNmPeople + " Input not understood");
                }
            }

            switch (inputActivity)
            {
                case "1":
                    Console.Write("You could go watch Stock Car Racing. ");
                    break;
                case "2":
                    Console.Write("Hiking can be very relaxing. ");
                    break;
                case "3":
                    Console.Write("Feeling brave enough for sky diving? ");
                    break;
                case "4":
                    Console.Write("The closest Taco bell is open till 2:00 am. ");
                    break;
            }

            switch (inputNmPeople)
            {
                case "1":
                    Console.Write("You should walk in sneakers.");
                    break;
                case "2":
                    Console.Write("You should travel in a sedan. ");
                    break;
                case "3":
                    Console.Write("You should travel in a Volkswagen bus. ");
                    break;
                case "4":
                    Console.Write("You should travel in an airplane. ");
                    break;
            }


            Console.ReadLine();
        }
    }
}
