using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.BugMoves
{
    public class Annoyance : IMoves
    {
        public string name { get; set; } = "Annoyance";
        public string description { get; set; } = "Flies around the enemy rapidly to cause anger and make them hit themselves in their attempt to hit the user";
        public int power { get; set; } = 35;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 40;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Bug();
        public bool physical { get; set; } = false;
    }
}
