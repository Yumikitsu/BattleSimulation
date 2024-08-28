using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.IceMoves
{
    public class FrostBreath : IMoves
    {
        public string name { get; set; } = "Frost Breath";
        public string description { get; set; } = "Freezes the enemy with a breath colder than ice";
        public int power { get; set; } = 45;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 20;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Ice();
        public bool physical { get; set; } = false;
    }
}
