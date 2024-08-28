using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.NormalMoves
{
    public class HyperBeam : IMoves
    {
        public string name { get; set; } = "Hyper Beam";
        public string description { get; set; } = "Unleashes a powerful beam of energy directed at the enemy";
        public int power { get; set; } = 120;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 5;
        public int accuracy { get; set; } = 95;
        public IType typing { get; set; } = new Normal();
        public bool physical { get; set; } = false;
    }
}
