using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.FightingMoves
{
    public class Pummeling : IMoves
    {
        public string name { get; set; } = "Pummeling";
        public string description { get; set; } = "Strikes the enemy with their fists repeatedly";
        public int power { get; set; } = 75;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 20;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Fighting();
        public bool physical { get; set; } = true;
    }
}
