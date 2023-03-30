﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Project
{
    public class Character : IComparable<Character>
    {
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
        List<Effect> effects;
        public Character(string name, int health, int mana, int strength, int magic, int dexterity, int agility, int luck)
        {
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
            effects = new List<Effect>();
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

        public int CompareTo(Character other)
        {
            if(agility < other.Agility)
            {
                return -1;
            }
            if(agility > other.Agility)
            {
                return 1;
            }
            return 0;
        }
        public void AddEffect(Effect e)
        {
            effects.Add(e);
        }
        public bool CheckEffect(Effect e)
        {
            return effects.Contains(e);
        }
        public override string ToString()
        {
            return Name;
        }
        public AffinityRelation CheckAffinityRelation(Affinity aff)
        {
            return affinities[BattleProperties.AffinityToInt(aff)];
        }
    }
}