using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console.Monsters
{
    public class EXP
    {
        //3 different EXP classes
        public int currentEXP {  get; set; }

        public List<int> levelRequirement = new List<int>() //EXP required from lvl 1-100
        {
            0
        };

        public EXP(int level = 1, int levelGroup = 0)
        {
            if(levelGroup == 0) //Fast
            {
                for (int i = 2; i < 100; i++)
                {
                    this.levelRequirement.Add(this.levelRequirement.ElementAt(i - 1) + (int)(108.11 * Math.Pow(i - 1, 1.05)));
                }
            }
            else if(levelGroup == 1) //Medium
            {
                for(int i = 2; i < 100; i++)
                {
                    this.levelRequirement.Add(this.levelRequirement.ElementAt(i - 1) + (int)(108.84 * Math.Pow(i - 1, 0.98)));
                }
            }
            else if(levelGroup == 2) //Slow
            {
                for (int i = 2; i < 100; i++)
                {
                    this.levelRequirement.Add(this.levelRequirement.ElementAt(i - 1) + (int)(111.95 * Math.Pow(i - 1, 1.09)));
                }
            }
            this.currentEXP = this.levelRequirement.ElementAt(level - 1); //Make current EXP the same as the EXP required to reach the given level
        }

    }
}
