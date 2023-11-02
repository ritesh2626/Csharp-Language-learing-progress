using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpArray
{
    internal class Array
    {
        static void Main(string[] args)
        {
            //create array in csharp 
            int[] arr;
            arr = new int[10];

            // assign values in array 

            arr[0] = 12;
            arr[1] = 14;
            arr[2] = 11;
            arr[3] = 65;
            arr[4] = 72;
            arr[5] = 23;
            arr[6] = 53;
            arr[7] = 223;
            arr[8] = 233;
            arr[9] = 45;

            // printing array values

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("The value of {0} index is {1}", i, arr[i]);
            }

            // printing array values with the help of foreach
            int j = 0;
            foreach (int val in arr)
            {
                Console.WriteLine("The value of {0} index is {1}", j, val);
                j++;
            }

            // printing array values with the help of while Loop

            int itr = 0;
            while (itr < arr.Length)
            {
                Console.WriteLine("The value of {0} index is {1}", itr, arr[itr]);
                itr = itr + 1;

            }

            Console.WriteLine("Size of Array is = {0}", arr.Length);


            Console.ReadLine();



        }
    }
}
