using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup
            int totalbottles = 0;
            int numday = 0;
            int numberofbottles = 0;
            bool isNumeric = false;
            double thecost = 0.10;
            double profit = 0;
            string tempnum = string.Empty;
            //input

            do
            {
                numday = numday + 1;
                do
                {
                    
                    Console.WriteLine("How many bottles did you collect on day " + numday + "   Type 0 to finish");
                    tempnum = Console.ReadLine();
                    isNumeric = int.TryParse(tempnum, out int n);
                    // TODO: You should collect bottles for 7 days only and then return the calculation. 
                    if (isNumeric == false)
                    {
                        Console.WriteLine("Please enter a number");
                    }
                } while (isNumeric == false);
                numberofbottles = int.Parse(tempnum);
                totalbottles = totalbottles + numberofbottles;

            //added numday < 7 to let the user only enter 7 days or less 
            } while (numberofbottles != 0 || numday <= 7);


            //processing
            profit = totalbottles * thecost;


            //output
            Console.WriteLine("You collected " + totalbottles + " for a total cost of " + profit);
            Console.ReadLine();
        }
    }
}

