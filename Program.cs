using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerForTheAges
{
    class Program
    {
        static string Wash(string userInput)    //method for case sensitivty 
        {

            userInput = userInput.ToLower();
            userInput = userInput.Trim();
            

            return userInput;
        }
        static void programStop(string personInput)   //method for quit at any time
        {
            

            if (Wash(personInput) == "quit")  
            {
                Console.WriteLine("OMG Nobody Likes A Quitter");
                Environment.Exit(0);
            }
                

        }
        static void Main(string[] args)
        {
            //----------------------------------------------------
            bool answer = true;
            string response = "";


            do
            {

                //Ask for user first name & Last Name 
                Console.WriteLine("Please be nice and enter your first name:  ");
                string userFirstName = Console.ReadLine();
                programStop (userFirstName);
                //userFirstName//userLastName
                Console.WriteLine("Ok, now please enter your last name:  ");
                string userLastName = Console.ReadLine();
                 string fullName = userFirstName + " " + userLastName;
                 userFirstName = Wash(userFirstName);
                 userLastName = Wash(userLastName);
                programStop(userLastName);
                //Ask for user age
                Console.WriteLine("What an awesome name! Now please enter your age:  ");
                string numAge = Console.ReadLine();
                programStop(numAge);
                int userAge = int.Parse(numAge);
                //userAge
                Console.WriteLine("Oooo, what an interesting age, now what month were you born?  ");
                string userBirthMonth = Wash(Console.ReadLine());
                //Ask for users Birth Month
                //userBirthMonth
                Console.WriteLine("Now, tell the sweet little Fortune Teller your favorite ROYGBIV color:  ");
                Console.WriteLine("If you need help type \"Help\"");
                string userColor = Wash(Console.ReadLine());
                programStop(userColor);
                if (userColor == "help")
                {
                    Console.WriteLine("Red,Orange,Yellow,Green,Blue,Indigo,Violet");
                    Console.WriteLine("Now, did that help? Please enter ROYGBIV: ");
                    userColor = Wash(Console.ReadLine());
                }
                //Ask user for Fav color //if ask for 'help', then print ROYGBIV(type words)
                //move to if statement 

                //Ask user for # siblings // userSiblings
                Console.WriteLine("How many siblings do you have my dear? ");
                string numSib = Console.ReadLine();
                programStop(numSib);
                int numberOfSibling = int.Parse(numSib);

                //initialize array called transportArray
                string[] transportArray = { "pink bicycle", "vespa", "SUV", "segway", "private jet", "skateboard", "wheel barrel" };
                //initialize array called yearsRetiredArray
                string[] yearsRetiredArray = { "15", "30" };
                //initialize array called locationArray
                string[] locationArray = { "Portland", "Borneo", "Belize", "Parma", "North Pole" };
                //initialize array called moneyITBAray
                string[] moneyITBAray = { "2.50", "100,000", "500,000", "1,000,000" };

                //initialize variable called yearsRetired
                string yearsRetired = "";
                //initialize variable called location
                string location = "";
                //initialize variable called moneyITB
                string moneyITB = "";
                //initialize variable called transport
                string transport = "";
                //initial first and last name in one string

                //RETIREMENT, ODD NUMBERS
                if (userAge % 2 == 1)
                    yearsRetired = yearsRetiredArray[0];
                else
                    yearsRetired = yearsRetiredArray[1];

                //LOCATION, NUMBER OF SIBLINGS
                switch (numberOfSibling)
                {
                    case 0:
                        location = locationArray[0];
                        break;
                    case 1:
                        location = locationArray[1];
                        break;
                    case 2:
                        location = locationArray[2];
                        break;
                    case 3:
                        location = locationArray[3];
                        break;
                    default:
                        location = locationArray[4];
                        break;
                }


                //TRANSPORTATION, COLOR

                //MONEY IN THE BANK, FIRST AND LAST NAME
                //foreach through each letter in first and last name
                foreach (char letter in fullName)
                {
                    if (userBirthMonth[0] == letter)
                    {
                        moneyITB = moneyITBAray[0];
                        break;
                    }
                    if (userBirthMonth[1] == letter)
                    {
                        moneyITB = moneyITBAray[1];
                        break;
                    }
                    if (userBirthMonth[2] == letter)
                    {
                        moneyITB = moneyITBAray[2];
                        break;
                    }
                    else
                    {
                        moneyITB = moneyITBAray[3];
                    }
                }
               
                //using *transportArray*
                string[] colorArray = { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };

                for (int i = 0; i < 7; i++)
                {
                    if (userColor == colorArray[i])
                    {
                        transport = transportArray[i];
                    }
                }
                Console.WriteLine(fullName + " will retire in " + yearsRetired + " years with $" + moneyITB + " in the bank, a vacation home in " + location + " and a " + transport + ".");


                Console.WriteLine("\nWould you like another fortune my dear? ");
                response = Console.ReadLine();
                programStop(response);
                if (response == "no" || response == "No")
                {
                    answer = false;
                }
            }


            while (answer);









            //if statemnet//intitilize array called=transport,yearsRetired,location,moneyItb
            //for money in the bank portion use "if else" within Foreach Loop through each letter--
            //variable for part3 yearsretired 


            //part3 large string with concatination 

            //do while loop for asking if you want to play again.---------------whole program should be in While loop





        } 
    }
}
