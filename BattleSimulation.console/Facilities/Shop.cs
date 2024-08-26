using BattleSimulation.console.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Facilities
{
    public class Shop
    {
        //Create a list of all items that exist in the game
        public List<Item> allItems = new List<Item>();

        //Create a list of all items currently purchaseable in the shop
        public List<Item> currentlyAvailableItems = new List<Item>();
        public Shop() { }

        //Create a method to decide what items should be available in the shop, max 4 per shop
    }
}
