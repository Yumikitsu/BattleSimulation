using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.FairyMoves
{
    public class Adore : IMoves
    {
        public string name { get; set; } = "Adore";
        public string description { get; set; } = "The user adores the enemy, showering them with overwhelming affection";
        public int power { get; set; } = 40;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 40;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Fairy();
        public bool physical { get; set; } = false;
    }
}
