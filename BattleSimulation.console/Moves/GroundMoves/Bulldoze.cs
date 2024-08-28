using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.GroundMoves
{
    public class Bulldoze : IMoves
    {
        public string name { get; set; } = "Bulldoze";
        public string description { get; set; } = "Shakes the ground violently beneath the enemy";
        public int power { get; set; } = 45;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 40;
        public int accuracy { get; set; } = 90;
        public IType typing { get; set; } = new Ground();
        public bool physical { get; set; } = true;
    }
}
