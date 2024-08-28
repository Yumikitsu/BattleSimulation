using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.PsychicMoves
{
    public class SpoonShock : IMoves
    {
        public string name { get; set; } = "Spoon Shock";
        public string description { get; set; } = "Shock the enemy by bending a spoon infront of them and then throw it at them when they least expect it";
        public int power { get; set; } = 40;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 40;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Psychic();
        public bool physical { get; set; } = true;
    }
}
