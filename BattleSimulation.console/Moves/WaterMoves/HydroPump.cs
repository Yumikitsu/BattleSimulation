using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.WaterMoves
{
    public class HydroPump : IMoves
    {
        public string name { get; set; } = "Hydro Pump";
        public string description { get; set; } = "Creates a highly pressurized water beam directed at the enemy";
        public int power { get; set; } = 120;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 10;
        public int accuracy { get; set; } = 85;
        public IType typing { get; set; } = new Water();
        public bool physical { get; set; } = false;
    }
}
