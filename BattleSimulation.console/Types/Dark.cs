using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Types
{
    public class Dark : IType
    {
        public string name { get; set; } = "Dark";

        public List<string> resistances { get; set; } = new List<string>()
        {
            "Ghost",
            "Dark"
        };

        public List<string> immunities { get; set; } = new List<string>()
        {
            "Psychic"
        };

        public List<string> weaknesses { get; set; } = new List<string>()
        {
            "Fighting",
            "Bug",
            "Fairy"
        };
    }
}
