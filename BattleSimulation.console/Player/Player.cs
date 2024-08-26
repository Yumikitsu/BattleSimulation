using BattleSimulation.console.Items;
using BattleSimulation.console.Monsters;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Player
{
    public class Player
    {
        //Has a list of monsters (Max 6 at a time)
        public List<IMonster> party = new List<IMonster>();

        //Has a list of all the items the player has available
        public List<Item> inventory = new List<Item>();

        //Money
        public int money = 100; //Starting money

        //Index
        public int currentMonster = 0; //Index pointing to the current monster being used


        public Player() { }
    }
}
