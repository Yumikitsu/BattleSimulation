using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.FlyingMoves
{
    public class WindBlade : IMoves
    {
        public string name { get; set; } = "Wind Blade";
        public string description { get; set; } = "Slices the enemy with highly compressed air, this move has a very boosted critical hit chance";
        public int power { get; set; } = 70;
        public decimal critChance { get; set; } = 1 / 4;
        public int uses { get; set; } = 15;
        public int accuracy { get; set; } = 95;
        public IType typing { get; set; } = new Flying();
        public bool physical { get; set; } = true;
    }
}
