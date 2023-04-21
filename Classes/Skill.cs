using RPG_Project.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace RPG_Project
{
    public class Skill
    {
        string name;
        string description;
        int costValue;
        CostType costType;
        int power;
        Affinity dmgType;
        TargetChoice choice;
        Dictionary<Effect,int> skillEffects;
        public Skill(string name, string description, int costValue, CostType costType, int power, Affinity dmgType, TargetChoice choice, params KeyValuePair<Effect, int>[] effects)
        {
            this.name = name;
            this.description = description;
            this.costValue = costValue;
            this.costType = costType;
            this.power = power;
            this.dmgType = dmgType;
            this.choice = choice;
            this.skillEffects = new Dictionary<Effect,int>();
            foreach (KeyValuePair<Effect,int> effect in effects)
            {
                skillEffects.Add(effect.Key, effect.Value);
            }
        }

        public string Name { get { return name; } }
        public string CostString 
        { 
            get 
            {
                if(costType == CostType.HP)
                {
                    return $"{costValue}% {costType}";
                }
                return $"{costValue} {costType}"; 
            } 
        }
        public Image AffinityImage 
        { 
            get
            {
                switch(dmgType)
                {
                    case Affinity.PHYSICAL: 
                        return Resources.physicalPlaceholder;
                    case Affinity.FIRE:
                        return Resources.firePlaceholder;
                    case Affinity.ICE:
                        return Resources.icePlaceholder;
                    case Affinity.ELECTRICITY:
                        return Resources.elecPlaceholder;
                    case Affinity.WIND:
                        return Resources.windPlaceholder;
                    case Affinity.LIGHT:
                        return Resources.lightPlaceholder;
                    case Affinity.DARKNESS:
                        return Resources.darkPlaceholder;
                    case Affinity.ALMIGHTY:
                        return Resources.almightyPlaceholder;
                    default:
                        return Resources.error_none;
                }
            }
        }
        public string Description
        {
            get { return description; }
        }
        public TargetChoice Choice
        {
            get { return choice; }
        }
        public CostType CostType
        {
            get { return costType; }
        }
        public Affinity DmgType
        {
            get { return dmgType; }
        }
        public int CostValue
        {
            get { return costValue; }
        }
        public int Power
        {
            get { return power; }
        }
        public Dictionary<Effect,int> SkillEffects
        {
            get { return skillEffects; }
        }
        public bool CheckIfAvailable(Character c)
        {
            switch(costType)
            {
                case CostType.HP:
                    if(c.CurrentHealth<=Math.Ceiling(costValue/100.0*c.Health))
                    {
                        return false;
                    }
                    break;
                case CostType.MP:
                    if(c.CurrentMana<costValue)
                    {
                        return false;
                    }
                    break;
            }
            return true;
        }
        public int CalculateDamage(Character attacker, Character defender)
        {
            int damage = 5;
            if (dmgType == Affinity.PHYSICAL)
            {
                damage = (int)(damage * Math.Sqrt((double)attacker.Strength / defender.Dexterity * power));
            }
            else
            {
                damage = (int)(damage * Math.Sqrt((double)attacker.Magic / defender.Dexterity * power));
            }
            if(defender.CheckEffect(Effect.GUARD))
            {
                damage = (int)(damage * 0.5);
                defender.DecreseEffectTurns(Effect.GUARD);
            }
            return damage;
        }
        public int CalculateHealing(Character caster, Character receiver)
        {
            int heal = receiver.Health;
            heal = (int)(heal * (power / 100.0f));
            return heal;
        }
        public void CalculateEffect(Character caster, Character receiver)
        {
            foreach(KeyValuePair<Effect, int> val in skillEffects)
            {
                receiver.AddEffect(val);
            }
        }
    }
}