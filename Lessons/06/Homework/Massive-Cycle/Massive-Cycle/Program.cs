using System;

namespace Massive_Cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                var marks = new[]
{
            new [] { 2, 3, 3, 2, 3},            // Monday (it was a good weekend :)
            new [] { 2, 4, 5, 3},               // Tuesday (anyway better than Monday)
            //null,                               // Wednesday (felt sick, stayed at home :( )
            new [] { 5, 5, 5, 5},               // Thursday (God mode :)
            new [] { 4 }                        // Friday (a very short day)
};
                int len = marks.Length;
                double sum = 0;

                for (int i = 0; i < len; i++)
                {
                    int[] days = marks[i];

                    for (int day = 0; day < days.Length; day++)
                    {
                        sum += days[day];
                    }
                    Console.WriteLine($"The average mark for day {i}: {sum / days.Length}");
                    sum = 0;

                }

            }
           catch(NullReferenceException)
            {
                Console.WriteLine("oops");
                
            }
            Console.ReadKey();
            
        }
    }
}
