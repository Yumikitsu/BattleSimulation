using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.WaterMoves
{
    public class AquaLance : IMoves
    {
        public string name { get; set; } = "Aqua Lance";
        public string description { get; set; } = "Throws a lance made out of water at the enemy, this move has a boosted critical hit chance";
        public int power { get; set; } = 85;
        public decimal critChance { get; set; } = 1 / 8;
        public int uses { get; set; } = 20;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Water();
        public bool physical { get; set; } = true;
    }
}
