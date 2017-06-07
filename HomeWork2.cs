using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            int floor = 0;
            int livingFloor = 0;

            int hamburgerPrice = 4;
            int frittesPrice = 2;
            int quantityOfHamburgers = 0;
            int quantityOfFrittes = 0;
            int totalPrice = 0;
            int menu = 0;

            string product = "Samsung Galaxy";
            int productPrice = 700;
            int productQuantity = 0;
            int totalPhonePrice = 0;
            string answer = "no";
            bool want2buy = false;

        menuStart:;
            Console.Clear();
            Console.WriteLine("Pasirinkite uzduoti:");
            Console.WriteLine("1. Kokiam aukste gyveni");
            Console.WriteLine("2. Hamburgeriai ir bulvytes");
            Console.WriteLine("3. Pirk Samsunga");
            Console.WriteLine("4. Baigti programa");

            menu = int.Parse(Console.ReadLine());

            Console.Clear();


            switch (menu)
            {
                case 1:

                    Console.WriteLine("Keliu aukstu name gyvenate ?");
                    floor = int.Parse(Console.ReadLine());

                    Console.WriteLine("Kelintame aukste gyvenate ?");
                    livingFloor = int.Parse(Console.ReadLine());

                    Console.WriteLine("Jus gyvenate {0} aukste.", livingFloor);

                    if (floor / livingFloor >= 2)
                    {
                        Console.WriteLine("Jus gyvenate apatineje namo dalyje.");
                    }
                    else
                    {
                        Console.WriteLine("Jus gyvenate virsutineje namo dalyje.");
                    }

                    Console.WriteLine("Press any key to return to menu...");
                    Console.ReadKey();
                    goto menuStart;

                case 2:

                    Console.WriteLine("Kiek noresite mesainiu ?");
                    quantityOfHamburgers = int.Parse(Console.ReadLine());

                    Console.WriteLine("Kiek noresite bulvyciu ?");
                    quantityOfFrittes = int.Parse(Console.ReadLine());

                    totalPrice = (quantityOfHamburgers * hamburgerPrice) + (quantityOfFrittes * frittesPrice);

                    Console.WriteLine("Jus uzsakete {0} hamburgeriu ir {1} bulvyciu. Jusu uzsakymo kaina {2}.", quantityOfHamburgers, quantityOfFrittes, totalPrice);

                    Console.ReadKey();
                    goto menuStart;

                case 3:

                    Console.WriteLine("Kiek vienetu {0} planuojate pirkti ?", product);
                    productQuantity = int.Parse(Console.ReadLine());

                    totalPhonePrice = productQuantity * productPrice;

                    Console.WriteLine(" Jusu {0} {1} kainuos {2} EUR", productQuantity, product, totalPhonePrice);

                    Console.WriteLine("Ar tikrai norite pirkti telefonus ? Yes/No, Enter=No");
                    answer = Console.ReadLine();
                    answer = answer.ToLower();



                    if (answer == "yes")
                    {
                        Console.WriteLine("Jus ka tik nusipirkote {0} {1} uz {2} EUR", productQuantity, product, totalPhonePrice);

                    }
                    else
                    {
                        Console.WriteLine("Viso gero !");
                    }
                    Console.WriteLine("Press any key to return to menu...");
                    Console.ReadKey();
                    goto menuStart;

                case 4:
                    break;

                default:
                    Console.WriteLine("Blogas pasirinkimas.");
                    Console.WriteLine(" Press any key to return to menu...");
                    Console.ReadKey();
                    goto menuStart;


            }
        }
    }
}
