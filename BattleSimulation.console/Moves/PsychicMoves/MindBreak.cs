using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.PsychicMoves
{
    public class MindBreak : IMoves
    {
        public string name { get; set; } = "Mind Break";
        public string description { get; set; } = "Breaks the mind of the enemy, by forcing them to think uncomfortable thoughts repeatedly";
        public int power { get; set; } = 45;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 30;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Psychic();
        public bool physical { get; set; } = false;
    }
}
