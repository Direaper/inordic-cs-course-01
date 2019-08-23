using System;

namespace StringApp_new
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите любое слово для инверсии");
                string value = Console.ReadLine();

                string correctionFormat = value.ToLower();
                for (int b = correctionFormat.Length; b > 0; b--)
                {
                    Console.Write(correctionFormat[b - 1]);
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

