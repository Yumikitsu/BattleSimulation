using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.RockMoves
{
    public class Hole : IMoves
    {
        public string name { get; set; } = "Hole";
        public string description { get; set; } = "Creates a hole in the ground under the enemy";
        public int power { get; set; } = 55;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 20;
        public int accuracy { get; set; } = 90;
        public IType typing { get; set; } = new Rock();
        public bool physical { get; set; } = false;
    }
}
