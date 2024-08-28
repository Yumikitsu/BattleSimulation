using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.NormalMoves
{
    public class BodySlam : IMoves
    {
        public string name { get; set; } = "Body Slam";
        public string description { get; set; } = "Uses the weight of their body to slam against the enemy";
        public int power { get; set; } = 80;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 20;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Normal();
        public bool physical { get; set; } = true;
    }
}
