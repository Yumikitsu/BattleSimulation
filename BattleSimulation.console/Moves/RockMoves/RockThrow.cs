using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.RockMoves
{
    public class RockThrow : IMoves
    {
        public string name { get; set; } = "Rock Throw";
        public string description { get; set; } = "Throws a small rock at the enemy like a caveman, this move has a boosted critical hit chance";
        public int power { get; set; } = 35;
        public decimal critChance { get; set; } = 1 / 8;
        public int uses { get; set; } = 30;
        public int accuracy { get; set; } = 95;
        public IType typing { get; set; } = new Rock();
        public bool physical { get; set; } = true;
    }
}
