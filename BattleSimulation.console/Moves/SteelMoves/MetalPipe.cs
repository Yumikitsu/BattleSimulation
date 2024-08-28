using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.SteelMoves
{
    public class MetalPipe : IMoves
    {
        public string name { get; set; } = "Metal Pipe";
        public string description { get; set; } = "Throws a metal pipe at the enemy";
        public int power { get; set; } = 75;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 20;
        public int accuracy { get; set; } = 95;
        public IType typing { get; set; } = new Steel();
        public bool physical { get; set; } = true;
    }
}
