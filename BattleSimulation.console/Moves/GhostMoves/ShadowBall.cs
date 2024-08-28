using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.GhostMoves
{
    public class ShadowBall : IMoves
    {
        public string name { get; set; } = "Shadow Ball";
        public string description { get; set; } = "Fires a ball of ghost energy at the enemy, this move has a boosted critical hit chance";
        public int power { get; set; } = 80;
        public decimal critChance { get; set; } = 1 / 8;
        public int uses { get; set; } = 20;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Ghost();
        public bool physical { get; set; } = false;
    }
}
