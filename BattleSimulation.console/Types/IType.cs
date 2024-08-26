using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Types
{
    public interface IType
    {
        string name { get; set; }

        public List<string> resistances { get; set; }
        public List<string> immunities { get; set; }
        public List<string> weaknesses { get; set; }
    }
}
