using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.ElectricMoves
{
    public class ThunderousBeam : IMoves
    {
        public string name { get; set; } = "Thunderous Beam";
        public string description { get; set; } = "Unleashes a beam of high voltage energy directed at the enemy";
        public int power { get; set; } = 95;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 15;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Electric();
        public bool physical { get; set; } = false;
    }
}
