using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.BugMoves
{
    public class Buzz : IMoves
    {
        public string name { get; set; } = "Buzz";
        public string description { get; set; } = "Uses their wings to produce a loud buzzing noise, causing anyone nearby to become temporarily deaf";
        public int power { get; set; } = 75;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 30;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Bug();
        public bool physical { get; set; } = false;
    }
}
