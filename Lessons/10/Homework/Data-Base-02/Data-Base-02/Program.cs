using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var p1 = new Input();
            p1.Insert=0;

            Console.ReadKey();
            
        }

    }

   public class Input
    {
        string[] names = new string[] { "0", "0", "0" };

        public int Insert 
        {
            get{ return Insert;}
            set
              {
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine($"Наберите имя {i} человека");
                    names[i] = Console.ReadLine();
                }
                int[] ages = new int[] { 0, 0, 0 };

                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine($"Наберите возраст {i} человека");
                    ages[i] = Convert.ToInt32(Console.ReadLine());

                }

                int[] ageFour = new int[] { ages[0], ages[1], ages[2] };

                for (int i = 0; i < ageFour.Length; i++)
                {
                    ages[i] = ageFour[i] + 4;
                }

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"Person: {names[i]} age: {ages[i]}");
                }

                Console.ReadKey();
            }
 
        }
}

}


