using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {  
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter n");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[5];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = (i + 1) * n;
            }
            JumpIndexyBy(arr, n);
            ReverseArrayByWidth(arr, n);
            PrintArray(arr);
            Console.ReadKey();
        }

        private static void PrintArray(int[] arr)
        {
            Console.WriteLine("Print Array");
            for (int k = 0; k < arr.Length; k++)
            {
                Console.WriteLine(arr[k]);
            }
        }

        //[ 1, 2 , 3 , 4 , 5 , 6 , 7 , 8 , 9 ]
        // n = 2 =>1, 3, 5, 9
        //n = 5 => 1 , 6
        // n = 3 => 1 , 4 




        private static void JumpIndexyBy(int[] arr, int n)
        {

        }

        //[ 1, 2 , 3 , 4 , 5 , 6 , 7 , 8 , 9 ]
        // n = 3; [3,2,1,6,5,4,9,8,7]
        private static void ReverseArrayByWidth(int[] arr, int n)
        {

        }
    }
}
