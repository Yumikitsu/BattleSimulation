using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.GhostMoves
{
    public class Haunt : IMoves
    {
        public string name { get; set; } = "Haunt";
        public string description { get; set; } = "Haunt the enemy, causing them to think of bad nightmares";
        public int power { get; set; } = 40;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 40;
        public int accuracy { get; set; } = 95;
        public IType typing { get; set; } = new Ghost();
        public bool physical { get; set; } = false;
    }
}
