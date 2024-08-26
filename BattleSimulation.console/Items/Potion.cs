using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Items
{
    public class Potion : Item
    {
        public string Name { get; set; } = "Potion";

        public string Description { get; set; } = "Heal 20HP of the user's selected monster";

        public int Price { get; set; } = 15;
    }
}
