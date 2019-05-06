using System;

namespace Figures
{
    class Program
    {
        enum Figures
        {
            rectangle = 1,
            triagle, 
            circle
        }
        static void Main(string[] args)
        {
            var figureArray = (Figures[])Enum.GetValues(typeof(Figures));
            Console.Write($"Please, choose figure:  ");

            for (var i = 0; i < figureArray.Length; i++)
            {
                Console.Write($"{figureArray[i]}, ");
            }
            Console.WriteLine($"\n");
            try
            {
                var input = Console.ReadLine();
                var getValue = (Figures)Enum.Parse(typeof(Figures), input);
                Console.WriteLine($"you choose:  {getValue}");

                if ((int)getValue == 1)
                {
                    Console.WriteLine("Please, enter the height of the rectangle: ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please, enter the width of the rectangle: ");
                    double width = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"The area of the rectangle: {height * width}");
                    Console.WriteLine($"The perimeter of the rectangle: {2 * (height + width)}");
                }

                if ((int)getValue == 2)
                {
                    Console.WriteLine("Please, enter the side of the triangle: ");
                    double side = Convert.ToDouble(Console.ReadLine());
                    double sqrt = Math.Sqrt(3);
                    double squareSide = Math.Round((sqrt / 4) * (side * side), 2);
                    Console.WriteLine($"The area of the triangle: {squareSide}");
                    Console.WriteLine($"The perimetr of the triangle: {side * 3}");
                }

                if ((int)getValue == 3)
                {
                    Console.WriteLine("Please, enter the diametr of the circle: ");
                    double P = 3.14;
                    double Diametr = Convert.ToDouble(Console.ReadLine());
                    double area = (P / 4) * (Diametr * Diametr);
                    Console.WriteLine($"The area of the circle: {area}");
                    Console.WriteLine($"The perimetr of the circle: {P * Diametr}");
                }
            }
            catch (SystemException)
            {
                Console.WriteLine($"You enter wrong value!");
            }
            Console.ReadKey();
        }
    }
}
