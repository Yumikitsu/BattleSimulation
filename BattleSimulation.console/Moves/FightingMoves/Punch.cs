using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.FightingMoves
{
    public class Punch : IMoves
    {
        public string name { get; set; } = "Punch";
        public string description { get; set; } = "Punches the enemy in the face, ouch!";
        public int power { get; set; } = 50;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 15;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Fighting();
        public bool physical { get; set; } = true;
    }
}
