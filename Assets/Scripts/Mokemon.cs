using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mokemon : MonoBehaviour
{
    // public int mokeNumber;
    public MokeDex.MokeDexInfo mokeDexInfo;
    public string mokeName;
    public string type;

    public int baseHP;

    public int hp;
    public int attack;
    public int defense;
    public int spAtk;
    public int spDef;
    public int speed;

    void Awake()
    {
        // Init();
    }

    public void Init(int mokeNumber)
    {
        MokeDex.MokeDexInfo mokeDexInfo =  MokeDex.MokeDexDict.GetValueOrDefault(mokeNumber);
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
