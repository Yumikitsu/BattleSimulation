using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Items
{
    public interface Item
    {
        public string name { get; set; }
        public string description { get; set; }
        public int price { get; set; }
    }
}
