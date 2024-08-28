using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.NormalMoves
{
    public class Tackle : IMoves
    {
        public string name { get; set; } = "Tackle";
        public string description { get; set; } = "Charge towards the enemy and tackle them";
        public int power { get; set; } = 35;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 40;
        public int accuracy { get; set; } = 95;
        public IType typing { get; set; } = new Normal();
        public bool physical { get; set; } = true;
    }
}
