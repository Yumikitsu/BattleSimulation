using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves.PoisonMoves
{
    public class ChemicalWarfare : IMoves
    {
        public string name { get; set; } = "Chemical Warfare";
        public string description { get; set; } = "Covers the area with powerful chemicals that no enemy can withstand";
        public int power { get; set; } = 150;
        public decimal critChance { get; set; } = 1 / 16;
        public int uses { get; set; } = 3;
        public int accuracy { get; set; } = 100;
        public IType typing { get; set; } = new Poison();
        public bool physical { get; set; } = false;
    }
}
