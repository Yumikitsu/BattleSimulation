using BattleSimulation.console.Moves;
using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Monsters
{
    public class Ignidrake : IMonster
    {
        public Ignidrake() 
        {
            
        }

        public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int level { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int evolutionLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IStats baseStats { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IStats currentStats { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IMoves> moves { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Dictionary<IMoves, int> learnableMoves { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IType> typing { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Evolve(List<IMonster> party, int index)
        {
            throw new NotImplementedException();
        }

        public void LevelUp(List<IMonster> party, int index)
        {
            throw new NotImplementedException();
        }
    }
}
