using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.ElectricMoves
{
    public class Zap : IMoves
    {
        public string name { get; set; } = "Zap";
        public string description { get; set; } = "Zaps the enemy with electricity";
        public int power { get; set; } = 40;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 40;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Electric();
        public bool physical { get; set; } = false;
    }
}
