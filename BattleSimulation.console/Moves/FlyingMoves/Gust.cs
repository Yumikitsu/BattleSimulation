using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.FlyingMoves
{
    public class Gust : IMoves
    {
        public string name { get; set; } = "Gust";
        public string description { get; set; } = "Forms a gust of wind breaking the stance of the enemy";
        public int power { get; set; } = 40;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 40;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Flying();
        public bool physical { get; set; } = false;
    }
}
