using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Types
{
    public class Ghost : IType
    {
        public string name { get; set; } = "Ghost";

        public List<string> resistances { get; set; } = new List<string>()
        {
            "Poison",
            "Bug"
        };

        public List<string> immunities { get; set; } = new List<string>()
        {
            "Normal",
            "Fighting"
        };

        public List<string> weaknesses { get; set; } = new List<string>()
        {
            "Ghost",
            "Dark"
        };
    }
}
