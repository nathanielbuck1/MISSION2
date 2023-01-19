//using System;
//using System.Collections.Generic;

//namespace MISSION2
//{
//    class Program
//    {

//        static void Main(string[] args)
//        {


//            int i, j, k;
//            Class1 rand = new Class1();
//            Random r = new Random();


//            string amt = "";
//            Console.WriteLine("Welcome to the dice throwing simulator!");
//            Console.WriteLine(" ");
//            Console.WriteLine("How many dice rolls would you like to simulate?");
//            amt = Console.ReadLine();
//            int num = Convert.ToInt32(amt);


//            //creating and loading the array
//            int[] diceArray = new int[num];

//            /* initialize elements of array n */
//            for (i = 0; i < num; i++)
//            {
//                diceArray[r.Next(1, 7) + r.Next(1, 7)]++;
//            }
//            //output each array element's value 
//            for (j = 0; j < num; j++)
//            {
//                Console.WriteLine("Element[{0}] = {1}", j, diceArray[j]);
//            }

//            // this is the array counter
//            int two = 0;
//            int three = 0;
//            int four = 0;
//            int five = 0;
//            int six = 0;
//            int seven = 0;
//            int eight = 0;
//            int nine = 0;
//            int ten = 0;
//            int eleven = 0;
//            int tweleve = 0;
//            // This is the divison thingy
//            int onep;
//            int twop;
//            int threep;
//            int fourp;
//            int fivep;
//            int sixp;
//            int sevenp;
//            int eightp;
//            int ninep;
//            int tenp;
//            int elevenp;
//            int twelevep;

//            //for (k = 0; k < num; k++) { 
//            //    if (diceArray[k] == 2)
//            //    {
//            //        two = two +1;
//            //    }
//            //    else if (diceArray[k] == 3)
//            //    {
//            //        three = three +1;
//            //    }
//            //    else if (diceArray[k] == 4)
//            //    {
//            //        four = four +1;
//            //    }
//            //    else if (diceArray[k] == 5)
//            //    {
//            //        five = five +1;
//            //    }
//            //    else if (diceArray[k] == 6)
//            //    {
//            //        six = six +1;
//            //    }
//            //    else if (diceArray[k] == 7)
//            //    {
//            //        seven = seven + 1;
//            //    }
//            //    else if (diceArray[k] == 8)
//            //    {
//            //        eight = eight + 1;
//            //    }
//            //    else if (diceArray[k] == 9)
//            //    {
//            //        nine = nine + 1;
//            //    }
//            //    else if (diceArray[k] == 10)
//            //    {
//            //        ten = ten + 1;
//            //    }
//            //    else if (diceArray[k] == 11)
//            //    {
//            //        eleven = eleven + 1;
//            //    }
//            //    else if (diceArray[k] == 12)
//            //    {
//            //        tweleve = tweleve + 1;
//            //    }
//            //}

//            Console.WriteLine("2 :" + diceArray[2]);
//            //Console.WriteLine("3 :" + three);
//            //Console.WriteLine("4 :" + four);
//            //Console.WriteLine("5 :" + five);
//            //Console.WriteLine("6 :" + six);
//            //Console.WriteLine("7 :" + seven);
//            //Console.WriteLine("8 :" + eight);
//            //Console.WriteLine("9 :" + nine);
//            //Console.WriteLine("10 :" + ten);
//            //Console.WriteLine("11 :" + eleven);
//            //Console.WriteLine("12 :" + tweleve);


//            //twop = ((two * 100 / num * 100) / 100);
//            //threep = ((three * 100 / num * 100) / 100);
//            //fourp = ((four * 100 / num * 100) / 100);
//            //fivep = ((five * 100 / num * 100) / 100);
//            //sixp = ((six * 100 / num * 100) / 100);
//            //sevenp = ((seven * 100 / num * 100) / 100);
//            //eightp = ((eight * 100 / num * 100) / 100);
//            //ninep = ((nine * 100 / num * 100) / 100);
//            //tenp = ((ten * 100 / num * 100) / 100);
//            //elevenp = ((eleven * 100 / num * 100) / 100);
//            //twelevep = ((tweleve * 100 / num * 100) / 100);


//            //Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
//            //Console.WriteLine("Each '*' represents 1 % of the total number of rolls.");
//            //Console.WriteLine("Total number of rolls = " + num);

//            //Console.WriteLine("");
//            //Console.Write("2: ");
//            //for (k = 0; k < twop; twop--)
//            //{
//            //    Console.Write("*");
//            //}
//            //Console.WriteLine("");
//            //Console.Write("3: ");
//            //for (k = 0; k < threep; threep--)
//            //{
//            //    Console.Write("*");
//            //}
//            //Console.WriteLine("");
//            //Console.Write("4: ");
//            //for (k = 0; k < fourp; fourp--)
//            //{
//            //    Console.Write("*");
//            //}
//            //Console.WriteLine("");
//            //Console.Write("5: ");
//            //for (k = 0; k < fivep; fivep--)
//            //{
//            //    Console.Write("*");
//            //}
//            //Console.WriteLine("");
//            //Console.Write("6: ");
//            //for (k = 0; k < sixp; sixp--)
//            //{
//            //    Console.Write("*");
//            //}
//            //Console.WriteLine("");
//            //Console.Write("7: ");
//            //for (k = 0; k < sevenp; sevenp--)
//            //{
//            //    Console.Write("*");
//            //}
//            //Console.WriteLine("");
//            //Console.Write("8: ");
//            //for (k = 0; k < eightp; eightp--)
//            //{
//            //    Console.Write("*");
//            //}
//            //Console.WriteLine("");
//            //Console.Write("9: ");
//            //for (k = 0; k < ninep; ninep--)
//            //{
//            //    Console.Write("*");
//            //}
//            //Console.WriteLine("");
//            //Console.Write("10: ");
//            //for (k = 0; k < tenp; tenp--)
//            //{
//            //    Console.Write("*");
//            //}
//            //Console.WriteLine("");
//            //Console.Write("11: ");
//            //for (k = 0; k < elevenp; elevenp--)
//            //{
//            //    Console.Write("*");
//            //}
//            //Console.WriteLine("");
//            //Console.Write("12: ");
//            //for (k = 0; k < twelevep; twelevep--)
//            //{
//            //    Console.Write("*");
//            //}
//            //Console.WriteLine("");
//            //Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
//        }
//    }
//}

