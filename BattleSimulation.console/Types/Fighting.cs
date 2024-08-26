using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Types
{
    public class Fighting : IType
    {
        public string name { get; set; } = "Fighting";

        public List<string> resistances { get; set; } = new List<string>()
        {
            "Bug",
            "Rock",
            "Dark"
        };

        public List<string> immunities { get; set; } = new List<string>()
        {
        };

        public List<string> weaknesses { get; set; } = new List<string>()
        {
            "Flying",
            "Psychic",
            "Fairy"
        };
    }
}
