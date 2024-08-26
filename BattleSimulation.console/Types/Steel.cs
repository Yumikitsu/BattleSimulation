using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Types
{
    public class Steel : IType
    {
        public string name { get; set; } = "Steel";

        public List<string> resistances { get; set; } = new List<string>()
        {
            "Normal",
            "Grass",
            "Ice",
            "Flying",
            "Psychic",
            "Bug",
            "Rock",
            "Dragon",
            "Steel",
            "Fairy"
        };

        public List<string> immunities { get; set; } = new List<string>()
        {
            "Poison"
        };

        public List<string> weaknesses { get; set; } = new List<string>()
        {
            "Fire",
            "Fighting",
            "Ground"
        };
    }
}
