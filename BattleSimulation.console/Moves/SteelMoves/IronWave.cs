using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.SteelMoves
{
    public class IronWave : IMoves
    {
        public string name { get; set; } = "Iron Wave";
        public string description { get; set; } = "Sends out sound waves that vibrates the iron found in the enemy, causing them to feel immense pain";
        public int power { get; set; } = 35;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 30;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Steel();
        public bool physical { get; set; } = false;
    }
}
