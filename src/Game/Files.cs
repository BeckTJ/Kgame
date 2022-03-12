using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Game
{
    public class Files
    {
        
        public static List<Equipment> ArmorFile = ProcessArmorFile(@"..\..\resources\Armor.csv");

        private static List<Equipment> ProcessArmorFile(string path)
        {
            return
                File.ReadAllLines(path)
                    .Skip(1)
                    .Where(line => line.Length > 1)
                    .Select(Equipment.CreateEquiptmentList)
                    .ToList();
        }

        public static List<Equipment> GearList = CreateArmorList(@"..\..\resources\Armor.csv");
        public static List<Equipment> CreateArmorList(string path)
        {
            StreamReader GearFile = new StreamReader(path);
            List<Equipment> equip = new List<Equipment>();
            string line;
            GearFile.ReadLine();
            while((line = GearFile.ReadLine()) != null)
            {
                 equip.Add(Equipment.CreateEquiptmentList(line));
            }
            return equip;
        }

        public static List<Item> ItemFIle = ProcessFile(@"..\..\resources\ItemList.csv");

        private static List<Item> ProcessFile(string path)
        {
            return
                File.ReadAllLines(path)
                    .Skip(1)
                    .Where(line => line.Length > 1)
                    .Select(Item.CreateItemList)
                    .ToList();
        }

        public static List<Item> ItemList = CreateItemList(@"..\..\resources\ItemList.csv");

        private static List<Item> CreateItemList(string path)
        {
            StreamReader sr = new StreamReader(path);
            List<Item> items = new List<Item>();
            string line;
            sr.ReadLine();
            while((line = sr.ReadLine()) != null){
                items.Add(Item.CreateItemList(line));
            }
            return items;
        }
    }
}