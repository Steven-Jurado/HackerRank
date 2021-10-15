namespace HackerRank
{
    using System;
    using System.Collections.Generic;

    // this a test of HackerRank
    class Program
    {
        static void Main(string[] args)
        {
            BriBirthdayCakeCandles();
            Console.WriteLine( TimeConversion( Console.ReadLine() ) );
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

        static string TimeConversion( string time )
        {
            
            if (time != null)
            {
                string hourString = time.Split(':')[0] ;

                if (time.Contains("PM"))
                {
                    var hourInteger = int.Parse(hourString);

                    Dictionary<int, string> hours = new Dictionary<int, string>();

                    hours.Add(1,"13");
                    hours.Add(2,"14");
                    hours.Add(3,"15");
                    hours.Add(4,"16");
                    hours.Add(5,"17");
                    hours.Add(6,"18");
                    hours.Add(7,"19");
                    hours.Add(8,"20");
                    hours.Add(9,"21");
                    hours.Add(10,"22");
                    hours.Add(11,"23");
                    hours.Add(12,"12");
                    
                    foreach (var hour in hours)
                    {

                        if (hourInteger == hour.Key)
                        {     
                            return hour.Value+time.Substring(2,time.Length-4);
                        }

                    }
                }
                else
                {
                    if (time.Contains("AM"))
                    {
                        int hourInteger = int.Parse(hourString);

                        if (hourInteger == 12)
                        {
                            return "00"+time.Substring(2,time.Length-4);
                        }

                        return time.Substring(0, time.Length-2);
                    }
                }

            }

            return "Ingrese un valor porfavor.";

        }
    }
}
