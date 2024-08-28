using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.ElectricMoves
{
    public class Nuzzle : IMoves
    {
        public string name { get; set; } = "Nuzzle";
        public string description { get; set; } = "Nuzzles the enemy with an electrical current, this move has a boosted critical hit chance";
        public int power { get; set; } = 35;
        public decimal critChance { get; set; } = 1 / 8;
        public int uses { get; set; } = 40;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Electric();
        public bool physical { get; set; } = true;
    }
}
