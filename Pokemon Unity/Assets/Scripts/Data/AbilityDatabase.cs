using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityDatabase
{
    private static AbilityData[] ability = new AbilityData[]
    {
        new AbilityData("Null", AbilityData.BattleOccurance.OTHER, false, Target.SELF,
            AbilityData.Action.ATK_MODIFY, 0.0f,"A very false Description"),
        new AbilityData("Intimidate", AbilityData.BattleOccurance.ON_ENTRY, false, Target.ALLOPPONENT,
            AbilityData.Action.ATK_MODIFY, -1.0f, "RAWR, I INTIMIDATE YOU!"),
        new AbilityData("Synchronize", AbilityData.BattleOccurance.MOVE_HITTING, false, Target.SELF,
            AbilityData.Action.ATK_MODIFY, 0.0f,"A description of Synchronize"),
        new AbilityData("String2", AbilityData.BattleOccurance.MOVE_HITTING, true, Target.ALL,
           AbilityData.Action.ATK_MODIFY, 0.0f, "A false Description")
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

	
