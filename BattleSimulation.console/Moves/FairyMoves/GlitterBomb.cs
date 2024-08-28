using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.FairyMoves
{
    public class GlitterBomb : IMoves
    {
        public string name { get; set; } = "Glitter Bomb";
        public string description { get; set; } = "Creates an explosion of sparkles beneath the enemy";
        public int power { get; set; } = 50;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 20;
        public int accuracy { get; set; } = 90;
        public IType typing { get; set; } = new Fairy();
        public bool physical { get; set; } = true;
    }
}
