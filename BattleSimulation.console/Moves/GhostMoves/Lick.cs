using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.GhostMoves
{
    public class Lick : IMoves
    {
        public string name { get; set; } = "Lick";
        public string description { get; set; } = "Licks the enemy, causing them to feel discomfort";
        public int power { get; set; } = 30;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 40;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Ghost();
        public bool physical { get; set; } = true;
    }
}
