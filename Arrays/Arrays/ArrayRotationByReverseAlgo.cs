/* Write a program to rotate an array of length n by d elements to left.
Implement the same using Reversal Algorithm.

Reversal Algorithm Explanation:
Let the array be arr[] = [1, 2, 3, 4, 5, 6, 7], d =2 and n = 7 
A = [1, 2] and B = [3, 4, 5, 6, 7] 
 

Reverse A, we get ArB = [2, 1, 3, 4, 5, 6, 7]
Reverse B, we get ArBr = [2, 1, 7, 6, 5, 4, 3]
Reverse all, we get (ArBr)r = [3, 4, 5, 6, 7, 1, 2]
*/
//-----------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Arrays
{
    class ArrayRotationByReverseAlgo
    {
        static void Main(string[] args)
        {
            int n, d;
            Console.WriteLine("Enter n i.e size of array");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter d i.e by no of times you want to rotate the array");
            d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter elements of array");
            for(int i=0;i<n;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int s;
            
            int[] arrA = new int[d];
            int[] arrB = new int[n-d];
            int[] arrC = new int[arrA.Length + arrB.Length];


            Console.WriteLine("Copying elements till d in Array A");
            for(int i=0;i<arrA.Length;i++)
            {
                arrA[i] = arr[i];
            }

            Console.WriteLine("Elements of Array A");
            for (int i = 0; i < arrA.Length; i++)
            {
                Console.WriteLine(arrA[i]);
            }

            Console.WriteLine("Copying elements from d to n in Array B");
            //for (int i =arr.Length-1; i>d-1; i--)
            //{
            //    arrB[i] = arr[i];
            //}

            Array.Copy(arr, d, arrB, 0, n-d);



            Console.WriteLine("Elements of Array B");
            for (int i = 0; i < arrB.Length; i++)
            {
                Console.WriteLine(arrB[i]);
            }



            Array.Reverse(arrA);

            Console.WriteLine("Reversed elements of B are");

            for(int i=0;i<arrA.Length;i++)
            {
                Console.WriteLine(arrA[i]);
            }


            Array.Reverse(arrB);
            Console.WriteLine("Reversed elements of B are");

            for (int i = 0; i < arrB.Length; i++)
            {
                Console.WriteLine(arrB[i]);
            }



            arrC = arrA.Concat(arrB).ToArray();
            Console.WriteLine("Merged array");
            for (int i = 0; i < arrC.Length; i++)
            {
                Console.WriteLine(arrC[i]);
            }

            Array.Reverse(arrC);
            

            Console.WriteLine("Resultant array is");
            for(int i=0;i<arrC.Length;i++)
            {
                Console.WriteLine(arrC[i]);
            }
        }
    }
}
