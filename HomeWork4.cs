using System;
namespace HomeWork4
{
    class Program
    {
        static void PriceOfCar(string car, string carModel, int carPrice)
        {
            Console.WriteLine("Automobilis {0} {1} kainuoja {2} EUR.", car, carModel, carPrice);
        }

        static void ShoesDiscount(int shoesPrice, int shoesAmmountBuy, int discount, int vipDiscount, bool isVipCustomer)
        {
            int discountedPrice = shoesPrice - discount;

            string vipCustomer = "";
            if (isVipCustomer == true)
            {
                discountedPrice -= vipDiscount;
                vipCustomer = "esate lojalus";

            }
            else
            {
                vipCustomer = "nesate lojalus";
            }
            Console.WriteLine("Jus {0} klientas, Jums pritaikyta {1} EUR nuolaida.\nVienos poros kaina be nuolaidos {2} EUR.\nJus perkate {3} poras batu, kuriu kaina su nuolaida yra {4} EUR.", vipCustomer, shoesPrice - discountedPrice, shoesPrice, shoesAmmountBuy, discountedPrice * shoesAmmountBuy);
        }
        static void BuyProduct(string product, int productPrice, int money)
        {
            if (money >= productPrice)
            {
                Console.WriteLine("Jus nusipirkote {0} uz {1} EUR.", product, productPrice);
            }
            else
            {
                Console.WriteLine("Deja jums neuztenka {0} EUR, kad Jus galetumete nusipirkti {1}.", productPrice - money, product);
            }
        }
        static void WheelsDiscount(int wheelsPrice, int wheelsAmmountBuy, int wheelsDiscount, int wheelsAntiDiscount, int discountFromItems, int antiDiscountFromItems)
        {
            string printDiscount = "";
            int allWheelsPrice = 0;
            if (wheelsAmmountBuy >= discountFromItems)
            {
                allWheelsPrice = wheelsPrice * wheelsAmmountBuy - wheelsDiscount;
                printDiscount = "su nuolaida";
            }
            else if (wheelsAmmountBuy < antiDiscountFromItems)
            {
                allWheelsPrice = wheelsPrice * wheelsAmmountBuy + wheelsAntiDiscount;
                printDiscount = "padidinta kaina";
            }
            else
            {
                allWheelsPrice = wheelsPrice * wheelsAmmountBuy;
                printDiscount = "be nuolaidos";

            }

            Console.WriteLine("Jus perkate {0} ratus, {1}. Vieneto kaina yra {2} EUR.\nVisa mokama suma yra {3} EUR.", wheelsAmmountBuy, printDiscount, wheelsPrice, allWheelsPrice);
        }
        static void Main(string[] args)
        {
            string product = "iPhone";
            int productPrice = 500;
            int money = 2300;

            string car = "BMW";
            string carModel = "e39";
            int carPrice = 10000;

            int shoesPrice = 299;
            int shoesAmmountBuy = 2;
            int discount = 20;
            int vipDiscount = 10;
            bool isVipCustomer = true;


            int wheelsPrice = 70;
            int wheelsAmmountBuy = 3;
            int wheelsDiscount = 50;
            int wheelsAntiDiscount = 30;
            int discountFromItems = 8;
            int antiDiscountFromItems = 4;


            BuyProduct(product, productPrice, money);
            Console.WriteLine();
            PriceOfCar(car, carModel, carPrice);
            Console.WriteLine();
            ShoesDiscount(shoesPrice, shoesAmmountBuy, discount, vipDiscount, isVipCustomer);
            Console.WriteLine();
            WheelsDiscount(wheelsPrice, wheelsAmmountBuy, wheelsDiscount, wheelsAntiDiscount, discountFromItems, antiDiscountFromItems);

            Console.ReadKey();
        }
    }
}
