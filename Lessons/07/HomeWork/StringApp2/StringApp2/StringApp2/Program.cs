using System;

namespace StringApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку из нескольких слов");
            var input = Console.ReadLine();
            string[] values = new string[input.Length];
            string[] temp = new string[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                values[i] = Convert.ToString(input[i]);
                //Console.Write($"{values[i]}");
            }

            Console.WriteLine($"\n part two\n");

            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 1; j < values.Length; j++)
                {
                    temp[i] = values[i];
                    values[i] = values[j];
                    values[j] = temp[i];

                }  
                
            } 

            for (int i = 0; i < values.Length; i++)
            {
                Console.Write($"{values[i]}");

            }


            Console.ReadKey();
        }
    }
}
