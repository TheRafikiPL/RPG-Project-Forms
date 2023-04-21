using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Project
{
    static class BattleProperties
    {
        static public List<bool> Turns = new List<bool>();
        static public List<Character> Party = new List<Character>();
        static public List<Character> Troops = new List<Character>(); 
        static public List<Skill> SkillList = new List<Skill>();
        static public bool IsPlayerTurn = true;
        static public void CalculateTurns(AffinityRelation af)
        {
            switch(af)
            {
                case AffinityRelation.WEAK:
                    PressTurn();
                    break;
                case AffinityRelation.NULL:
                    DeleteTurns(2);
                    break;
                case AffinityRelation.REPEL:
                    DeleteTurns(Turns.Count);
                    break;
                default:
                    DeleteTurns();
                    break;
            }
        }
        static public void PressTurn()
        {
            for (int i = Turns.Count-1; i >= 0; i--)
            {
                if (Turns[i])
                {
                    Turns[i] = false;
                    return;
                }
            }
            Turns.RemoveAt(Turns.Count-1);
        }
        static public void DeleteTurns(int quantity=1)
        {
            if(quantity > Turns.Count)
            {
                quantity = Turns.Count;
            }
            for (int i = 0; i < quantity; i++)
            {
                Turns.RemoveAt(Turns.Count - 1);
            }
        }
        static public int AffinityToInt(Affinity aff)
        {
            switch(aff)
            {
                case Affinity.PHYSICAL:
                    return 0;
                case Affinity.FIRE:
                    return 1;
                case Affinity.ICE:
                    return 2;
                case Affinity.WIND:
                    return 3;
                case Affinity.ELECTRICITY:
                    return 4;
                case Affinity.LIGHT:
                    return 5;
                case Affinity.DARKNESS:
                    return 6;
                case Affinity.ALMIGHTY:
                    return 7;
                default:
                    return -1;
            }
        }
        static public void ResetBattleProperties()
        {
            Turns = new List<bool>();
            Party = new List<Character>();
            Troops = new List<Character>();
            IsPlayerTurn = true;
        }
        static public void FillSkillList()
        {
            SkillList.Add(new Skill("Attack", "Default attack", 0, CostType.None, 100, Affinity.PHYSICAL,TargetChoice.ONE_ENEMY));
            SkillList.Add(new Skill("Guard", "Half damage from next attack", 0, CostType.None, 0, Affinity.NONE, TargetChoice.SELF,new KeyValuePair<Effect, int>(Effect.GUARD,1)));
            SkillList.Add(new Skill("Strike", "High physical damage to 1 oponnent", 13, CostType.HP, 300, Affinity.PHYSICAL, TargetChoice.ONE_ENEMY));
            SkillList.Add(new Skill("Blade Rain", "High physical damage to all oponnents", 26, CostType.HP, 300, Affinity.PHYSICAL, TargetChoice.ALL_ENEMY));
            SkillList.Add(new Skill("Fire Ball", "High fire damage to 1 oponnent", 16, CostType.MP, 300, Affinity.FIRE, TargetChoice.ONE_ENEMY));
            SkillList.Add(new Skill("Fire Storm", "High fire damage to all oponnents", 30, CostType.MP,300, Affinity.FIRE, TargetChoice.ALL_ENEMY));
            SkillList.Add(new Skill("Ice Bolt", "High ice damage to 1 oponnent", 16, CostType.MP, 300, Affinity.ICE, TargetChoice.ONE_ENEMY));
            SkillList.Add(new Skill("Cold Wave", "High ice damage to all oponnents", 30, CostType.MP, 300, Affinity.ICE, TargetChoice.ALL_ENEMY));
            SkillList.Add(new Skill("WindOne", "High wind damage to 1 oponnent", 16, CostType.MP, 300, Affinity.WIND, TargetChoice.ONE_ENEMY));
            SkillList.Add(new Skill("WindAll", "High wind damage to all oponnents", 30, CostType.MP, 300, Affinity.WIND, TargetChoice.ALL_ENEMY));
            SkillList.Add(new Skill("Voltage Shot", "High electricity damage to 1 oponnent", 16, CostType.MP, 300, Affinity.ELECTRICITY, TargetChoice.ONE_ENEMY));
            SkillList.Add(new Skill("Thunder Crush", "High electricity damage to all oponnents", 30, CostType.MP, 300, Affinity.ELECTRICITY, TargetChoice.ALL_ENEMY));
            SkillList.Add(new Skill("LightOne", "High light damage to 1 oponnent", 16, CostType.MP, 300, Affinity.LIGHT, TargetChoice.ONE_ENEMY));
            SkillList.Add(new Skill("LightAll", "High light damage to all oponnents", 30, CostType.MP, 300, Affinity.LIGHT, TargetChoice.ALL_ENEMY));
            SkillList.Add(new Skill("Dark Missile", "High darkness damage to 1 oponnent", 16, CostType.MP, 300, Affinity.DARKNESS, TargetChoice.ONE_ENEMY));
            SkillList.Add(new Skill("Halls of Darkness", "High darkness damage to all oponnents", 30, CostType.MP, 300, Affinity.DARKNESS, TargetChoice.ALL_ENEMY));
            SkillList.Add(new Skill("God's Judgment", "High almighty damage to all oponnents", 40, CostType.MP, 300, Affinity.ALMIGHTY, TargetChoice.ALL_ENEMY));
            SkillList.Add(new Skill("Great Heal", "Heal 100% HP for one ally", 30, CostType.MP, 100, Affinity.NONE, TargetChoice.ONE_PARTY));
            SkillList.Add(new Skill("Salvation", "Heal 100% HP for all allies", 50, CostType.MP, 100, Affinity.NONE, TargetChoice.ALL_PARTY));
        }
    }
}
