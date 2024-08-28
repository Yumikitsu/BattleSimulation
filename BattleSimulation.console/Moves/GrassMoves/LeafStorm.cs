using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.GrassMoves
{
    public class LeafStorm : IMoves
    {
        public string name { get; set; } = "Leaf Storm";
        public string description { get; set; } = "Unleashes a storm of leaves that damage everything it comes into contact with";
        public int power { get; set; } = 100;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 10;
        public int accuracy { get; set; } = 95;
        public IType typing { get; set; } = new Grass();
        public bool physical { get; set; } = false;
    }
}
