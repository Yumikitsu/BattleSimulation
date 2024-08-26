using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Types
{
    public class Poison : IType
    {
        public string name { get; set; } = "Poison";

        public List<string> resistances { get; set; } = new List<string>()
        {
            "Grass",
            "Fighting",
            "Poison",
            "Bug",
            "Fairy"
        };

        public List<string> immunities { get; set; } = new List<string>()
        {
        };

        public List<string> weaknesses { get; set; } = new List<string>()
        {
            "Ground",
            "Psychic"
        };
    }
}
