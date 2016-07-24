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

        public static TimeSpan Benchmark(int count)
        {
            int[] array = new int[count];

            Random rand = new Random();

            for (int x = 0; x < array.Length; x++)
            {
                array[x] = rand.Next(1, 500);
            }

            var time = Stopwatch.StartNew();

            array = Sort(array);

            time.Stop();

            return time.Elapsed;
        }

       public static void Main(string[] args)
        {
            Console.WriteLine(Benchmark(5));

            Console.WriteLine(Benchmark(100));

            Console.WriteLine(Benchmark(500));

            Console.WriteLine(Benchmark(10000));

            Console.WriteLine(Benchmark(100000));

            Console.ReadKey();
        }
    }
}
