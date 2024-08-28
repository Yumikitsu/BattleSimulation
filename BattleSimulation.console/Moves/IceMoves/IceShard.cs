using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.IceMoves
{
    public class IceShard : IMoves
    {
        public string name { get; set; } = "Ice Shard";
        public string description { get; set; } = "Throws a sizeable shard of ice at the enemy, this move has a boosted critical hit chance";
        public int power { get; set; } = 35;
        public decimal critChance { get; set; } = 1 / 8;
        public int uses { get; set; } = 30;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Ice();
        public bool physical { get; set; } = true;
    }
}
