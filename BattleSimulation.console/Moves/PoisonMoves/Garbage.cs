using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.PoisonMoves
{
    public class Garbage : IMoves
    {
        public string name { get; set; } = "Garbage";
        public string description { get; set; } = "Throws garabage at the enemy, causing them to feel disgusted";
        public int power { get; set; } = 40;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 40;
        public int accuracy { get; set; } = 95;
        public IType typing { get; set; } = new Poison();
        public bool physical { get; set; } = true;
    }
}
