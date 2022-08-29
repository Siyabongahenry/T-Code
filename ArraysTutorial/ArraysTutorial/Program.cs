using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare an array of integers
            int[] MyArray = new int[3];
            //MyArray is the name of the array, you could use any name
            //3 is the lenth of the array


            //adding values to the array
            MyArray[0] = 2;
            MyArray[1] = 3;
            MyArray[2] = 6;
            //the size of MyArray is 3 thus we have to stop at MyArray[2]
            //if you try to add a value at MyArray[3] you will get an error
        
           

            //getting the first value from the array
            int iValue1 = MyArray[0]; //0 is the index/position of the value in the array
            Console.WriteLine(iValue1.ToString()); //output 2
            //you can get more values my increrasing the index, remember the maximum index is 3

            //increase the size of the array
            Array.Resize(ref MyArray, 5);
            //MyArray can now take 6 values remember we count starting from 0
            //we can now do something like MyArray[4]=6, but we can't do something ike MyArray[5]=9 since 5 is the length.


            //Another way of creating an array
            int[] MyArray2 = { 5, 3, 6, 5 };

            //getting values from the Array
            int iArr2Value = MyArray2[0];
            Console.WriteLine(iArr2Value.ToString()); //output 5

            //getting the length of the array
            int iArr2Length = MyArray2.Length;
            Console.WriteLine(iArr2Length.ToString());//output 4
            
            //In  MyArray2 the length of the array is automatically set to 4 since only have 4 values
            //you can increase the size the same way above

            Console.ReadKey();
            Console.WriteLine("Press any key to continue");
            

        }
    }
}
