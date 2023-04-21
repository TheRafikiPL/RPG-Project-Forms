using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Project
{
    public enum CostType
    {
        HP,
        MP,
        None
    }
    public enum AffinityRelation
    {
        WEAK,
        NEUTRAL,
        STRONG,
        NULL,
        REPEL,
        ABSORB
    }
    public enum Affinity
    {
        NONE,
        PHYSICAL,
        FIRE,
        ICE,
        WIND,
        ELECTRICITY,
        LIGHT,
        DARKNESS,
        ALMIGHTY
    }
    public enum Effect
    {
        KNOCKDOWN,
        GUARD,
        DMG_BUFF,
        DEF_BUFF,
        DMG_DEBUFF,
        DEF_DEBUFF
    }
    public enum TargetChoice
    {
        SELF,
        ONE_PARTY,
        ALL_PARTY,
        ONE_ENEMY,
        ALL_ENEMY
    }
}
