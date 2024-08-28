using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.DragonMoves
{
    public class AncestralRoar : IMoves
    {
        public string name { get; set; } = "Ancestral Roar";
        public string description { get; set; } = "Unleashes a powerful roar originating from thousand years of dominance";
        public int power { get; set; } = 90;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 15;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Dragon();
        public bool physical { get; set; } = false;
    }
}
