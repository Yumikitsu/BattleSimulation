using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.GhostMoves
{
    public class Poltergeist : IMoves
    {
        public string name { get; set; } = "Poltergeist";
        public string description { get; set; } = "Moves objects in the surrounding area to fly towards the enemy and hit them";
        public int power { get; set; } = 90;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 20;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Ghost();
        public bool physical { get; set; } = true;
    }
}
