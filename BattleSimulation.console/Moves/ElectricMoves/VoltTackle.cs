using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.ElectricMoves
{
    public class VoltTackle : IMoves
    {
        public string name { get; set; } = "Volt Tackle";
        public string description { get; set; } = "Zaps forward at riveting speeds and electrocutes the enemy with a powerful tackle, this move has a very bossted critical hit chance";
        public int power { get; set; } = 70;
        public decimal critChance { get; set; } = 1 / 4;
        public int uses { get; set; } = 20;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Electric();
        public bool physical { get; set; } = true;
    }
}
