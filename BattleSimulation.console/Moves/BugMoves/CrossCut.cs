using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.BugMoves
{
    public class CrossCut : IMoves
    {
        public string name { get; set; } = "Cross Cut";
        public string description { get; set; } = "Uses their mandibles to cut the enemy with a cross shaped attacked, this move has a boosted critical hit chance";
        public int power { get; set; } = 80;
        public decimal critChance { get; set; } = 1 / 8;
        public int uses { get; set; } = 20;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Bug();
        public bool physical { get; set; } = true;
    }
}
