using System;
namespace HomeWork5
{
    class Program
    {
        // Function for reversing array digits

        static int[] ReverseArray(int[] numbers)
        {
            int[] reverseNumbers = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                reverseNumbers[i] = numbers[(numbers.Length - 1) - i];
            }
            return reverseNumbers;
        }

        //Function for connecting 2 Arrays

        static int[] Connect2Arrays(int[] numbersA, int[] numbersB)
        {
            int[] connectedArrays = new int[numbersA.Length + numbersB.Length];

            for (int i = 0; i < numbersA.Length; i++)
            {
                connectedArrays[i] = numbersA[i];
            }

            for (int i = 0; i < numbersB.Length; i++)
            {
                connectedArrays[i + numbersA.Length] = numbersB[i];
            }

            return connectedArrays;
        }

        //Function checks if number is Even
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
            /*--------------------------------
            Masyvas: 10, 15, 44, 70
            Padaryti jog masyvą apverstų ir rezultatas būtų:
            70, 44, 15, 10
            --------------------------------*/


            int[] numbers = { 10, 15, 44, 70 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0} ", (ReverseArray(numbers)[i]));
            }

            Console.WriteLine();
            Console.WriteLine();


            /*Sujungti du masyvus į vieną
            Masyvas A: 10, 15, 20
            Masyvas B: 15, 17, 20
            Rezultatas:
            Sujungtas masyvas:
            10, 15, 20, 15, 17, 20
            --------------------------------*/

            int[] numbersA = { 10, 15, 20 };
            int[] numbersB = { 15, 17, 20 };

            Console.WriteLine("Sujungtas masyvas:");
            for (int i = 0; i < numbersA.Length + numbersB.Length; i++)
            {
                Console.Write("{0} ", (Connect2Arrays(numbersA, numbersB)[i]));
            }

            Console.WriteLine();
            Console.WriteLine();

            /*Išrinkti lyginius ir nelyginius skaičius į atskirus masyvus
            Masyvas A: 1, 4, 7, 8, 10, 3
            Rezultatas:
            Lyginių masyvas: 4, 8, 10
            Nelyginių masyvas: 1, 7, 3 
            */

            int[] numbersC = { 1, 4, 7, 8, 10, 3 };
            int evenNumberCount = 0;
            int oddNumberCount = 0;

            for (int i = 0; i < numbersC.Length; i++)
            {
                if (IsEven(numbersC[i]) == true)
                {
                    evenNumberCount++;
                }
                else
                {
                    oddNumberCount++;
                }
            }
            int[] evenNumbers = new int[evenNumberCount];
            int[] oddNumbers = new int[oddNumberCount];
            int indexEven = 0;
            int indexOdd = 0;

            for (int i = 0; i < numbersC.Length; i++)
            {

                if (IsEven(numbersC[i]) == true)
                {
                    evenNumbers[indexEven] = numbersC[i];
                    indexEven++;
                }
                else
                {
                    oddNumbers[indexOdd] = numbersC[i];
                    indexOdd++;
                }
            }

            Console.Write("Lyginiu masyvas: ");
            foreach (int number in evenNumbers)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
            Console.Write("Nelyginiu masyvas: ");
            foreach (int number in oddNumbers)
            {
                Console.Write("{0} ", number);
            }

            Console.ReadKey();


        }

    }
}
