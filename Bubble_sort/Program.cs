namespace Bubble_sort
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    public class Program
    {
       public static int[] Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++) 
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int buf = arr[j]; 

                        arr[j] = arr[j + 1];

                        arr[j + 1] = buf;
                    }
                }
            }

            return arr;
        }

       public static void Main(string[] args)
        {
           Random random = new Random();

            const int N = 100000;

            int[] perm = Enumerable.Range(0, N).ToArray(); 

            for (int i = N - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                int temp = perm[j];
                perm[j] = perm[i];
                perm[i] = temp;
            }
           
           perm = Sort(perm);         
           
            for (int i = 0; i < perm.Length; i++) 
            {
                Console.WriteLine(perm[i]);
            }

            Console.ReadKey();
        }
    }
}
