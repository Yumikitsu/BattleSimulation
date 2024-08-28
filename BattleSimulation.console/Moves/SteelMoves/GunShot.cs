using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.SteelMoves
{
    public class GunShot : IMoves
    {
        public string name { get; set; } = "Gun Shot";
        public string description { get; set; } = "Shoots the enemy with a gun, this move has a boosted critical hit chance";
        public int power { get; set; } = 100;
        public decimal critChance { get; set; } = 1 / 8;
        public int uses { get; set; } = 3;
        public int accuracy { get; set; } = 95;
        public IType typing { get; set; } = new Steel();
        public bool physical { get; set; } = true;
    }
}
