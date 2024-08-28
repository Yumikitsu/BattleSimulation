using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.PoisonMoves
{
    public class Corrosion : IMoves
    {
        public string name { get; set; } = "Corrosion";
        public string description { get; set; } = "Emits corrosive poison that corrodes the enemy";
        public int power { get; set; } = 50;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 15;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Poison();
        public bool physical { get; set; } = false;
    }
}
