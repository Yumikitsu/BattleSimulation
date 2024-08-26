using BattleSimulation.console.Moves;
using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Monsters
{
    public interface IMonster
    {
        public string name { get; set; } //Name of the monster
        public int level { get; set; } //Current level of the monster
        public IStats baseStats { get; set; } //Base stats of the monster
        public IStats currentStats { get; set; } //HP = 10 + (1 * level) + ((baseHP * level) / 50)) | Everything else = 5 + ((base * level) / 50)
        public List<IMoves> moves { get; set; } //List of all moves the monster has available (Max 4 at a time)
        public Dictionary<IMoves, int> learnableMoves { get; set; } //List of all learnable moves and the level they can be taught at
        public List<IType> typing { get; set; } //List of all typings the monster has (Max 2)
    }
}
