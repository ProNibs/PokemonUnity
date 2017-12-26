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
        HAVE_HELD_ITEM,
        WEATHER,
        STATUS,
        PHYSICAL,   // This refers to any move deemed Physical
        CONTACT,    // This refers to physical contact moves (not all Physical are contact)
        CRITICAL,
        FLINCH,
        TYPE,
        WHEN_HIT,


    };

    private string name;
    private BattleOccurance battleOccurance;
    private bool OutOfBattleEffect; // If true, has out of battle effects
    private Target target;
    private Target target2;     // Only used in certain cases
    private string description;
    

    // For single targetted Abilities
    public AbilityData(string name, BattleOccurance battleOccurance,bool OutofBattleEffect, 
        Target target1, string description)
    {
        this.name = name;
        this.battleOccurance = battleOccurance;
        this.OutOfBattleEffect = OutOfBattleEffect;
        this.target = target1;
        this.description = description;
    }

    public AbilityData(string name, BattleOccurance battleOccurance, bool OutofBattleEffect,
        Target target1, Target target2, string description)
    {
        this.name = name;
        this.battleOccurance = battleOccurance;
        this.OutOfBattleEffect = OutOfBattleEffect;
        this.target = target1;
        this.target2 = target2;
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
