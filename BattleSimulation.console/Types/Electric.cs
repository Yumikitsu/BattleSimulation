using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Types
{
    public class Electric : IType
    {
        public string name { get; set; } = "Electric";

        public List<string> resistances { get; set; } = new List<string>()
        {
            "Electric",
            "Flying",
            "Steel"
        };

        public List<string> immunities { get; set; } = new List<string>()
        {
        };

        public List<string> weaknesses { get; set; } = new List<string>()
        {
            "Ground"
        };
    }
}
