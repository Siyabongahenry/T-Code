using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchTutorial
{
    internal class Program
    {
        static void Main()
        {
            //a try catch prevent errors from breaking your program at runtime

           
            //In this program we ask a user to give us his/her age
            Console.Write("Please type your age and press enter to continue:");

            //we take the age and store it in an integer variable called iAge
            int iAge = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\nYou are " + iAge.ToString() + " years old.");
           
            //int.Parse() convert strings to integer numbers
            //Console.ReadLide get the user input from the console in a string format

            //After getting his/her age we print out a message in the screen

            
            Console.WriteLine("\n\n\nPress any key to restart the program...");
            Console.ReadKey();
            //The code below restart the program but you can ignore it
            Console.Clear();
            Main();
        }
    }
}
