using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.FairyMoves
{
    public class PerfectStrike : IMoves
    {
        public string name { get; set; } = "Perfect Strike";
        public string description { get; set; } = "Attacks the enemy with a perfect strike, this move will always result in a critical hit";
        public int power { get; set; } = 70;
        public decimal critChance { get; set; } = 1 / 1;
        public int uses { get; set; } = 5;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Fairy();
        public bool physical { get; set; } = true;
    }
}
