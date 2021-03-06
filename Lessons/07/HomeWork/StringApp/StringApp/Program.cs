﻿using System;

namespace StringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите строку из нескольких слов. Введите слово exit для выхода из цикла");
                var input = Console.ReadLine();
                int value = 0;
                string[] words = input.Split(' ');
                if (input == "exit")
                {
                    Console.WriteLine("Спасибо за то что использовали программу компании KOSARPLE. До новых встреч");
                    Console.ReadKey();
                    break;
                }

                if (words.Length == 1)
                {
                    Console.WriteLine("Вы ввели слишком мало слов, попробуйте еще раз!");
                    break;
                }
 
                foreach (string word in words)
                {
                    var searchA = word.StartsWith("А") | word.StartsWith("а") | word.StartsWith("A") | word.StartsWith("a");
                    if (searchA == true)
                    {
                        value++;
                    }
                }

                Console.WriteLine($"В тексте {value} слов начинающихся на букву А");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
