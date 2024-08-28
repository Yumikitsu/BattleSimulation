using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.FireMoves
{
    public class FlareFist : IMoves
    {
        public string name { get; set; } = "Flare Fist";
        public string description { get; set; } = "Covers the users fist in fire and strikes the enemy, this move has a boosted critical hit chance";
        public int power { get; set; } = 70;
        public decimal critChance { get; set; } = 1 / 8;
        public int uses { get; set; } = 25;
        public int accuracy { get; set; } = 95;
        public IType typing { get; set; } = new Fire();
        public bool physical { get; set; } = true;
    }
}
