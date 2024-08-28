using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.FairyMoves
{
    public class RadiantFlare : IMoves
    {
        public string name { get; set; } = "Radiant Flare";
        public string description { get; set; } = "Flares up and blinds the enemy by emitting radiant energy";
        public int power { get; set; } = 95;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 10;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Fairy();
        public bool physical { get; set; } = false;
    }
}
