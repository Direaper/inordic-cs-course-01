using System;

namespace Litres_Counter
{
    class Program
    {
         enum Box : int
        {
            None = 0,
            BigBox = 20,
            MidBox = 5,
            SmallBox = 3
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество литров, которые нужно упаковать:");
            var volume = Math.Floor(Convert.ToDouble(Console.ReadLine()));
            var bigCont = Math.Floor((double)Box.BigBox);
            var bigOst = volume % (double)Box.BigBox;
            var midCont = Math.Floor((double)Box.MidBox);
            var midOst = bigOst % (double)Box.MidBox;
            var smallCont = Math.Ceiling((double)Box.SmallBox);
            var smallOst = midOst % (double)Box.SmallBox;

            Console.WriteLine($"Вы ввели {volume}");


                if (volume >= bigCont)              
                {
                Console.WriteLine($"Вам необходимо {volume/bigCont} , 20 литровых контейнеров");
                }

                if (volume >= midCont)
                {
                    Console.WriteLine($"Вам необходимо {volume / midCont} , 5 литровых контейнеров");
                }


                if (volume >= smallCont)
                {
                Console.WriteLine($"Вам небходимо {volume / smallCont} , 3 литровых контейнеров");
                }

            Console.ReadKey();
        }
    }
}
