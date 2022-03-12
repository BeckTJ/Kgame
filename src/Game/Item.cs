using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
namespace Game
{
    // set up item information
    public class Item : Files
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public int Strength { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

        internal static Item CreateItemList(string line)
        {
            string[] item = line.Split(',');
            return new Item
            {
                Name = item[0],
                Size = item[1],
                Strength = int.Parse(item[2]),
                Price = int.Parse(item[3]),
                Description = item[4]
            };
        }
        internal Item findItem(string item)
        {
            for (int i = 0; i < ItemList.Count(); i++){
                if(item == ItemList[i].Name){
                    return ItemList[i];
                }
            }
            return null;
        }
    }
}