using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            string planet = "Earth";
            int earthPeopleCount = 7509;

            string star = "sun";
            int sunPeopleCount = 0;
            
            string item = "Table";
            int tableLegs = 4;
            int tableQuantity = 17;

            string product = "iPhone";
            int price = 999;
            int phoneQuantity = 10;
            int buy = 5;

            Console.WriteLine("There are {0} million people on {1}.", earthPeopleCount, planet);

            if (sunPeopleCount == 0)
            {
                Console.WriteLine("There are no people on {0}.", star);
            }
            else
            {
                Console.WriteLine("There are {0} people on {1}", sunPeopleCount, star);     
            }

           Console.WriteLine("We have {0} {1} and they have " + (tableLegs * tableQuantity) +  " legs.",tableQuantity,item);

            Console.WriteLine("We have {0} x {1}.", phoneQuantity, product);
            Console.WriteLine("You are buying {0} x {1}.", buy, product);
            Console.WriteLine("Total cost: " + (price*buy));

            Console.ReadKey();
            
        }
    }
}
