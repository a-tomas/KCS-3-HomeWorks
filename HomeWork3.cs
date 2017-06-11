using System;

namespace HomeWork3
{
    class Program
    {
        static bool IsEven(int ChekNumber)
        {
            if (ChekNumber % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            int number = 5;
            int times = 5;
            int fromNumber = 0;
            int number2 = 20;
            int startNumber = 0;

            for (int i = 0; i < times; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(number);

                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
            Console.Clear();



            Console.WriteLine("Now you see all even numbers from {0} to {1}", fromNumber, number2);

            startNumber = fromNumber;

            while (startNumber < number2)
            {
                startNumber++;
                if (IsEven(startNumber) == true)
                    Console.WriteLine(startNumber);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Now you see all odd numbers from {0} to {1}", fromNumber, number2);

            startNumber = fromNumber;

            while (startNumber < number2)
            {
                startNumber++;
                if (IsEven(startNumber) == false)
                    Console.WriteLine(startNumber);
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();

        }
    }
}
