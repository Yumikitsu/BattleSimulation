using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.DarkMoves
{
    public class TrashTalk : IMoves
    {
        public string name { get; set; } = "Trash Talk";
        public string description { get; set; } = "Talks trash about the appearance of the enemy, resulting in discomfort";
        public int power { get; set; } = 40;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 40;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Dark();
        public bool physical { get; set; } = false;
    }
}
