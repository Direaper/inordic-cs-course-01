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
            }


            for (int i = 0, j = values.Length - 1; j >= 0; j--, i++)
            {
                temp[i] = values[j];
            }
            for (int i = 0; i < values.Length; i++)
            {
                Console.Write($"{temp[i].ToLower()}");

            }

            Console.ReadKey();
        }
    }
}