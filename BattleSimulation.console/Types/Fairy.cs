using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Types
{
    public class Fairy : IType
    {
        public string name { get; set; } = "Fairy";

        public List<string> resistances { get; set; } = new List<string>()
        {
            "Fighting",
            "Bug",
            "Dark"
        };

        public List<string> immunities { get; set; } = new List<string>()
        {
            "Dragon"
        };

        public List<string> weaknesses { get; set; } = new List<string>()
        {
            "Poison",
            "Steel"
        };
    }
}
