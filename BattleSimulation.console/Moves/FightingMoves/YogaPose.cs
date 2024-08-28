using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.FightingMoves
{
    public class YogaPose : IMoves
    {
        public string name { get; set; } = "Yoga Pose";
        public string description { get; set; } = "The user strikes a complex yoga pose that the enemy tries to mimic, but fails";
        public int power { get; set; } = 35;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 40;
        public int accuracy { get; set; } = 95;
        public IType typing { get; set; } = new Fighting();
        public bool physical { get; set; } = false;
    }
}
