using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.FlyingMoves
{
    public class Peck : IMoves
    {
        public string name { get; set; } = "Peck";
        public string description { get; set; } = "The user pecks the enemy with their sharp beak, this move has a boosted critical hit chance";
        public int power { get; set; } = 35;
        public decimal critChance { get; set; } = 1 / 8;
        public int uses { get; set; } = 20;
        public int accuracy { get; set; } = 95;
        public IType typing { get; set; } = new Flying();
        public bool physical { get; set; } = true;
    }
}
