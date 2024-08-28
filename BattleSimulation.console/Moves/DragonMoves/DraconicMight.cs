using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.DragonMoves
{
    public class DraconicMight : IMoves
    {
        public string name { get; set; } = "Draconic Might";
        public string description { get; set; } = "In a display of raw excellence, utterly crush the enemy with overwhelming strength, this move has a boosted critical hit chance";
        public int power { get; set; } = 130;
        public decimal critChance { get; set; } = 1 / 8;
        public int uses { get; set; } = 5;
        public int accuracy { get; set; } = 90;
        public IType typing { get; set; } = new Dragon();
        public bool physical { get; set; } = true;
    }
}
