using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_calculator
{
	class Program
	{
        static void Main(string[] args)
        {
            for (; ; )                                                          //Цикл для возвращения в начало программы
            {
                Console.WriteLine($"Добро пожаловать в программу Калькулятор. Введите первое число"); 
                double a = Convert.ToDouble(Console.ReadLine());                          // вводим первое число
                Console.WriteLine();                                  // Перевод строки. Да-да.. я знаю, что это индуский код, но я не успел нагуглить как ставить пустую строку
                Console.WriteLine($"Введите второе число");
                double b = Convert.ToDouble(Console.ReadLine());                         // вводим второе число
                Console.WriteLine();                                 // Опять перевод строки
                Console.WriteLine($"Отлично! Вы ввели {a} и {b}. Выберете операцию: 1 = плюс, 2 = минус, 3 = деление, 4 = умножение, 5 = остаток от деления, 6 = возведение в степень."); 
                int c = Convert.ToInt32(Console.ReadLine());            //пользователь вводит значение, для выбора операции
                                                                        //Далее идет индусский код, но он работает
                if (c == 1)                                             //Если переменная С = 1 то идет сложение
                {
                    Console.WriteLine(a + b);
                }
                if (c == 2)                                             //Если переменная С = 2 то идет вычитание
                {
                    Console.WriteLine(a - b);                           
                }

                if (c == 3)                                             //Если переменная С = 3 то идет деление
                {
                    Console.WriteLine(a / b);
                }
                if (c == 4)                                            //Если переменная С = 4 то идет умножение
                {
                    Console.WriteLine(a * b);
                }

                if (c == 5)                                           ////Если переменная С = 5 то идет остаток от деления
                {
                    double n = a % b;
                    Console.WriteLine($"{n}");
                }

                if (c == 6)                                         //Если переменная С = 6, то первое число возводиться в степень равную второму числу
                {

                    double v = Math.Pow(a, b);
                    Console.WriteLine(v);
                }

           
            Console.ReadKey();
            }
        }
	}
}
