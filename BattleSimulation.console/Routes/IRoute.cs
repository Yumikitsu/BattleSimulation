using BattleSimulation.console.Monsters;
using BattleSimulation.console.Moves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Routes
{
    public interface IRoute
    {
        public string name { get; set; } //Name of the route
        public List<IMonster> monsters { get; set; } //List of all available monsters in the area
        public int minLevel { get; set; } //Minimum level of a monster in this area
        public int maxLevel { get; set; } //Maximum level of a monster in this area
        public IMonster Encounter(); //Method to calculate and build what monster to encounter in the area.
        public IMoves Action(); //Decide what move the wild monster should use
    }
}
