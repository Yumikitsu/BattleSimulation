using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.NormalMoves
{
    public class Scratch : IMoves
    {
        public string name { get; set; } = "Scratch";
        public string description { get; set; } = "Uses their claw to scratch the enemy";
        public int power { get; set; } = 40;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 40;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Normal();
        public bool physical { get; set; } = true;
    }
}
