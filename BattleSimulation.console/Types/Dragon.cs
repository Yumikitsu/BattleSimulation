using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Types
{
    public class Dragon : IType
    {
        public string name { get; set; } = "Dragon";

        public List<string> resistances { get; set; } = new List<string>()
        {
            "Fire",
            "Water",
            "Grass",
            "Electric"
        };

        public List<string> immunities { get; set; } = new List<string>()
        {
        };

        public List<string> weaknesses { get; set; } = new List<string>()
        {
            "Ice",
            "Dragon",
            "Fairy"
        };
    }
}
