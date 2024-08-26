using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves
{
    public class Ember : IMoves
    {
        public string name { get; set; } = "Ember";
        public string description { get; set; } = "Fires off small embers to heat up enemies";
        public int power { get; set; } = 40;
        public int uses { get; set; } = 20;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Fire();
        public bool physical { get; set; } = false;
    }
}
