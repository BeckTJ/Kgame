using System;
using System.Collections.Generic;
namespace Game
{
    public class Shop
    {
        //set the price of an item as part of the item.
        string VillageName { get; }
        Item item = new Item();
        Equipment equip = new Equipment();
        object purchase = new object();
        List<Object> shopInventory = new List<Object>();
        public Shop(string villageName, int numItemSlots, int numEquipmentSlots)
        {
            // work on setting up a village that will set up the shop
            // # of items and inventory should be different in each village  
            // make an object that holds both items and equipment

            VillageName = villageName;
            getShop();
        }
        public void getShop()
        {
            int i = 1;
            Console.WriteLine($"Welcome to {VillageName} shop. How Can I Help you?");
            setShopInventory();

            foreach (object inv in shopInventory)
            {
                if (inv is Item)
                {
                    item = (Item)inv;
                   // Console.WriteLine($"{i}. {item.Name} {item.Price}gp");
                    i++;
                }
                else
                {
                    equip = (Equipment)inv;
                    //Console.WriteLine($"{i}. {equip.Name} {equip.Price}");
                    i++;
                }
            }
            purchase = selectItem(int.Parse(Console.ReadLine()));


        }
        public void setShopInventory()
        {
            //Should the number of items in the shop be set by the village size or be hard coded.
            //create a file that will hold the items for each village's shop???
            shopInventory.Add(getShopItem("Small Healing Potion"));
            shopInventory.Add(getShopEquipment("Short Sword"));
            shopInventory.Add(getShopItem("Small Magic Potion"));
            shopInventory.Add(getShopEquipment("Helmet"));
        }
        public Item getShopItem(string selection)
        {
            Item itm = new Item();
            return itm.findItem(selection);
        }
        public Equipment getShopEquipment(string eqp)
        {
            Equipment eqpt = new Equipment();
            return eqpt.findEquipment(eqp);
        }
        public object selectItem(int option)
        {

            switch (option)
            {
                case 1:
                    updateShop(item);
                    return item;
                case 2:
                    updateShop(equip);
                    return equip;
                case 3:
                    updateShop(item);
                    return item;
                case 4:
                    updateShop(equip);
                    return equip;
                default:
                    Console.WriteLine("Sorry could you repeat that.");
                    return null;
            }
        }
        public object getPurchase(){
            return purchase;
        }
        public void updateShop(object purchase)
        {
            shopInventory.Remove(purchase);
        }
    }
}