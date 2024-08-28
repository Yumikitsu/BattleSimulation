using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.PsychicMoves
{
    public class PsychicBlast : IMoves
    {
        public string name { get; set; } = "Psychic Blast";
        public string description { get; set; } = "Harnesses raw psychic power to blast the enemy";
        public int power { get; set; } = 95;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 15;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Psychic();
        public bool physical { get; set; } = true;
    }
}
