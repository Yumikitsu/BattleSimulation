using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.FightingMoves
{
    public class AuraSphere : IMoves
    {
        public string name { get; set; } = "Aura Sphere";
        public string description { get; set; } = "Charges up and unleashes a powerful sphere of spiritual energy at the enemy, this move has a boosted critical hit chance";
        public int power { get; set; } = 80;
        public decimal critChance { get; set; } = 1 / 8;
        public int uses { get; set; } = 20;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Fighting();
        public bool physical { get; set; } = false;
    }
}
