using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.WaterMoves
{
    public class Spit : IMoves
    {
        public string name { get; set; } = "Spit";
        public string description { get; set; } = "Spits water at the enemy";
        public int power { get; set; } = 35;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 30;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Water();
        public bool physical { get; set; } = true;
    }
}
