using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityData
{
    // During battle, can only slot into one of these areas
    public enum BattleOccurance
    {
        ON_ENTRY,
        ON_EXIT,
        END_TURN,
        MOVE_HITTING,
        STAT_MULTIPLIER,
        RESIST_STAT_CHANGES,
        IMMUNITIY_TO_MOVES,
        IMMUNITY_TO_OTHER,
        MODIFIES_EFFECTS,
        OTHER,
        FORM_CHANGING
    };

    // For Targets, Use following below:
    // Target.SELF      / This is located in MoveData.cs if need to add Target

    public enum Conditions
    {   // High level explanation
        NONE,
        HAVE_HELD_ITEM,
        WEATHER,
        STATUS,     // Hold a current status
        PHYSICAL,   // This refers to any move deemed Physical
        CONTACT,    // This refers to physical contact moves (not all Physical are contact)
        CRITICAL,
        FLINCH,
        TYPE,
        WHEN_HIT,
        STAT_THRESHOLD,
    };

    public enum Action
    {
        NONE,
        SPECIAL,    // For those crazy ones
        HP_MODIFY,
        ATK_MODIFY,
        DEF_MODIFY,
        SPA_MODIFY,
        SPD_MODIFY,
        SPE_MODIFY,
        ACC_MODIFY, // Accuracy
        EVA_MODIFY, //Evade
        Burn,
        Freeze,
        Paralyze,
        Poison,
        Sleep,
        Toxic,
        Flinch,
        CHANGE_ABILITY,
        CHANGE_ITEM
    };


    private string name;
    private BattleOccurance battleOccurance;
    private bool OutOfBattleEffect; // If true, has out of battle effects
    private Target target;
    private Target target2;     // Only used when the target reqires another target's threshold
    private Action action;
    private float actionNumber;     // Could be percentage chance for effect, could be threshold
                        // Could indicate what to do for specific cases
    private string description;
    

    // For single targetted Abilities
    public AbilityData(string name, BattleOccurance battleOccurance,bool OutOfBattleEffect, 
        Target target1, Action action, float actionNumber, string description)
    {
        this.name = name;
        this.battleOccurance = battleOccurance;
        this.OutOfBattleEffect = OutOfBattleEffect;
        this.target = target1;
        this.action = action;
        this.actionNumber = actionNumber;
        this.description = description;
    }

    public AbilityData(string name, BattleOccurance battleOccurance, bool OutOfBattleEffect,
        Target target1, Target target2, Action action, float actionNumber, string description)
    {
        this.name = name;
        this.battleOccurance = battleOccurance;
        this.OutOfBattleEffect = OutOfBattleEffect;
        this.target = target1;
        this.target2 = target2;
        this.action = action;
        this.actionNumber = actionNumber;
        this.description = description;
    }

    public string getName()
    {
        return name;
    }

    public BattleOccurance getBattleOccurance()
    {
        return battleOccurance;
    }

    public bool hasOutOfBattleEffect()
    {
        return OutOfBattleEffect;
    }

    public Target getTarget()
    {
        return target;
    }

    public string getDescription()
    {
        return description;
    }

}
