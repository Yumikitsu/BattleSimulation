using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.DarkMoves
{
    public class ViolentTendencies : IMoves
    {
        public string name { get; set; } = "Violent Tendencies";
        public string description { get; set; } = "The user unleashes a barrage of violent attacks on the enemy";
        public int power { get; set; } = 100;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 15;
        public int accuracy { get; set; } = 90;
        public IType typing { get; set; } = new Dark();
        public bool physical { get; set; } = true;
    }
}
