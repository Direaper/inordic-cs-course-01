using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)                                                 //Комменты я оставлю, так как мне ещё тяжело разобраться с циклами
        {
            object[,] DataBase = new object[2, 3] { { 0, 0, 0, }, { 0, 0, 0 } };            //Двумерный массив с 3 элеметами

            for (int i = 0; i < 3; i++)                                                 //Перебор массива, ввод имени людей
            {
                Console.WriteLine($"Наберите имя {i} человека");
                DataBase[0, i] = Console.ReadLine();
            }

            for (int i = 0; i < 3; i++)                                                 //Перебор массива, ввод возраста
            {
                Console.WriteLine($"Наберите возраст {i} человека");
                DataBase[1, i] = Console.ReadLine();
            }

            for (int i = 0; i < 3; i++)                                                 //Перебор массива
            {
                int n = 4 + Convert.ToInt32(DataBase[1, i]);                            //Объявляется переменная n, которой выдано значение отковертированного из 2 массива значения + 4
                Console.WriteLine($"Итак, человеку {DataBase[0, i]} через четыре года будет: {n}.");        //вывод
            }

            Console.WriteLine("Completed.");
            Console.ReadKey();
        }
    }
}
