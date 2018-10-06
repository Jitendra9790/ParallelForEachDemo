using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ParallelForEachDemo
{
    class Program
    {
        static List<int> digits = new List<int>();
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                digits.Add(i);
            }

            Stopwatch sw = Stopwatch.StartNew();
            SequentialForEach();
            sw.Stop();
            Console.WriteLine("Time Taken By Sequential For Each Loop : " + sw.ElapsedMilliseconds);

            sw = Stopwatch.StartNew();
            ParallelForEach();
            sw.Stop();
            Console.WriteLine("Time Taken By Parallel For Each Loop : " + sw.ElapsedMilliseconds);

            Console.ReadKey();
        }

        public static void SequentialForEach()
        {
            foreach (int i in digits)
            {
                Console.WriteLine("Sequential For Each : " + i);
            }
        }

        public static void ParallelForEach()
        {
            Parallel.ForEach(digits, i => 
            { 
                Console.WriteLine("Parallel For Each : " + i); 
            });
        }
    }
}
