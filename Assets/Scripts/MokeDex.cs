using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MokeDex
{
    public class MokeStats
    {
        public int HP { get; set;}
        public int Attack { get; set;}
        public int Defense { get; set;}
        public int SpAtk { get; set;}
        public int SpDef { get; set;}
        public int Speed { get; set;}

    }
    public class MokeDexInfo
    {
        public string Name { get; set;}
        public mokeTypes.mokeType Type { get; set;}
        public MokeStats Stats { get; set;}
    }
    public static Dictionary<int, MokeDexInfo> MokeDexDict = new Dictionary<int, MokeDexInfo>
    {
        {
            025, new MokeDexInfo { Name = "Pikachu", Type = mokeTypes.mokeType.Electric, Stats = new MokeStats { HP = 35, Attack = 55, Defense = 40, SpAtk = 50, SpDef = 50, Speed = 90 } }
        },
        {
            150, new MokeDexInfo { Name = "Mewtwo", Type = mokeTypes.mokeType.Psychic, Stats = new MokeStats { HP = 106, Attack = 110, Defense = 90, SpAtk = 154, SpDef = 90, Speed = 130 } }
        },
    };
}
