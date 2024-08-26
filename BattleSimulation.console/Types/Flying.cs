using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Types
{
    public class Flying : IType
    {
        public string name { get; set; } = "Flying";

        public List<string> resistances { get; set; } = new List<string>()
        {
            "Grass",
            "Fighting",
            "Bug"
        };

        public List<string> immunities { get; set; } = new List<string>()
        {
            "Ground"
        };

        public List<string> weaknesses { get; set; } = new List<string>()
        {
            "Electric",
            "Ice",
            "Rock"
        };
    }
}
