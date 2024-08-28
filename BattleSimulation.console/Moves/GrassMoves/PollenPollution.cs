using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.GrassMoves
{
    public class PollenPollution : IMoves
    {
        public string name { get; set; } = "Pollen Pollution";
        public string description { get; set; } = "Pollutes the air with pollen, making it difficult for enemies to breathe";
        public int power { get; set; } = 40;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 30;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Grass();
        public bool physical { get; set; } = false;
    }
}
