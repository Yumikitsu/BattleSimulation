using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Types
{
    public class Normal : IType
    {
        public string name { get; set; } = "Normal";

        public List<string> resistances { get; set; } = new List<string>()
        {
        };

        public List<string> immunities { get; set; } = new List<string>()
        {
            "Ghost"
        };

        public List<string> weaknesses { get; set; } = new List<string>()
        {
            "Fighting"
        };
    }
}
