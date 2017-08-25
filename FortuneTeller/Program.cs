using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //0
            //Correct GitHub link is properly submitted
            //GitHub repository created from correct folder and contains solution file

            //1
            //Ask the user for the user’s first name
            Console.WriteLine("Please enter your first name.");
            string firstName = Console.ReadLine();
            //Ask the user for the user’s last name
            Console.WriteLine("Please enter your last name.");
            string lastName = Console.ReadLine();
            //Ask the user for the user’s age
            Console.WriteLine("Please enter your age.");
            int userAge = int.Parse(Console.ReadLine());
            //Ask the user for the user’s birth month(as an 'int')
            Console.WriteLine("Please enter the month you were born.");
            int birthMonth = int.Parse(Console.ReadLine());
            //Ask the user for the user’s favorite ROYGBIV color
            Console.WriteLine("What is your favorite ROYGBIV color? \nFor a list of ROYGBIV colors, please type 'Help'.");
            //If the user does not know what ROYGBIV is, ask them to enter “Help” to get a list of the ROYGBIV colors
            string favoriteColor = (Console.ReadLine());
            string askHelp = "help.ToLower";
            if (favoriteColor == "help")
            {
                Console.WriteLine("ROYGBIV colors are \nRed \nOrange \nYellow \nGreen \nBlue \nIndigo \nViolet \nPlease choose a color.");
            }
            else
            {
                string colorHelp = (Console.ReadLine());
            }
            
            //Ask the user for the number of siblings the user has
            Console.WriteLine("How many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine());

            //2
            //If the user’s age is an odd number, then they will retire in ____ years, or ___ years if their age is an 
            //even number.
            int retireTime = 0;
            if (userAge %2 == 1)
            {
                retireTime = 37;
            } 
            if (userAge % 2 == 0)
            {
                retireTime = 73;
            }
            //If the user’s number of siblings is 0, then they will have a vacation home in ____(location), 
            //or 1 then they will have a vacation home in ____(location), 
            //or 2 then they will have a vacation home in ____(location), 
            //or 3 then they will have a vacation home in ____(location), 
            //or more than 3 then they will have a vacation home in ____(location).
            string numberSiblings;
            if (siblings == 0)
            {
                numberSiblings = "Iceland...all alone";
            }
            if (siblings == 1)
            {
                numberSiblings = "Paris";
            }
            if (siblings == 2)
            {
                numberSiblings = "the beautiful land of Delaware";
            }
            if (siblings == 3)
            {
                numberSiblings = "Trinidad";
            }
            if (siblings > 4)
            {
                numberSiblings = "a far away private island to get away from this giant family";
            }
            if (siblings < 0)
            {
                numberSiblings = "Arkansas";
            }
            else
            {
                numberSiblings = "a place as imaginary as your siblings";
            }
            //If the user enters a number that is less than 0, they should get a bad vacation home!
            //Depending on which ROYGBIV color is the user’s favorite, 
            //they will have a specific mode of transportation(i.e.car, boat, plane, etc.)

            //If the user’s birth month is 1 - 4, they will have $____ in the bank; 
            //if the user's birth month is 5-8, they will have $____ in the bank; 
            //and if it is 9-12, then they will have $____ in the bank. 
            //If the user enters something other than 01-12 as their birth month, they will have $0.00 in the bank.

            //3
            //The user’s fortune should be written as such:
            //[First Name]
            //[Last Name]
            //will retire in [# of Years] with [Amount of Money] in the bank, 
            //a vacation home in [Location] and a [Mode of Transportation].
            //Program should be able to handle whether or not a user inputs capital or lowercase letters.
            //string fullName = string.Concat(firstName, " ", lastName)
            Console.WriteLine("Thanks for playing. Here is your fortune.");

            Console.WriteLine(firstName + " " + lastName + " " + "will retire in" + " " + retireTime + " " + "years with" + " " + moneyAmount);
            //Console.WriteLine("string fullname);
            //4
            //Give the user the ability to quit the program at any point where the program is looking for user input, 
            //by typing “Quit” (should not be case sensitive).
            //The program should print “Nobody likes a quitter...” before ending.
        }
    }
}
