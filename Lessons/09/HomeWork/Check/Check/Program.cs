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
                Console.WriteLine("Введите скобки на проверку."); //1
                var find = Console.ReadLine();  // 2
                var value = 0; // 2
                var value2 = 0; // 2
                var value3 = 0; // 2

                foreach (var words in find)  // 2+2*N*(2*7)
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

                if ((value|value2|value3) == 0) // 1+1+1+1
                {
                    Console.WriteLine("true");  //1
                }
                else
                {
                    Console.WriteLine("false"); //1
                }

                Console.WriteLine("Программа завершена, нажмите любую клавишу, чтобы продолжить"); //1
                Console.ReadKey();//1
                Console.Clear();//1

                // итог: ?
            }
        }
    }
}
