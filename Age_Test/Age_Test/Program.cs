using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //writing test program to check user feedback input and output.
            Console.Write("What is your age?");
            
            //I want to have the user input and use it to compare.
            string ageUserInputString = Console.ReadLine();

            int ageUser = int.Parse(ageUserInputString);

            int ageKatyPerry = 33;

            if(ageUser > 33)
            {
                Console.Write("You are younger than Katy Perry");
            }
            else if (ageUser == ageKatyPerry)
            {
                Console.Write("You are the same age as Katy Perry");
            }
            else if (ageUser < 0)
            {
                Console.Write("Try again...");
             
            }
            else
            {
                Console.Write
                    ("You are younger than Katy Perry.");
            }
            Console.ReadLine();  
        }
    }
}
