using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 10, 10, 50, 20, 40, 20, 40, 40, 20,60,60,80,60,60,30 };
            int[] numbersX = new int[numbers.Length];
            Array.Copy(numbers, numbersX, numbers.Length);

            int[] duplicateNumbers = new int[numbers.Length];
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)

                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                        //Console.WriteLine(counter);
                    }
                }
                if (counter > 1)
                {
                    //Console.WriteLine("{0} number, counter {1}, index {2}", numbers[i], counter,indexDuplicated);
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

