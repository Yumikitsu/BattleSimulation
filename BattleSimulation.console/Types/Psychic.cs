using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Types
{
    public class Psychic : IType
    {
        public string name { get; set; } = "Psychic";

        public List<string> resistances { get; set; } = new List<string>()
        {
            "Fighting",
            "Psychic"
        };

        public List<string> immunities { get; set; } = new List<string>()
        {
        };

        public List<string> weaknesses { get; set; } = new List<string>()
        {
            "Bug",
            "Ghost",
            "Dark"
        };
    }
}
