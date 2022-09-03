using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A jagged array is an array that has inner arrays

            //Creating and initializing jagged array
            int[][] MyArray = new int[3][];
            //3 is the size of the outer array or the array that contains inner arrays

            //adding values to the array

            MyArray[0] = new int[4] {5,4,3,2};     //4 is the size of the inner array

            MyArray[1] = new int[3] { 8, 9, 8 };

            MyArray[2] = new int[5] { 3, 4, 5, 6, 8 };

            //getting values from the array

            //getting the first value in the first in inner array
            int iValue = MyArray[0][0]; 

            Console.WriteLine(iValue);  //output 5


            //Another way of declaring jagged arrays

            //The above array can simply be declared and initialized as follows

            int[][] MyArray2 = new int[3][]
            {
                new int[4] {5,4,3,2},
                new int[3] { 8, 9, 8 },
                new int[5] { 3, 4, 5, 6, 8 }
            };

            //you get values using the same process as above

            //The difference between jagged arrays and 2d arrays
            //With 2d arrays we use [,] one block with a comma to declare the array
            // while with jagged array we use [][] two blocks
            //in a 2d arrays the arrays must be equal, in jagged array they don't have to be equal

            Console.ReadKey();
            Console.WriteLine("Press any key to exit");
        }
    }
}
