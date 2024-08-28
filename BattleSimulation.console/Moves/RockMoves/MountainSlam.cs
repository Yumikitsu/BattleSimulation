using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.RockMoves
{
    public class MountainSlam : IMoves
    {
        public string name { get; set; } = "Mountain Slam";
        public string description { get; set; } = "Picks up a mountain and slams it on the enemy";
        public int power { get; set; } = 140;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 5;
        public int accuracy { get; set; } = 80;
        public IType typing { get; set; } = new Rock();
        public bool physical { get; set; } = true;
    }
}
