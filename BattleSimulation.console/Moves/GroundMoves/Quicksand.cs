using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.GroundMoves
{
    public class Quicksand : IMoves
    {
        public string name { get; set; } = "Quicksand";
        public string description { get; set; } = "Causes the ground to turn soft and traps the enemy in quicksand";
        public int power { get; set; } = 90;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 20;
        public int accuracy { get; set; } = 90;
        public IType typing { get; set; } = new Ground();
        public bool physical { get; set; } = false;
    }
}
