using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mokemon
{
    // public int mokeNumber;
    private MokeDex.MokeDexInfo mokeDexInfo;
    public static SkillDex.SkillDexInfo skillDexInfo1;
    public static SkillDex.SkillDexInfo skillDexInfo2;
    public static SkillDex.SkillDexInfo skillDexInfo3;
    public static SkillDex.SkillDexInfo skillDexInfo4;

    public static List<string>skillNameList = new List<string>(SkillDex.SkillDexDict.Keys);
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

        for (int key_index=0; key_index<skillNameList.Count-4; key_index++)
        {
            int number = Mathf.RoundToInt(Random.Range(0,skillNameList.Count - 1));
            skillNameList.RemoveAt(number);
        }
        skillDexInfo1 = SkillDex.SkillDexDict.GetValueOrDefault(skillNameList[0]);
        skillDexInfo2 = SkillDex.SkillDexDict.GetValueOrDefault(skillNameList[1]);
        skillDexInfo3 = SkillDex.SkillDexDict.GetValueOrDefault(skillNameList[2]);
        skillDexInfo4 = SkillDex.SkillDexDict.GetValueOrDefault(skillNameList[3]);
        // for (int skill_index=1; skill_index<skillList.Count; skill_index++)
        // {
        //     string skillName = skillList[skill_index];
        //     skillDexInfo = SkillDex.SkillDexDict.GetValueOrDefault(skillName);
        // }
    }

}
