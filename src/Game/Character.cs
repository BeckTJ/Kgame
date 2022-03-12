using System;
using System.Collections.Generic;

namespace Game
{
    public class Character : Inventory
    {
        public struct Chara
        {
            public string Name;
            public int level;
            public int XP;
            public int hitPoints;
            public int magicPoints;

        }
        Chara player;

        public Character(string name)
        {
            player = new Chara();
            player.Name = name;
            player.level = 1;
            player.XP = 0;
            player.hitPoints = 25;
            player.magicPoints = 0;
            new Inventory();
        }
        public string getName()
        {
            return player.Name;
        }
        public Chara GetCharacter()
        {
            return player;
        }
        public int getLevel()
        {
            return player.level;
        }
        public int getMP()
        {
            return player.magicPoints;
        }
        public int getHP()
        {
            return player.hitPoints;
        }
        public int getXP()
        {
            return player.XP;
        }
        public void itemCollection(int money, object item)
        {
            addGold(money);
            updateInventory(item);
        }
        public void itemCollection(int money)
        {
            addGold(money);
        }
        public void itemCollection(object item)
        {
            updateInventory(item);
        }
        //have the cost and item one object via item.cs
        // public void purchaseItem(object item)
        // {
        //     if(item is Item){
        //         Item itm = (Item)item;
        //         subtractGold(itm.Price);
        //     }
        //     else{
        //         Equipment eqp = (Equipment)item;
        //         subtractGold(eqp.Price);
        //     }
        //     itemCollection(item);
        // }
        public void equip(string option)
        {
            equipItem(option);
        }
    }
} 