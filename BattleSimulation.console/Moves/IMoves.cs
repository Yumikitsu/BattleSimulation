using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves
{
    public interface IMoves
    {
        public string name { get; set; } //Name of the move
        public string description { get; set; } //Description of the move
        public int power { get; set; } //Power of the move
        public decimal critChance { get; set; } //0 - 100 Chance of this move to result in a critical hit
        public int uses { get; set; } //Between 1-40 uses
        public int accuracy { get; set; } //0 - 100 Chance of this move to hit
        public IType typing { get; set; } //Typing of the move
        public bool physical { get; set; } //True = Physical | False = Special
    }
}
