using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    class IceAndFire
    {
        bool gamerunning = true;
        int number = 0;
        int[] ranges = { 400, 300, 200, 150, 75, 25, 10, 5, 0 };
        string[] temperatures = { "Ledynmetis", "Labai salta", "Salta", "Silta", "Labai silta", "Karsta", "Labai karsta", "Degi", "Tu pelenai" };

        public void Start()
        {
            Random random = new Random();
            number = random.Next(1, 1000);

            Console.WriteLine();

            while (gamerunning)
            {
                Console.WriteLine();
                Console.WriteLine("Iveskite skaiciu:");

                int guessednumber = int.Parse(Console.ReadLine());
                Console.Clear();

                int difference = Math.Abs(number - guessednumber);

                for (int i = 0; i < ranges.Length - 1; i++)
                {

                    if (difference <= ranges[i] && (difference > ranges[i + 1]))
                    {
                        Console.WriteLine("{0}", temperatures[i]);
                    }
                    else if (difference == 0)
                    {
                        Console.WriteLine("Jus atspejote skaiciu. Jis buvo {0}. Viso gero.", number);
                        gamerunning = false;
                        Console.ReadKey();
                        return;
                    }

                }
                if (difference > ranges[0])

                {
                    Console.WriteLine(temperatures[0]);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IceAndFire game = new IceAndFire();

            game.Start();

            Console.ReadKey();
        }
    }
}
