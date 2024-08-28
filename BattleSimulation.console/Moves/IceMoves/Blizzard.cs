using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.IceMoves
{
    public class Blizzard : IMoves
    {
        public string name { get; set; } = "Blizzard";
        public string description { get; set; } = "Traps the enemy in a blizzard of snow and ice, this move has a boosted critical hit chance";
        public int power { get; set; } = 90;
        public decimal critChance { get; set; } = 1 / 8;
        public int uses { get; set; } = 15;
        public int accuracy { get; set; } = 95;
        public IType typing { get; set; } = new Ice();
        public bool physical { get; set; } = false;
    }
}
