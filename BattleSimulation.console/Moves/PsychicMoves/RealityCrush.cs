using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.PsychicMoves
{
    public class RealityCrush : IMoves
    {
        public string name { get; set; } = "Reality Crush";
        public string description { get; set; } = "Breaks the laws of the physics by multiplying the gravity around the enemy, forcing them to be crushed under immense pressure";
        public int power { get; set; } = 110;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 15;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Psychic();
        public bool physical { get; set; } = true;
    }
}
