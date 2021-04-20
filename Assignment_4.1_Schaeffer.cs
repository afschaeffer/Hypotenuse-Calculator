// Amy Schaeffer
// Program that calculates the hypotenuse of a triangle
using System;

namespace Assignment_4_Schaeffer_CIS243
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) // starting loop
            {
                Console.Write("enter length of first side: "); //prompt for side one
                double side_1 = Convert.ToDouble(Console.ReadLine()); // reading and converting side 1
                Console.Write("enter length of second side: "); // prompt for side 2
                double side_2 = Convert.ToDouble(Console.ReadLine()); // reading and converting side 2

                if (side_1 == 0 && side_2 == 0) //if statement with conditions of both side 1 and 2 being entered as 0
                {
                    break; // breaking while loop if user enters both side 1 and 2 as 0
                }
                    
                double sqrd1 = Math.Pow(side_1, 2); // squaring side 1
                double sqrd2 = Math.Pow(side_2, 2); // squaring side 2
                double hyp_sqrd = sqrd1 + sqrd2; // adding squared side values
                double hyp = Math.Sqrt(hyp_sqrd); // taking square root of sides added together

                Console.WriteLine("The hypotenuse is " + hyp); // displaying hypotenuse
            }
                
        }
    }
}
