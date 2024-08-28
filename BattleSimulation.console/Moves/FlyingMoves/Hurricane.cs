using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.FlyingMoves
{
    public class Hurricane : IMoves
    {
        public string name { get; set; } = "Hurricane";
        public string description { get; set; } = "Creates a devastating hurricane, dealing massive damage to anyone in the vicinity";
        public int power { get; set; } = 150;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 8;
        public int accuracy { get; set; } = 70;
        public IType typing { get; set; } = new Flying();
        public bool physical { get; set; } = false;
    }
}
