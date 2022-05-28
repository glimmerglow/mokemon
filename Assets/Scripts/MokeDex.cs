using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MokeDex : MonoBehaviour
{
    private class MokeStats
    {
        public int HP { get; set;}
        public int Attack { get; set;}
        public int Defense { get; set;}
        public int SpAtk { get; set;}
        public int SpDef { get; set;}
        public int Speed { get; set;}

    }
    private class MokeDexInfo
    {
        public string Name { get; set;}
        public string Type { get; set;}
        public MokeStats Stats { get; set;}
    }
    Dictionary<int, MokeDexInfo> MokeDexDict = new Dictionary<int, MokeDexInfo>
    {
        {
            025, new MokeDexInfo { Name = "Pikachu", Type = "Electric", new MokeStats {HP = 35, Attack = 55, Defense = 40, SpAtk = 50, SpDef = 50, Speed = 90}}
        }
    };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
