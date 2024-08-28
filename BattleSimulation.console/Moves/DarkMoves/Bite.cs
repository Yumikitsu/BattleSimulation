using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.DarkMoves
{
    public class Bite : IMoves
    {
        public string name { get; set; } = "Bite";
        public string description { get; set; } = "Lounges towards the enemy and bites down on them";
        public int power { get; set; } = 50;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 20;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Dark();
        public bool physical { get; set; } = true;
    }
}
