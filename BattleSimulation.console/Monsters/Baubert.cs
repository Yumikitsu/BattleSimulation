using BattleSimulation.console.Moves.GrassMoves;
using BattleSimulation.console.Moves.NormalMoves;
using BattleSimulation.console.Moves.WaterMoves;
using BattleSimulation.console.Moves;
using BattleSimulation.console.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleSimulation.console.Moves.SteelMoves;

namespace BattleSimulation.console.Monsters
{
    public class Baubert : IMonster
    {
        public string name { get; set; } = "Baubert";
        public int level { get; set; }
        public EXP experience { get; set; }
        public int evolutionLevel { get; set; } = 30;
        public Stats baseStats { get; set; } = new Stats()
        {
            //Total = 360
            HP = 50,
            ATK = 40,
            DEF = 55,
            Sp_ATK = 80,
            Sp_DEF = 75,
            SPD = 60
        };
        public Stats currentStats { get; set; }
        public List<IMoves> moves { get; set; }
        public Dictionary<int, IMoves> learnableMoves { get; set; } = new Dictionary<int, IMoves>()
        {
            //List out all moves it can learn and at what level it can learn it
            { 1, new Scream() },
            { 6, new Bubble() },
            { 12, new Leafage() },
            { 18, new LiquidMetal() },
            { 27, new HydroPump() }
        };
        public List<IType> typing { get; set; } = new List<IType>()
        {
            { new Water() }
        };

        public void Evolve(List<IMonster> party, int index) //This method only exists in monsters that can evolve
        {
            party[index] = new Bauberry(this.level, this.experience, this.moves); //Replace the monster in the index position with the evolved version
            Console.WriteLine($"Congratulations! Your {this.name} evolved into {party[index].name}!");
        }

        public void LevelUp(List<IMonster> party, int index)
        {
            while (true) //Level up until we can't anymore
            {
                if (this.experience.currentEXP >= this.experience.levelRequirement.ElementAt(this.level - 1)) //Level up will occur
                {
                    this.level += 1;
                    Console.WriteLine($"{this.name} leveled up to lv.{this.level}!");
                    if (learnableMoves.ContainsKey(this.level)) //If a new move can be taught at this level
                    {
                        if (this.moves.Count == 4) //If they have 4 moves already
                        {
                            while (true) //Read input until a valid on is selected
                            {
                                Console.WriteLine($"{this.name} is trying to learn {learnableMoves[this.level].name} do you want you want to learn this move?\n1. Yes\n2. No");
                                string input = Console.ReadLine() ?? string.Empty;
                                if (input == "1")
                                {
                                    while (true) //Read input until a valid one is selected
                                    {
                                        Console.WriteLine($"Which move would you like to replace?\n1. {this.moves.ElementAt(0).name}\n2. {this.moves.ElementAt(1).name}\n3. {this.moves.ElementAt(2).name}\n4. {this.moves.ElementAt(3).name}\n5. Cancel");
                                        input = Console.ReadLine() ?? string.Empty;
                                        if (input == "1")
                                        {
                                            this.moves[0] = learnableMoves[this.level];
                                        }
                                        else if (input == "2")
                                        {
                                            this.moves[1] = learnableMoves[this.level];
                                        }
                                        else if (input == "3")
                                        {
                                            this.moves[2] = learnableMoves[this.level];
                                        }
                                        else if (input == "4")
                                        {
                                            this.moves[3] = learnableMoves[this.level];
                                        }
                                        else if (input == "5")
                                        {
                                            break;
                                        }
                                    }
                                }
                                else if (input == "2")
                                {
                                    break;
                                }
                            }
                        }
                        else //Add new move
                        {
                            this.moves.Add(learnableMoves[this.level]);
                            Console.WriteLine($"{this.name} learnt {learnableMoves[this.level].name}!");
                        }
                    }

                    //If the evolution level is met upon leveling up, make the monster at the current party location to the evolved version of this monster.
                    if (!(this.experience.currentEXP >= this.experience.levelRequirement.ElementAt(this.level - 1)) && this.level >= this.evolutionLevel)
                    {
                        this.Evolve(party, index);
                    }
                }
                else
                {
                    break;
                }
            }
        }

        public Baubert(int level, EXP? exp = null, List<IMoves>? moves = null)
        {
            //Level
            this.level = level;

            //Experience points
            if (exp != null)
            {
                this.experience = exp;
            }
            else
            {
                this.experience = new EXP(level, 1); //0 | 1 | 2 = Fast | Medium | Slow EXP group
            }

            //Current stats
            this.currentStats = new Stats()
            {
                HP = 10 + (1 * this.level) + ((this.baseStats.HP * this.level) / 50),
                ATK = 5 + ((this.baseStats.ATK * this.level) / 50),
                DEF = 5 + ((this.baseStats.DEF * this.level) / 50),
                Sp_ATK = 5 + ((this.baseStats.Sp_ATK * this.level) / 50),
                Sp_DEF = 5 + ((this.baseStats.Sp_DEF * this.level) / 50),
                SPD = 5 + ((this.baseStats.SPD * this.level) / 50)
            };

            //Current moves
            if (moves != null)
            {
                this.moves = moves;
            }
            else
            {
                this.moves = new List<IMoves>();
                for (int i = 4; i > 0; i--)
                {
                    int highestLvl = 0;
                    foreach (var move in learnableMoves)
                    {
                        if (move.Key <= this.level && !this.moves.Contains(move.Value) && move.Key > highestLvl)
                        {
                            highestLvl = move.Key;
                        }
                    }

                    if (highestLvl != 0)
                    {
                        this.moves.Add(learnableMoves[highestLvl]);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
