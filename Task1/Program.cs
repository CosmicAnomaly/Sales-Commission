using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1 
            // Scott Robinson

            Console.Write("Please enter the number of sales people you wish to process: "); //Here we identify how many "sales people" will be entered into the system.
            int salesPeopleCount = Convert.ToInt32(Console.ReadLine()); //Converting the string to an integer since all entered information is initially a string. 
            Console.WriteLine(); //Adding an extra line to make the output look better. 

            double classCommission = 0; //Identifying the variable that will eventually be the commission for each salesperson.
            double commissionTotal = 0; //Identifying the variable that will store all comissions entered and be displayed after all sales people are entered.

            while (salesPeopleCount != 0) //Here we tell the loop to run "x" amount of times until the count matches the amount identified at the beginning of the program. 
            {
                Console.Write("Please enter the salespersons name: "); 
                string salesName = Console.ReadLine(); //Giving the name entered a variable.

                Console.Write("Please enter the salespersons number: ");
                string salesNumber = Console.ReadLine(); //Giving the "number" entered a variable.

                Console.Write("Please enter the salespersons sales amount: ");
                double salesAmount = Convert.ToDouble(Console.ReadLine()); //Converting the "string" entered into a double variable to be used for commission calculation.

                Console.Write("Please enter the salespersons class: ");
                int salesClass = Convert.ToInt32(Console.ReadLine()); //Converting the class entered into an integer to be identified later to determine which % commission to use. 
                Console.WriteLine(); //Adding an extra line to make the output look better. 



                if (salesClass >= 5 || salesClass <= 0) //Allows us to notify the user an invalid class was entered, but without breaking the program. The commission will simply not be calculated.
                {
                    Console.WriteLine("You have entered an invalid class, no commission will be calculated!");
                }

                else if (salesClass == 1) //Our first and most complex commission class. 3 separate conditions to check, once identified the commission calculation is done. 
                {
                    if (salesAmount <= 1000) //If the "sales amount" entered, in this run of the loop, is less than or equal to 1000, multiply it by .055 to gain our commission amount. 
                    {
                        classCommission = (salesAmount * .055);
                    }
                    else if (salesAmount > 1000 && salesAmount < 2000) //If the "sales amount" entered, in this run of the loop, is greater than 1000 AND less than 2000, multiply it by .065 to gain our commission amount. 
                    {
                        classCommission = (salesAmount * .065);
                    }
                    else if (salesAmount > 2000) //If the "sales amount" entered, in this run of the loop, is greater than 2000, multiply it by .080 to gain our commission amount. 
                    {
                        classCommission = (salesAmount * .080);
                    }
                    commissionTotal = (classCommission + commissionTotal); //Taking our initial commissionTotal of 0 and adding the most recent classCommission to it. 
                }
                else if (salesClass == 2) //Our second commission class. Only 2 conditions to check for. 
                {
                    if (salesAmount <= 1000) //If the "sales amount" entered, in this run of the loop, is less than or equal to 1000, multiply it by .050 to gain our commission amount.
                    {
                        classCommission = (salesAmount * .050);
                    }
                    else if (salesAmount > 1000) //If the "sales amount" entered, in this run of the loop, is greater than 1000, multiply it by .065 to gain our commission amount.
                    {
                        classCommission = (salesAmount * .065);
                    }
                    commissionTotal = (classCommission + commissionTotal); //Taking our initial commissionTotal of 0 and adding the most recent classCommission to it. 
                }
                else if (salesClass == 3) //No extra conditions, simply multiply by .055 no matter the "sales amount" entered whenever class 3 is entered.
                {
                    classCommission = (salesAmount * .055);
                    commissionTotal = (classCommission + commissionTotal); //Taking our initial commissionTotal of 0 and adding the most recent classCommission to it. 
                }
                else if (salesClass == 4) //No extra conditions, simply multiply by .070 no matter the "sales amount" entered whenever class 4 is entered.
                {
                    classCommission = (salesAmount * .070);
                    commissionTotal = (classCommission + commissionTotal); //Taking our initial commissionTotal of 0 and adding the most recent classCommission to it. 
                }

                Console.WriteLine("Salesperson name: " + salesName);
                Console.WriteLine("Salesperson number: " + salesNumber);
                Console.WriteLine("Salesperson commission: {0:C}", classCommission); //Outputting our commission amount in currency format using a method we learned earlier in the semester. 
                Console.WriteLine(); //Adding an extra line to make the output look better. 

                salesPeopleCount--; //Subtracting 1 count from the number of salespeople to be entered. IE, if the first value entered was 5, the program calls for 5 runs of the loop. At the end of the loop, that number now goes to 4, and so on down to 0 which is our initial while condition. Once at 0 the loop is finished and exited. 
            }

            Console.Write("Commission total: {0:C}", commissionTotal); //Once the while loop condition is no longer true, our total commission is displayed after the variable has been updated while running through the while loop adding commission amounts. 

            Console.ReadKey(); //Still don't entirely understand this, but it allows for the console to stay displayed after the program is finished and allows any key stroke to close the program. 
        }
    }
}
