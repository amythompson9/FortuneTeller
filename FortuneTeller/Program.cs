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
            Console.WriteLine("Please tell me how old are you?");
            int userAge = int.Parse(Console.ReadLine());

            //Ask the user for the user’s birth month(as an 'int')
            Console.WriteLine("Please enter the month you were born (as an integer). \n1=January\n2=February\n3=March\n4=April\n5=May\n6=June\n7=July\n8=August\n9=September\n10=October\n11=November\n12=December");
            int birthMonth = int.Parse(Console.ReadLine());

            //Ask the user for the user’s favorite ROYGBIV color
            Console.WriteLine("What is your favorite ROYGBIV color? Enter 'Help' for a list of ROYGBIV colors");
            string favoriteColor = Console.ReadLine();
            if (favoriteColor.ToLower() == "help")
            {
                Console.WriteLine("ROYGBIV colors are \nRed \nOrange \nYellow \nGreen \nBlue \nIndigo \nViolet \nPlease choose a color.");
                favoriteColor = Console.ReadLine().ToLower();
            }

            //Ask the user for the number of siblings the user has
            Console.WriteLine("How many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine());

            //2
            //If the user’s age is an odd number, then they will retire in ____ years, or ___ years if their age is an 
            //even number.
            int retireYears = 0;
            if (userAge % 2 == 1)
            {
                retireYears = 37;
            }
            if (userAge % 2 == 0)
            {
                retireYears = 73;
            }

            //If the user’s number of siblings is 0, then they will have a vacation home in ____(location), 
            //or 1 then they will have a vacation home in ____(location), 
            //or 2 then they will have a vacation home in ____(location), 
            //or 3 then they will have a vacation home in ____(location), 
            //or more than 3 then they will have a vacation home in ____(location).
            //If the user enters a number that is less than 0, they should get a bad vacation home!
            string vacationHome = " ";
            if (siblings == 0)
            {
                vacationHome = "in Iceland...all alone";
            }
            else if (siblings == 1)
            {
                vacationHome = "in Paris";
            }
            else if (siblings == 2)
            {
                vacationHome = "in the beautiful land of Delaware";
            }
            else if (siblings == 3)
            {
                vacationHome = "in Trinidad";
            }
            else if (siblings >= 4)
            {
                vacationHome = "on a far away private island to get away from this giant family";
            }
            else
            {
                vacationHome = "in Arkansas";
            }

            //Depending on which ROYGBIV color is the user’s favorite, 
            //they will have a specific mode of transportation(i.e.car, boat, plane, etc.)
            string transport = "";
            favoriteColor = favoriteColor.ToLower();
            Console.WriteLine(favoriteColor + "Before if statemnets");
            if(favoriteColor == "red")
            {
                transport = "driving the same car you had when you were 22.";
            }
            else if (favoriteColor == "orange")
            {
                transport = "driving a paddle boat shaped like a swan.";
            }
            else if (favoriteColor == "yellow")
            {
                transport = "driving a double-decker tourist bus.";
            }
            else if (favoriteColor == "green")
            {
                transport = "driving a car that is just a little bit too small for you.";
            }
            else if (favoriteColor.ToLower() == "blue")
            {
                transport = "driving very sensible Honda Civic and telling eveyone about the great mileage.";
            }
            else if (favoriteColor == "indigo")
            {
                transport = "driving your grandmother's old car.";
            }

            else if(favoriteColor == "violet")
            {
                transport = "driving one of those old-timey bikes with the one big wheel in the front.";
            }
            else
            {
                transport = "you will be driving for Uber for the rest of your life.";
            }



            //If the user’s birth month is 1 - 4, they will have $____ in the bank; 
            //if the user's birth month is 5-8, they will have $____ in the bank; 
            //and if it is 9-12, then they will have $____ in the bank. 
            //If the user enters something other than 01-12 as their birth month, they will have $0.00 in the bank.
            string money = " ";
            if(birthMonth < 1 || birthMonth > 12)
            {
                money = "0.00 in the bank,";
            }
            else if(birthMonth >= 1 && birthMonth <= 4)
            {
                money = "314.00 in the bank,";
            }
            else if(birthMonth >= 5 && birthMonth <= 8)
            {
                money = "1,000,000.13 in the bank,";
            }
            else if(birthMonth >= 9 && birthMonth <= 12)
            {
                money = "123,456,789.00 in the bank,";
            }

            //3
            //The user’s fortune should be written as such:
            //[First Name]
            //[Last Name]
            //will retire in [# of Years] with [Amount of Money] in the bank, 
            //a vacation home in [Location] and a [Mode of Transportation].
            //Program should be able to handle whether or not a user inputs capital or lowercase letters.

            Console.WriteLine("Thanks for playing. Here is your fortune.");
            Console.WriteLine(firstName + " " + lastName + " will retire in " + retireYears + " years with $" + money + " a vacation home " + vacationHome + " and " + transport);

            //4
            //Give the user the ability to quit the program at any point where the program is looking for user input, 
            //by typing “Quit” (should not be case sensitive).
            //The program should print “Nobody likes a quitter...” before ending.
        }
    }
}
