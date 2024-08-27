using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves
{
    public class Bubble : IMoves
    {
        public string name { get; set; } = "Bubble";
        public string description { get; set; } = "Cover the enemy with popping bubbles";
        public int power { get; set; } = 40;
        public int uses { get; set; } = 40;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Water();
        public bool physical { get; set; } = false;
    }
}
