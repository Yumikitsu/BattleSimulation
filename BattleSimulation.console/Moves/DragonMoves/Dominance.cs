using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.DragonMoves
{
    public class Dominance : IMoves
    {
        public string name { get; set; } = "Dominance";
        public string description { get; set; } = "Intensly stare at the enemy, causing them to cower from fear";
        public int power { get; set; } = 40;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 40;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Dragon();
        public bool physical { get; set; } = false;
    }
}
