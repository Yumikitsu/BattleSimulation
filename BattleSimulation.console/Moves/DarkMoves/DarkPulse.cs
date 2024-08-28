using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.DarkMoves
{
    public class DarkPulse : IMoves
    {
        public string name { get; set; } = "Dark Pulse";
        public string description { get; set; } = "Emits a pulse originating from pure dark matter to inflict psychological damage on the enemy";
        public int power { get; set; } = 80;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 20;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Dark();
        public bool physical { get; set; } = false;
    }
}
