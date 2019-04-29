using System;

namespace Litres_Counter
{
    class Program
    {

        [Flags]
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
            var volume = Math.Round(Convert.ToDouble(Console.ReadLine()));
            var BigCont = Math.Round((double)Box.BigBox);
            var BigOst = volume % (double)Box.BigBox;
            var MidCont = Math.Round((double)Box.MidBox);
            var MidOst = BigOst % (double)Box.MidBox;
            var SmallCont = Math.Round((double)Box.SmallBox);
            var SmallOst = MidOst % (double)Box.SmallBox;

            Console.WriteLine($"Вы ввели {volume}");


            if (volume >= BigCont)              
                {
                Console.WriteLine($"Вам необходимо {Math.Round(volume / BigCont)} , 20 литровых контейнеров");
                if (BigOst >= MidCont)
                {
                Console.WriteLine($"Вам необходимо {Math.Round(BigOst / MidCont)} , 5 литровых контейнеров");
                    if (MidOst <= SmallCont)
                    {
                        Console.WriteLine($"Вам небходимо {Math.Round(MidOst / SmallCont + SmallCont)} , 3 литровых контейнеров");
                    }
                }
                }

               if (volume >= SmallCont)
                {
                Console.WriteLine($"Вам необходимо {Math.Round(volume / MidCont)} , 5 литровых контейнеров");
                if (MidOst <= SmallCont)
                {
                    Console.WriteLine($"Вам небходимо {Math.Round(MidOst / SmallCont)} , 3 литровых контейнеров");
                }
                }

            if (volume >= SmallCont)
            {
                Console.WriteLine($"Вам необходимо {Math.Round(volume / SmallCont)} , 3 литровых контейнеров");
            }

                Console.ReadKey();
        }
    }
}
