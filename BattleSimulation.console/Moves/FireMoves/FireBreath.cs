using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.FireMoves
{
    public class FireBreath : IMoves
    {
        public string name { get; set; } = "Fire Breath";
        public string description { get; set; } = "Emits a fiery breath that desimates anyone in its path";
        public int power { get; set; } = 100;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 15;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Fire();
        public bool physical { get; set; } = false;
    }
}
