using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.FireMoves
{
    public class FlameSlice : IMoves
    {
        public string name { get; set; } = "Flame Slice";
        public string description { get; set; } = "Slices the enemy with a concentrated blade of fire";
        public int power { get; set; } = 45;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 20;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Fire();
        public bool physical { get; set; } = true;
    }
}
