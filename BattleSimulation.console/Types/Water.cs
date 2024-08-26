using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Types
{
    public class Water : IType
    {
        public string name { get; set; } = "Water";

        public List<string> resistances { get; set; } = new List<string>()
        {
            "Fire",
            "Water",
            "Ice",
            "Steel"
        };

        public List<string> immunities { get; set; } = new List<string>()
        {
        };

        public List<string> weaknesses { get; set; } = new List<string>()
        {
            "Grass",
            "Electric"
        };
    }
}
