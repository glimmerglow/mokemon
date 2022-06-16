using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillDex
{
    
    public enum Target{Enemy, Player};
    public enum SkillType {Normal, Electric, Fire, Water}
    public class SkillEffect
    {
        public Target Target { get; set;}
        public int Damage { get; set;}
        public int Heal { get; set;}
        public int Accuracy { get; set;}
        public int Priority { get; set;}
        public int Speed { get; set;}

    };
    public class SkillDexInfo
    {
        public string Name { get; set;}
        public mokeTypes.mokeType Type { get; set;}
        public List<SkillEffect> Effects { get; set;}
    };
    public static Dictionary<string, SkillDexInfo> SkillDexDict = new Dictionary<string, SkillDexInfo>
    {
        {
            "Quick Attack", new SkillDexInfo { Name = "Quick Attack", Type = mokeTypes.mokeType.Normal, Effects = new List<SkillEffect>(){new SkillEffect{Target = Target.Enemy, Damage = 40, Accuracy = 100, Priority = 1}}}
        },
        {
            "Charm", new SkillDexInfo { Name = "Charm", Type = mokeTypes.mokeType.Normal, Effects = new List<SkillEffect>(){new SkillEffect{Target = Target.Enemy, Damage = 40, Accuracy = 100, Priority = 1}}}
        },
        {
            "Growl", new SkillDexInfo { Name = "Growl", Type = mokeTypes.mokeType.Normal, Effects = new List<SkillEffect>(){new SkillEffect{Target = Target.Enemy, Damage = 40, Accuracy = 100, Priority = 1}}}
        },
        {
            "Nasty Plot", new SkillDexInfo { Name = "Nasty Plot", Type = mokeTypes.mokeType.Normal, Effects = new List<SkillEffect>(){new SkillEffect{Target = Target.Enemy, Damage = 40, Accuracy = 100, Priority = 1}}}
        },
        {
            "Nuzzle", new SkillDexInfo { Name = "Nuzzle", Type = mokeTypes.mokeType.Normal, Effects = new List<SkillEffect>(){new SkillEffect{Target = Target.Enemy, Damage = 40, Accuracy = 100, Priority = 1}}}
        },
        {
            "Play Nice", new SkillDexInfo { Name = "Play Nice", Type = mokeTypes.mokeType.Normal, Effects = new List<SkillEffect>(){new SkillEffect{Target = Target.Enemy, Damage = 40, Accuracy = 100, Priority = 1}}}
        },
    };
}
