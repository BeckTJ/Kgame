using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace Game
{
    public class Equipment : Files
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int Price { get; set; }


        internal static Equipment CreateEquiptmentList(string line)
        {
            string[] armor = line.Split(',');
            return new Equipment
            {
                Name = armor[0],
                Type = armor[1],
                Strength = int.Parse(armor[2]),
                Defense = int.Parse(armor[3]),
                Price = int.Parse(armor[4])
            };
        }

        internal Equipment findEquipment(string gear)
        {
            for (int i = 0; i <= GearList.Count(); i++){
                if(GearList[i].Name == gear){
                   return GearList[i];
                }
            }
                return null;
        }
    }
}