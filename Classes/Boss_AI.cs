using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Project
{
    public static class Boss_AI
    {
        static Random random = new Random();
        public static List<double> skillPropabilities = new List<double>();
        public static List<Character> targets = new List<Character>();
        public static void SetTestPropabilities(int skillCount)
        {
            skillPropabilities.Clear();
            for (int i = 0; i < skillCount; i++)
            {
                skillPropabilities.Add(1.0/skillCount);
            }
        }
        public static int ChooseSkill()
        {
            double prop = random.NextDouble();
            int i = 0;
            foreach (double p in skillPropabilities)
            {
                prop -= p;
                if(prop<0.0)
                {
                    return i;
                }
                i++;
            }
            return i;
        }
        public static int ChooseEnemy()
        {
            return random.Next(0,BattleProperties.Party.Count);
        }
        public static int ChooseAlly()
        {
            return random.Next(0, BattleProperties.Troops.Count);
        }
    }
}
