using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.PoisonMoves
{
    public class PoisonJab : IMoves
    {
        public string name { get; set; } = "Poison Jab";
        public string description { get; set; } = "Strikes the enemy with jabs covered in poison, this move has a boosted critical hit chance";
        public int power { get; set; } = 75;
        public decimal critChance { get; set; } = 1 / 8;
        public int uses { get; set; } = 20;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Poison();
        public bool physical { get; set; } = true;
    }
}
