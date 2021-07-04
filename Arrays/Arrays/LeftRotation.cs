using System;

namespace Arrays
{
    class LeftRotation
    {
        static void Main(string[] args)
        {
            int n,temp;
            Console.WriteLine("Enter size");

            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Enter elements of array");

            for(int i=0;i<n;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int d;
            Console.WriteLine("Enter how many time you want to Left rotate the Array");
            d = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Elements of array before");
                
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            

            for(int i=0;i<d;i++)
            {
                temp = arr[0];
                for (int j=0;j<n-1;j++)
                {
                    
                    arr[j] = arr[j + 1];
                    
                }
                arr[n - 1] = temp;
            }

            Console.WriteLine("Elements of array are");

            for(int i=0;i<n;i++)
            {
                Console.WriteLine(arr[i]);
            }
           
        }
    }
}
