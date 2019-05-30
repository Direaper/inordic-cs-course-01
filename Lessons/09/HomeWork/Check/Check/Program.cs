using System;
using System.Collections.Generic;
namespace Check
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Введите скобки на проверку.");
                var find = Console.ReadLine();
                var value = 0;
                var value2 = 0;
                var value3 = 0;

                foreach (var words in find)
                {
                    if (words == '(')
                    {
                        value++;
                    }
                    else if (words == ')')
                    {
                        value--;
                    }
                    else if (words == '{')
                    {
                        value2++;
                    }
                    else if (words == '}')
                    {
                        value2--;
                    }
                    else if (words == '[')
                    {
                        value3++;
                    }
                    else if (words == ']')
                    {
                        value3--;
                    }

                    else
                    {
                        Console.WriteLine("Вы ввели иное значение");
                        value--;
                    }
                }

                if ((value|value2|value3) == 0)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

                Console.WriteLine("Программа завершена, нажмите любую клавишу, чтобы продолжить");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
