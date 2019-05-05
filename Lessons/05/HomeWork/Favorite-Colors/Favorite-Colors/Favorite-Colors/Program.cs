using System;

namespace Favorite_Colors
{
    class Program
    {
        [Flags]
        enum Colors : byte
        {
            None = 0x0,                 
            Red = 0x1,                  
            Orange = 0x1 << 1,         
            Yellow = 0x1 << 2,          
            Green = 0x1 << 3,           
            Blue = 0x1 << 4,           
            Violet = 0x1 << 5,          
            Black = 0x1 << 6,          
            White = 0x1 << 7           
        }
        static void Main(string[] args)
        {
            var pallet = Colors.Red | Colors.Orange | Colors.Yellow | Colors.Green | Colors.Blue | Colors.Violet | Colors.Black | Colors.White;

            Console.WriteLine($"Please, enter you favorite colors: \n ");

            for (var i = 0; i<16 ; i++)
            {
                var value = 0x1 << i;
                if ((((short)pallet)& value)== value)
                {
                    Console.Write($"{(Colors)value}  ");
                }
            }

            Console.Write($"\n");

            var favColors = Colors.None;
            var unFavColors = Colors.None;
            try
            {
                for (var i = 1; i < 5; i++)
                {
                    Console.WriteLine($"\nChoose {i} color");
                    var input = Console.ReadLine();
                    var getValue = (Colors)Enum.Parse(typeof(Colors), input);
                    favColors = favColors | getValue;
                    unFavColors = favColors ^ pallet;
                }
            }
            catch (SystemException)
            {
                Console.WriteLine($"You enter wrong value!");
            }

            Console.WriteLine($"You favorite colors: {favColors}  ");
            Console.WriteLine($"You don't like this colors: {unFavColors}  ");
           Console.ReadKey();
        }
    }
}
