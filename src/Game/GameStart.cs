using System.Collections.Generic;

namespace Game
{
    public class GameStart
    {
        List<Item> item {get;}
        List<Equipment> equip {get;}
        public GameStart(){
            item = new List<Item>();
            equip = new List<Equipment>();
            
        }

    }
}