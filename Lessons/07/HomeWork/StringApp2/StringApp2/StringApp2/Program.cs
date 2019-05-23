using System;

namespace StringApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку из нескольких слов");
            var input = Console.ReadLine();
            string[] words = input.Split(' ');
            int len = words.Length;

            for (int i = len; i > 0; i--)
            {
                Console.WriteLine(words[i]);
            }

            Console.ReadKey();
        }
    }
}
