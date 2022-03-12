using System;
using System.Collections.Generic;
using System.IO;
namespace Game
{
    public class Inventory
    {
        Equipment weapon { get; set; }
        Equipment chest { get; set; }
        Equipment leg { get; set; }
        Equipment head { get; set; }
        Equipment offhand { get; set; }
        Object[] inventory;
        Equipment equip;
        Item item;
        int gold;

        public Inventory()
        {
            inventory = new Object[16];
            equip = new Equipment();
            item = new Item();

            weapon = equip.findEquipment("Short Sword");
            head = new Equipment();
            chest = equip.findEquipment("Leather Chest");
            offhand = equip.findEquipment("Wooden Sheild");
            leg = equip.findEquipment("Metal Legs");
            gold = 10;
            inventory[0] = item.findItem("Small Healing Potion");
        }

        public void getInventory()
        {
            int inventoryCount = 1;

            Console.WriteLine($"Weapon: {weapon.Name} \nOffhand: {offhand.Name}\nHead: {head.Name}"
            + $"\nChest: {chest.Name}\nLegs: {leg.Name}\n");


            foreach (object inv in inventory)
            {
                if (inv is Item)
                {
                    item = (Item)inv;
                    Console.WriteLine($"Item Slot {inventoryCount}: {item.Name} {item.Description}");
                    inventoryCount++;
                }
                else if (inv is Equipment)
                {
                    equip = (Equipment)inv;
                    Console.WriteLine($"Item Slot {inventoryCount}: {equip.Name} Str: {equip.Strength} Def: {equip.Defense}");
                    inventoryCount++;
                }
                else
                {
                    Console.WriteLine($"Item Slot {inventoryCount}: ");
                    inventoryCount++;
                }

            }
            Console.WriteLine($"{getGold()} gp\n");
            chooseEquipItem();
        }
        public void updateInventory(object purchase)
        {

            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == null)
                {
                    inventory[i] = purchase;
                    break;
                }
            }
        }
        public void chooseEquipItem()
        {
            Console.WriteLine("what would you like to do?\n1. Use Item\t2. Equip Item\t3. Return");
            int choice = int.Parse(Console.ReadLine());

            while (choice != 3)
            {
                if (choice == 1)
                {
                    Console.WriteLine("sorry in work\n");
                    getInventory();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("\nwhich Item would you like to Equip?");
                    equipItem(Console.ReadLine());
                    getInventory();
                }
            }
        }
        public void equipItem(string option)
        {
            int selection = int.Parse(option);
            object choice = inventory[selection];
            inventory[selection] = null;

            do
            {
                Console.WriteLine("Which slot would you like to equip it too.");
                option = Console.ReadLine();
                if (choice is Equipment)
                {
                    switch (int.Parse(option))
                    {
                        case 1:
                            weapon = (Equipment)choice;
                            break;
                        case 2:
                            offhand = (Equipment)choice;
                            break;
                        case 3:
                            head = (Equipment)choice;
                            break;
                        case 4:
                            chest = (Equipment)choice;
                            break;
                        case 5:
                            leg = (Equipment)choice;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry that is not Equipable");
                    getInventory();
                }
            } while (choice is not Equipment);
        }
        public int getGold()
        {
            return gold;
        }
        public void subtractGold(int money)
        {
            gold -= money;
        }
        public void addGold(int income)
        {
            gold += income;
        }
    }
}