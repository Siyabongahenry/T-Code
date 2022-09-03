using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2dTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaring and initializing 2d arrays
            //a two dimension array is an array with arrays inside

            int[,] MyArr = new int[2,3]{ { 5, 8, 3 }, { 9, 6, 7 } };

            //MyArr is an array with a length of 2 with an inner array of a length of 3


            //get values from the 2d array
            //get the first value in the first inner array of MyArray

            int iValue1 = MyArr[0,0]; 

            Console.WriteLine(iValue1.ToString()); //output 5


            //get the third value from the second inner array

            int iValue3 = MyArr[1,2];

 	         //1 is the index of the second inner array,
            //2 is the index of the third value in the second inner array

            Console.WriteLine(iValue3.ToString()); //output 7

            //Another way of declaring 2d arrays

            int[,] MyArray2 = { { 5, 8, 3 }, { 9, 6, 7 } };
            
            //with my array 2 you only specified the values not the lengths
            //you can access values using the same method
           

            //Please notes: All the inner arrays in a 2d arrays must have equal length


            Console.ReadKey();
            Console.WriteLine("Press any key to exit..");
        }
    }
}
