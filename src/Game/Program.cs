using System;
using System.IO;
using System.Collections.Generic;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Character User;
            string response = "";

            Console.WriteLine("Ah I see your awake. You have been out for some time. Can you tell me your name?");
            User = new Character(Console.ReadLine());
            Console.WriteLine($"\nOh {User.getName()}! Why that is a strange name indead!");

            Console.WriteLine($"Well {User.getName()}, Welcome to (village name)."
            + "Should you choose to help out around town i'm sure you will learn some useful skills.\n");

            while (response != "q")
            {
                Console.WriteLine("Choose an option.");
                Console.WriteLine("1. Talk to local.");
                Console.WriteLine("2. Visit the shop.");
                Console.WriteLine("3. Visit neiboring house.");
                Console.WriteLine("4. Talk to elder.");
                Console.WriteLine("5. Check Inventory.");
                Console.WriteLine("q to Quit!");

                response = Console.ReadLine();

                if (int.Parse(response) == 5)
                {
                    User.getInventory();
                }
                else if (int.Parse(response) == 2)
                {
                    Village village = new Village("village name",4,6);
                    village.villageShop();
                   // User.purchaseItem(village.retrievePurchase());
                }
                else
                {
                    Console.WriteLine("not done yet\n");
                }
            }
            Console.WriteLine("THANKS FOR PLAYING!");
        }
    }
}
