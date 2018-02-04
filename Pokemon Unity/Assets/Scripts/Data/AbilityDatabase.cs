using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityDatabase
{
    private static AbilityData[] ability = new AbilityData[]
    {
        new AbilityData("Null", AbilityData.BattleOccurance.OTHER, false, Target.SELF,
            AbilityData.Conditions.NONE, AbilityData.Action.ATK_MODIFY, 0.0f,
            "A very false Description"),
        new AbilityData("Chlorophyll", AbilityData.BattleOccurance.STAT_MULTIPLIER, false, Target.SELF,
            AbilityData.Conditions.WEATHER, "SUN", AbilityData.Action.SPE_MODIFY, +2.0f,
            "ABoosts the Pokemon's Speed in sunshine."),
        new AbilityData("Immunity", AbilityData.BattleOccurance.RESIST_STATUS, true, Target.SELF,
            AbilityData.Conditions.NONE, AbilityData.Action.Poison, 1f,
            "The Pokemon is protected from being poisoned."),
        new AbilityData("Inner Focus", AbilityData.BattleOccurance.RESIST_STATUS, false, Target.SELF,
            AbilityData.Conditions.NONE, AbilityData.Action.Flinch, 1f,
            "The Pokemon is protected from flinching."),
        new AbilityData("Intimidate", AbilityData.BattleOccurance.ON_ENTRY, false, Target.ALLOPPONENT,
            AbilityData.Conditions.NONE, AbilityData.Action.ATK_MODIFY, -1.0f, 
            "RAWR, I INTIMIDATE YOU!"),
        new AbilityData("Keen Eye", AbilityData.BattleOccurance.RESIST_STAT_CHANGES, true, Target.SELF,
            AbilityData.Conditions.NONE, AbilityData.Action.ACC_MODIFY, 1f,
            "Prevents other Pokemon from lowering accuracy."),
        new AbilityData("Levitate", AbilityData.BattleOccurance.IMMUNITIY_TO_MOVES, false, Target.SELF,
            AbilityData.Conditions.TYPE, "GROUND", AbilityData.Action.NEGATE_DAMAGE, 0f,
            "Gives immunity to Ground type moves."),
        new AbilityData("Pressure", AbilityData.BattleOccurance.OTHER, true, Target.ALLOPPONENT,
            AbilityData.Conditions.NONE, AbilityData.Action.SPECIAL, 2f,
            "The Pokemon raises the foe's PP usage."),
        new AbilityData("Sheer Force", AbilityData.BattleOccurance.MOVE_POWER_MULTIPLIERS, false, Target.SELF,
            AbilityData.Conditions.HAS_EFFECT, "NEGATE EFFECT", AbilityData.Action.DMG_BOOST, 0.3f,
            "Removes added effects to increase move damage."),
        new AbilityData("Sturdy", AbilityData.BattleOccurance.MOVE_HITTING, false, Target.SELF,
            AbilityData.Conditions.ON_KO, AbilityData.Action.HP_MODIFY, 1f,
            "It cannot be knocked out with one hit."),
        new AbilityData("Swift Swim", AbilityData.BattleOccurance.STAT_MULTIPLIER, false, Target.SELF,
            AbilityData.Conditions.WEATHER, "RAIN", AbilityData.Action.SPE_MODIFY, +2.0f,
            "Boosts the Pokemon's Speed in Rain."),
        new AbilityData("Synchronize", AbilityData.BattleOccurance.MOVE_HITTING, false, Target.SELF,
            AbilityData.Conditions.ANY_STATUS, "OBTAIN", AbilityData.Action.SPECIAL, 0f,
            "A description of Synchronize"),
    };


    // To make it easier to simply give a name and get Ability info
    public static AbilityData getAbility(string name)
    {
        for (int i=0; i < ability.Length; i++)
        {
            if (ability[i].getName() == name)
            {
                return ability[i];
            }
        }
        return ability[0];    // Failed to find a matching ability
    }

    public static string getAbilityDescription(string name)
    {
        return getAbility(name).getDescription();
    }


}

	
