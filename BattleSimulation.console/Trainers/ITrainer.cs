using BattleSimulation.console.Monsters;
using BattleSimulation.console.Moves;
using BattleSimulation.console.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Trainers
{
    public interface ITrainer
    {
        public string name { get; set; } //Name of the trainer
        public List<IMonster> party { get; set; } //Their party of monsters
        public int currentMonster { get; set; } //Index pointing to current monster being used
        public int difficulty { get; set; } //0 - 100 (0 = Totally random move selection, 100 = Always uses best moves)
        public IMoves Action(); //Decide what move to select and use it to attack the player
    }
}
