using System.Collections.Generic;
using System.IO;
using Xunit;

namespace Game.Tests
{
    public class EquiptmentTests
    {
        List<Equipment> equip;
         [Fact]
        public void EquipmentTest()
        {
            equip = getEquipment();
            Equipment itm = equip[0];
            {
                Assert.Equal("Short Sword", itm.Name);
                Assert.Equal("Weapon", itm.Type);
                Assert.Equal(10, itm.Strength);
                Assert.Equal(0, itm.Defense);
            }
        }
        public List<Equipment> getEquipment()
        {
            equip = new List<Equipment>();
            using (StreamReader sr = new StreamReader("..\\..\\..\\..\\..\\resources\\Armor.csv"))
            {
                sr.ReadLine();
                string itm;
                while ((itm = sr.ReadLine()) != null)
                {
                    equip.Add(addEquiptment(itm));
                }
            }
            return equip;
        }
         public Equipment addEquiptment(string line)
        {
            string[] equip = line.Split(',');

            string name = equip[0];
            string type = equip[1];
            int strength = int.Parse(equip[2]);
            int defense = int.Parse(equip[3]);
            int price = int.Parse(equip[4]);

            return new Equipment(name, type, strength, defense, price);
        } 
    }
}