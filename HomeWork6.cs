using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class Product
    {
        public string title;
        public int price;
        public int quantity;

        public Product(string title, int price, int quantity)
        {
            this.title = title;
            this.price = price;
            this.quantity = quantity;
        }

        public void Info()
        {
            Console.WriteLine("{0} ({1}. Sandelyje turime {2} vnt.", title, price, quantity);
        }
    }

    class Person
    {
        public string name;
        public int height;

        public Person(string name, int height)
        {
            this.name = name;
            this.height = height;
        }

        public void Info()
        {
            Console.WriteLine("{0} {1}cm", name, height);
        }
    }
    class NumberCompare
    {
        public int x;
        public int y;


        public NumberCompare(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Compare()
        {
            if (x == y)
            {
                Console.WriteLine("{0} lygu {1}", x, y);
            }
            else
            {
                Console.WriteLine("{0} nelygu {1}", x, y);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = {

                new Product("iPhone 7 Plus 128 GB", 1029, 10),
                new Product("HTC U Ultra", 819, 5),
                new Product("Google Pixel 32 GB", 849, 2)
            };


            foreach (Product product in products)
            {
                product.Info();
            }

            Console.WriteLine("Press any key...");
            Console.ReadKey();
            Console.Clear();


            Person[] humans = {

                new Person("Dominykas",184),
                new Person("Petras",172 ),
                new Person("Jonas", 206),
                new Person("Tomas",185)
            };

            Console.WriteLine("Zmones:");

            for (int i = 0; i < humans.Length; i++)
            {
                humans[i].Info();
            }
            int heightIndex = -1;
            int height = 0;

            for (int i = 0; i < humans.Length; i++)
            {
                if (height < humans[i].height)
                {
                    heightIndex = i;
                    height = humans[i].height;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Auksciausias:");

            humans[heightIndex].Info();

            Console.WriteLine("Press any key...");
            Console.ReadKey();
            Console.Clear();

            int[] x = { 10, 20, 30, 40, 50, 80, 90 };
            int[] y = { 10, 30, 20, 40, 50, 50, 90 };

            for (int i = 0; i < x.Length; i++)
            {
                NumberCompare numbers = new NumberCompare(x[i], y[i]);
                numbers.Compare();
            }
            Console.WriteLine("Press any key...");
            Console.ReadKey();

        }

    }
}

