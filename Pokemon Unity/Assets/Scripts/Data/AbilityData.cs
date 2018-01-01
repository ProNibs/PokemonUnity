﻿using System.Collections;
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
        MOVE_POWER_MULTIPLIERS,
        RESIST_STAT_CHANGES,
        RESIST_STATUS,
        RESISTANCE_TO_MOVES,
        IMMUNITIY_TO_MOVES,
        IMMUNITY_OR_RESIST_TO_OTHER,
        MODIFIES_EFFECTS,
        OTHER,
        FORM_CHANGING
    };

    // For Targets, Use following below:
    // Target.SELF      / This is located in MoveData.cs if need to edit Target

    public enum Conditions
    {   // High level explanation
        NONE,
        HAVE_HELD_ITEM,
        WEATHER,
        TYPE,
        ON_KO,      // If would KO from 100% to 0%
        PHYSICAL,   // This refers to any move deemed Physical
        CONTACT,    // This refers to physical contact moves (not all Physical are contact)
        CRITICAL,
        Burn,       // This status occurs on holder of the ability
        Freeze,
        Paralyze,
        Poison,
        Sleep,
        Toxic,
        Flinch,
        ANY_STATUS, 
        HAS_EFFECT,     // Move has any added effects whatsoever.
        WHEN_HIT,
        HP_THRESHOLD,
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
        EVA_MODIFY, //Evade,
        DMG_BOOST,  // Damage boost
        Burn,
        Freeze,
        Paralyze,
        Poison,
        Sleep,
        Toxic,
        Flinch,
        CHANGE_ABILITY,
        CHANGE_ITEM, 
        NEGATE_DAMAGE,
    };


    private string name;
    private BattleOccurance battleOccurance;
    private bool OutOfBattleEffect; // If true, has out of battle effects
    private Target target;
    private Target target2;     // Only used when the target reqires another target's threshold
    private Conditions condition;
    private string conditionText;
    private Action action;
    private float actionNumber;     // Could be percentage chance for effect, could be threshold
                                    // Could indicate what to do for specific cases
    private string description;


    // For single targeted Abilities
    public AbilityData(string name, BattleOccurance battleOccurance, bool OutOfBattleEffect,
        Target target1, Conditions condition,
         Action action, float actionNumber, string description)
    {
        this.name = name;
        this.battleOccurance = battleOccurance;
        this.OutOfBattleEffect = OutOfBattleEffect;
        this.target = target1;
        this.condition = condition;
        this.conditionText = "";
        this.action = action;
        this.actionNumber = actionNumber;
        this.description = description;
    }

    public AbilityData(string name, BattleOccurance battleOccurance, bool OutOfBattleEffect,
        Target target1, Conditions condition, string conditionText,
         Action action, float actionNumber, string description)
    {
        this.name = name;
        this.battleOccurance = battleOccurance;
        this.OutOfBattleEffect = OutOfBattleEffect;
        this.target = target1;
        this.condition = condition;
        this.conditionText = conditionText;
        this.action = action;
        this.actionNumber = actionNumber;
        this.description = description;
    }

    // For abilities that depend on enemy pokemon condition
    public AbilityData(string name, BattleOccurance battleOccurance, bool OutOfBattleEffect,
        Target target1, Target target2, Conditions condition, string conditionText, 
        Action action, float actionNumber, string description)
    {
        this.name = name;
        this.battleOccurance = battleOccurance;
        this.OutOfBattleEffect = OutOfBattleEffect;
        this.target = target1;
        this.target2 = target2;
        this.condition = condition;
        this.conditionText = conditionText;
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

    public Target getTarget2()
    {
        return target2;
    }

    public Conditions getCondition()
    {
        return condition;
    }

    public Action getAction()
    {
        return action;
    }

    public float getActionNumber()
    {
        return actionNumber;
    }

    public string getDescription()
    {
        return description;
    }

}
