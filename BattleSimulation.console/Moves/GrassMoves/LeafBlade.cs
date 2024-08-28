using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.GrassMoves
{
    public class LeafBlade : IMoves
    {
        public string name { get; set; } = "Leaf Blade";
        public string description { get; set; } = "Uses razor sharp leaves to slice through the enemy, this move has a boosted critical hit chance";
        public int power { get; set; } = 80;
        public decimal critChance { get; set; } = 1 / 8;
        public int uses { get; set; } = 20;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Grass();
        public bool physical { get; set; } = true;
    }
}
