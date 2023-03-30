using RPG_Project.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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
        public Skill(string name, string description, int costValue, CostType costType, int power, Affinity dmgType, TargetChoice choice)
        {
            this.name = name;
            this.description = description;
            this.costValue = costValue;
            this.costType = costType;
            this.power = power;
            this.dmgType = dmgType;
            this.choice = choice; 
        }

        public int CalculateDamage(Character attacker, Character defender)
        {
            int damage = 5;
            if(dmgType == Affinity.PHYSICAL)
            {
                damage *= (int)Math.Sqrt(attacker.Strength / defender.Dexterity * power);
            }
            else
            {
                damage *= (int)Math.Sqrt(attacker.Magic / defender.Dexterity * power);
            }
            if(attacker.CheckEffect(Effect.DMG_BUFF))
            {
                damage =(int)(damage * 1.25);
            }
            if (attacker.CheckEffect(Effect.DMG_DEBUFF))
            {
                damage = (int)(damage * 0.75);
            }
            if (defender.CheckEffect(Effect.DEF_BUFF))
            {
                damage = (int)(damage * 0.75);
            }
            if (defender.CheckEffect(Effect.DEF_DEBUFF))
            {
                damage = (int)(damage * 1.25);
            }
            return damage;
        }
        public override string ToString()
        {
            return $"{name}\t{costValue} {costType}";
        }
        public string Name { get { return name; } }
        public string CostString { get { return $"{costValue} {costType}"; } }
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
        public int CostValue
        {
            get 
            { 
                return costValue;
            }
        }
    }
}