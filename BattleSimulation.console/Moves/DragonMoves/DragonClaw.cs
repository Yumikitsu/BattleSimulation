using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.DragonMoves
{
    public class DragonClaw : IMoves
    {
        public string name { get; set; } = "Dragon Claw";
        public string description { get; set; } = "Strikes the enemy with a slashing claw attack, this move has a boosted critical hit chance";
        public int power { get; set; } = 55;
        public decimal critChance { get; set; } = 1 / 8;
        public int uses { get; set; } = 20;
        public int accuracy { get; set; } = 90;
        public IType typing { get; set; } = new Dragon();
        public bool physical { get; set; } = true;
    }
}
