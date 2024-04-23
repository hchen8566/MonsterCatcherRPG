using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "Monster", menuName = "Monster/Create New Monster")]
public class MonsterBase : ScriptableObject
{
    [SerializeField] new string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] Sprite frontSprite;

    [SerializeField] Sprite backSprite;

    [SerializeField] MonsterType type1;
    [SerializeField] MonsterType type2;

    //Stats
    [SerializeField] int maxHP;
    [SerializeField] int pAttack;
    [SerializeField] int pDefense;
    [SerializeField] int rAttack;
    [SerializeField] int rDefense;
    [SerializeField] int speed;

    [SerializeField] List<LearnableMove> learnableMoves;

    //exposer functions
    public string Name
    {
        get { return name; }
    }
    public string Description
    {
        get { return description; }
    }
    public Sprite BackSprite
    {
        get { return backSprite; }
    }
    public Sprite FrontSprite
    {
        get { return frontSprite; }
    }
    public MonsterType Type1
    {
        get { return type1; }
    }
    public MonsterType Type2
    {
        get { return type2; }
    }
    public int MaxHP
    {
        get { return maxHP; }
    }
    public int PAttack
    {
        get { return pAttack; }
    }
    public int PDefense
    {
        get { return pDefense; }
    }
    public int RAttack
    {
        get { return rAttack; }
    }
    public int RDefense
    {
        get { return rDefense; }
    }
    public int Speed
    {
        get { return speed; }
    }
    public List<LearnableMove> LearnableMoves
    {
        get { return learnableMoves; }
    }
}
[System.Serializable] public class LearnableMove
{
    [SerializeField] MoveBase moveBase;
    [SerializeField] int level;

    public MoveBase basic
    {
        get { return moveBase; }
    } 

    public int Level
    {
        get { return level; }
    }
}

public enum MonsterType
{
    None,
    Normal,
    Rage,
    Goof,
    Idiot
}


