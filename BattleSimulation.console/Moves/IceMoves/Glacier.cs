using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.IceMoves
{
    public class Glacier : IMoves
    {
        public string name { get; set; } = "Glacier";
        public string description { get; set; } = "Crushes the enemy with a massive glacier made by compact ice";
        public int power { get; set; } = 140;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 8;
        public int accuracy { get; set; } = 95;
        public IType typing { get; set; } = new Ice();
        public bool physical { get; set; } = true;
    }
}
