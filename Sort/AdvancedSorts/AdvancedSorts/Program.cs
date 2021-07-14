using System;

namespace AdvancedSorts
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] sample = {14,-1,0,1,2,13,2,8,14,9,40,3,6,7,1,30,10,-6};
            MergeSort mergesort = new MergeSort();
            mergesort.Sort(sample, 0, sample.Length - 1);
            foreach (double i in sample)
            {
               Console.Write(i + " ");
            }
        }
    }
}
