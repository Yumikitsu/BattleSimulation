using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Items
{
    public class Potion : Item
    {
        public string name { get; set; } = "Potion";

        public string description { get; set; } = "Heal 20HP of the user's selected monster";

        public int price { get; set; } = 15;
    }
}
