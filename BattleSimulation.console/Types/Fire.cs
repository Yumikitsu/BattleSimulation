using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Types
{
    public class Fire : IType
    {
        public string name { get; set; } = "Fire";

        public List<string> resistances { get; set; } = new List<string>()
        {
            "Fire",
            "Grass",
            "Ice",
            "Bug",
            "Steel",
            "Fairy"
        };

        public List<string> immunities { get; set; } = new List<string>()
        {
        };

        public List<string> weaknesses { get; set; } = new List<string>()
        {
            "Water",
            "Ground",
            "Rock"
        };
    }
}
