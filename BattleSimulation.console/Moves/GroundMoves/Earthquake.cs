using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.GroundMoves
{
    public class Earthquake : IMoves
    {
        public string name { get; set; } = "Earthquake";
        public string description { get; set; } = "Causes a massive earthquake, dealing damage to anyone standing in the area";
        public int power { get; set; } = 120;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 10;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Ground();
        public bool physical { get; set; } = true;
    }
}
