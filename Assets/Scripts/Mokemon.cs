using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mokemon
{
    // public int mokeNumber;
    private MokeDex.MokeDexInfo mokeDexInfo;
    public string mokeName;
    public mokeTypes.mokeType type;
    public int baseHP, baseAttack, baseDefense, baseSpAtk, baseSpDef, baseSpeed;
    public int hp, attack, defense, spAtk, spDef, speed;


    public void Init(int mokeNumber)
    {
        mokeDexInfo =  MokeDex.MokeDexDict.GetValueOrDefault(mokeNumber);
        mokeName = mokeDexInfo.Name;
        type = mokeDexInfo.Type;

        baseHP = mokeDexInfo.Stats.HP;
        int baseAttack = mokeDexInfo.Stats.Attack;
        int baseDefense = mokeDexInfo.Stats.Defense;
        int baseSpAtk = mokeDexInfo.Stats.SpAtk;
        int baseSpDef = mokeDexInfo.Stats.SpDef;
        int baseSpeed = mokeDexInfo.Stats.Speed;

        hp = baseHP;
        attack = baseAttack;
        defense = baseDefense;
        spAtk = baseSpAtk;
        spDef = baseSpDef;
        speed = baseSpeed;
    }

}
