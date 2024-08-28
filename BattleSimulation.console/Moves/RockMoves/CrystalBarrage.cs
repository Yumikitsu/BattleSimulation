using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.RockMoves
{
    public class CrystalBarrage : IMoves
    {
        public string name { get; set; } = "Crystal Barrage";
        public string description { get; set; } = "Compresses stones enough to create sharp crystals that rain down on the enemy, this move has a boosted critical hit chance";
        public int power { get; set; } = 90;
        public decimal critChance { get; set; } = 1 / 8;
        public int uses { get; set; } = 15;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Rock();
        public bool physical { get; set; } = false;
    }
}
