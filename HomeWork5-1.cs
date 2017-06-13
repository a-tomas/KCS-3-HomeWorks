using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 10, 10, 70, 20, 40, 20, 80, 40, 20, 90, 60, 30, 60, 60, 30 };
            int[] numbersX = new int[numbers.Length];
            Array.Copy(numbers, numbersX, numbers.Length);

            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)

                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                    }
                }
                if (counter > 1)
                {
                    for (int k = i + 1; k < numbersX.Length; k++)
                    {
                        if (numbers[i] == numbers[k])
                        {
                            numbersX[k] = 0;
                        }

                    }

                }
                else
                {
                    numbersX[i] = 0;
                }
                counter = 0;
            }
            Console.Write("Pasikartojantys skaiciai: ");
            foreach (int x in numbersX)
            {
                if (x > 0)
                {
                    Console.Write("{0} ", x);
                }
            }
            Console.ReadKey();
        }
    }
}

