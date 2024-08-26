using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Types
{
    public class Grass : IType
    {
        public string name { get; set; } = "Grass";

        public List<string> resistances { get; set; } = new List<string>()
        {
            "Water",
            "Grass",
            "Electric",
            "Ground"
        };

        public List<string> immunities { get; set; } = new List<string>()
        {
        };

        public List<string> weaknesses { get; set; } = new List<string>()
        {
            "Fire",
            "Ice",
            "Poison",
            "Bug"
        };
    }
}
