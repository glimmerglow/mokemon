using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillDex : MonoBehaviour
{
    // public enum 
    private class SkillEffect
    {
        public string Target { get; set;}
        public int Damage { get; set;}
        public int Heal { get; set;}
        public int Accuracy { get; set;}
        public int Priority { get; set;}
        public int Speed { get; set;}

    }
    private class SkillDexInfo
    {
        public string Name { get; set;}
        public string Type { get; set;}
        public List<SkillEffect> Effects { get; set;}
    }
    Dictionary<int, SkillDexInfo> MokeDexDict = new Dictionary<int, SkillDexInfo>
    {
        {
            025, new SkillDexInfo { Name = "Quick Attack", Type = "Normal", Effects = new List<SkillEffect>(){new SkillEffect{Target = "Enemy", Damage = 40, Accuracy = 100, Priority = 1}}}
        }
    };
}
