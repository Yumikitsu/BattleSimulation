using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Moves
{
    public class IMoves
    {
        public string name { get; set; }
        public string nescription { get; set; }
        public int power { get; set; }
        public int uses { get; set; }
        public decimal accuracy { get; set; }
        public string typing { get; set; }
    }
}
