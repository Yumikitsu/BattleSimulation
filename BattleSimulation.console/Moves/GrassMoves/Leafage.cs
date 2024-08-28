using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.GrassMoves
{
    public class Leafage
    {
        public string name { get; set; } = "Leafage";
        public string description { get; set; } = "Shoots a bundle of leaves at the enemy";
        public int power { get; set; } = 40;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 40;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Grass();
        public bool physical { get; set; } = true;
    }
}
