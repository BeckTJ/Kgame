using System;
using System.Collections.Generic;
namespace Game
{
    public class Village
    {
        string Name {get;}
        int Houses {get;}
        int numPeople {get;}
        object purchase;
        public Village(string name, int houses, int people){
            Name = name;
            Houses = houses;
            numPeople = people;
        }
        public void villageShop() 
        {
            purchase = new object();
            //set up shop for number of items and equipment
            Shop store = new Shop(Name,2,2);
            purchase = store.getPurchase();
        }
        public object retrievePurchase(){
            return purchase;
        }
    }
}