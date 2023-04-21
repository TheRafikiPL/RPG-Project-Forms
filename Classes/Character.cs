using System;
using System.Collections.Generic;
using System.Drawing;

namespace RPG_Project
{
    public class Character
    {
        Guid id;
        string name;
        int health;
        int currentHealth;
        int mana;
        int currentMana;
        int strength;
        int magic;
        int dexterity;
        int agility;
        int luck;
        Image sprite;
        AffinityRelation[] affinities;
        List<int> skills;
        Dictionary<Effect, int> effects;
        public Character(string name, int health, int mana, int strength, int magic, int dexterity, int agility, int luck)
        {
            id = new Guid();
            this.name = name;
            this.health = health;
            this.currentHealth = health;
            this.mana = mana;
            this.currentMana = mana;
            this.strength = strength;
            this.magic = magic;
            this.dexterity = dexterity;
            this.agility = agility;
            this.luck = luck;
            this.affinities = new AffinityRelation[8];
            for (int i = 0; i < 8;i++)
            {
                affinities[i] = AffinityRelation.NEUTRAL;
            }
            skills = new List<int>();
            skills.Add(0);
            skills.Add(1);
            effects = new Dictionary<Effect, int>();
        }
        public List<int> Skills
        {
            get { return skills; }
        }
        public string Name
        {
            get { return name; }
        }
        public int Health
        {
            get { return health; }
        }
        public int CurrentHealth
        {
            get { return currentHealth; }
        }
        public int Mana
        {
            get { return mana; }
        }
        public int CurrentMana
        {
            get { return currentMana; }
        }
        public int Strength
        {
            get { return strength; }
        }
        public int Magic
        {
            get { return magic; }
        }
        public int Dexterity
        {
            get { return dexterity; }
        }
        public int Agility
        {
            get { return agility; }
        }
        public int Luck
        {
            get { return luck; }
        }
        public void AddSkillByIndex(int i)
        {
            skills.Add(i+2);
        }
        public void ChangeAffinityRelation(int i, AffinityRelation aff)
        {
            affinities[i] = aff;
        }
        public void SetImage(Image i)
        {
            sprite = i;
        }
        public Image GetImage()
        {
            return sprite;
        }
        public void AddEffect(Effect e, int duration)
        {
            effects.Add(e,duration);
        }
        public bool CheckEffect(Effect e)
        {
            return effects.ContainsKey(e);
        }
        public string EffectsToString()
        {
            string tmp = "";
            foreach (KeyValuePair<Effect, int> val in effects)
            {
                tmp += $"{val.Key} - {val.Value}, ";
            }
            return tmp;
        }
        public override string ToString()
        {
            return Name;
        }
        public AffinityRelation CheckAffinityRelation(Affinity aff)
        {
            return affinities[BattleProperties.AffinityToInt(aff)];
        }
        public static bool operator <(Character a, Character b)
        {
            return a.agility < b.agility;
        }
        public static bool operator >(Character a, Character b)
        {
            return a.agility > b.agility;
        }
        public static bool operator <=(Character a, Character b)
        {
            return a.agility <= b.agility;
        }
        public static bool operator >=(Character a, Character b)
        {
            return a.agility >= b.agility;
        }
        public static bool operator ==(Character a, Character b)
        {
            return a.id == b.id;
        }
        public static bool operator !=(Character a, Character b)
        {
            return a.id != b.id;
        }
        public void AddHP(int hp)
        {
            currentHealth += hp;
            if (currentHealth > health)
            {
                currentHealth = health;
            }
        }
        public void SubHP(int hp)
        {
            currentHealth -= hp;
            if (currentHealth < 0)
            {
                currentHealth = 0;
                AddEffect(Effect.KNOCKDOWN,int.MaxValue);
            }
        }
        public void SubMana(int mp)
        {
            currentMana -= mp;
            if (currentMana < 0)
            {
                currentMana = 0;
            }
        }
        public void AddEffect(KeyValuePair<Effect, int> tmp)
        {
            if(!effects.ContainsKey(tmp.Key))
            {
                effects.Add(tmp.Key, tmp.Value);
            }
            else if(effects[tmp.Key] < tmp.Value)
            {
                effects[tmp.Key] = tmp.Value;
            }
        }
        public void DecreseEffectTurns(Effect e, int val=1)
        {
            effects[e] -= val;
            if(effects[e] <= 0)
            {
                effects.Remove(e);
            }
        }
        public void ClearEffect(Effect e)
        {
            if(effects.ContainsKey(e))
            {
                effects.Remove(e);
            }
        }
        public void UpdateEffects()
        {
            List<Effect> toDelete = new List<Effect>();
            List<Effect> toDeinc = new List<Effect>();
            foreach (KeyValuePair<Effect, int> kvp in effects)
            {
                toDeinc.Add(kvp.Key);
                if(kvp.Value <= 0)
                {
                    toDelete.Add(kvp.Key);
                }
            }
            for (int i = 0; i < toDeinc.Count; i++)
            {
                effects[toDeinc[i]]--;
            }
            for (int i = 0; i < toDelete.Count; i++)
            {
                effects.Remove(toDelete[i]);
            }
        }
    }
}
