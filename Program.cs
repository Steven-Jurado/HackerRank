using System;

namespace HackerRank
{
    // this a test of HackerRank
    class Program
    {
        static void Main(string[] args)
        {
            BriBirthdayCakeCandles();
        }

        
        static void  BriBirthdayCakeCandles()
        {
            int n = int.Parse(Console.ReadLine());
            int[] candles = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);

            int maxHeight = 0;
            int maxHeightCandles = 0;

            for (int i = 0; i < n; i++)
            {
                if (candles[i] > maxHeight)
                {
                    maxHeight = candles[i];
                    maxHeightCandles = 1;
                }
                else if (candles[i] == maxHeight)
                {
                    maxHeightCandles++;
                }
            }

            Console.WriteLine(maxHeightCandles);
        }
    }
}
