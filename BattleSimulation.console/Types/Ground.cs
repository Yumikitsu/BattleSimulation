using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Types
{
    public class Ground : IType
    {
        public string name { get; set; } = "Ground";

        public List<string> resistances { get; set; } = new List<string>()
        {
            "Poison",
            "Rock"
        };

        public List<string> immunities { get; set; } = new List<string>()
        {
            "Electric"
        };

        public List<string> weaknesses { get; set; } = new List<string>()
        {
            "Water",
            "Grass",
            "Ice"
        };
    }
}
