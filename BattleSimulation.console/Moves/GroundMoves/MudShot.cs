using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.GroundMoves
{
    public class MudShot : IMoves
    {
        public string name { get; set; } = "Mud Shot";
        public string description { get; set; } = "Shoots a ball of mud at the enemy";
        public int power { get; set; } = 50;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 20;
        public int accuracy { get; set; } = 85;
        public IType typing { get; set; } = new Ground();
        public bool physical { get; set; } = false;
    }
}
