using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.BugMoves
{
    public class Munch : IMoves
    {
        public string name { get; set; } = "Munch";
        public string description { get; set; } = "The user munches on the enemy with their strong jaws";
        public int power { get; set; } = 55;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 25;
        public int accuracy { get; set; } = 95;
        public IType typing { get; set; } = new Bug();
        public bool physical { get; set; } = true;
    }
}
