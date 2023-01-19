using System;
using System.Collections.Generic;

namespace MISSION2
{
    //Written by Nathaniel Buck, Section 4 group 10
    class Program
    {
        
        static void Main(string[] args)
        {

            // declaring my variables
            int i,k;
            // Creating the random num generator stuff
            Random r = new Random();
            // twop = percentage of Two, threep = Percentage of three....
            int twop;
            int threep;
            int fourp;
            int fivep;
            int sixp;
            int sevenp;
            int eightp;
            int ninep;
            int tenp;
            int elevenp;
            int twelevep;

            // greetings
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine(" ");
            Console.WriteLine("How many dice rolls would you like to simulate?");
            //read the amount and then set that amount froma  string to an integer
            string amt = Console.ReadLine();
            int num = Convert.ToInt32(amt);


            //creating and loading the array
            int[] diceArray = new int[13];

            // initialize elements of array n 
            for (i = 0; i < num; i++)
            {
                diceArray[r.Next(1, 7) + r.Next(1, 7)]++;
            }

            // setting the varibales to the percentage values that each was rolled
            twop = ((diceArray[2] * 100 / num * 100) / 100);
            threep = ((diceArray[3] * 100 / num * 100) / 100);
            fourp = ((diceArray[4] * 100 / num * 100) / 100);
            fivep = ((diceArray[5] * 100 / num * 100) / 100);
            sixp = ((diceArray[6] * 100 / num * 100) / 100);
            sevenp = ((diceArray[7] * 100 / num * 100) / 100);
            eightp = ((diceArray[8] * 100 / num * 100) / 100);
            ninep = ((diceArray[9] * 100 / num * 100) / 100);
            tenp = ((diceArray[10] * 100 / num * 100) / 100);
            elevenp = ((diceArray[11] * 100 / num * 100) / 100);
            twelevep = ((diceArray[12] * 100 / num * 100) / 100);

            //display the words
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1 % of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + num);

            //display the graph
            Console.WriteLine("");
            Console.Write("2: ");
            for (k = 0; k < twop; twop--)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            Console.Write("3: ");
            for (k = 0; k < threep; threep--)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            Console.Write("4: ");
            for (k = 0; k < fourp; fourp--)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            Console.Write("5: ");
            for (k = 0; k < fivep; fivep--)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            Console.Write("6: ");
            for (k = 0; k < sixp; sixp--)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            Console.Write("7: ");
            for (k = 0; k < sevenp; sevenp--)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            Console.Write("8: ");
            for (k = 0; k < eightp; eightp--)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            Console.Write("9: ");
            for (k = 0; k < ninep; ninep--)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            Console.Write("10: ");
            for (k = 0; k < tenp; tenp--)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            Console.Write("11: ");
            for (k = 0; k < elevenp; elevenp--)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            Console.Write("12: ");
            for (k = 0; k < twelevep; twelevep--)
            {
                Console.Write("*");
            }

            //say bye
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
        }
        }

