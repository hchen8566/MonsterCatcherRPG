using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Move", menuName = "Move/Create New Move")]
public class MoveBase : ScriptableObject
{
    [SerializeField] new string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] MonsterType type;

    [SerializeField] int maxHP;
    [SerializeField] int pAttack;
    [SerializeField] int pDefense;
    [SerializeField] int rAttack;
    [SerializeField] int rDefense;
    [SerializeField] int speed;

    [SerializeField] int accuracy;
    [SerializeField] int pp;
    [SerializeField] int power;

    
    //Exposer Functions
    public string Name
    {
        get { return name; }
    }

    public string Description
    {
        get { return description; }
    }
    public MonsterType Type
    {
        get { return type; }
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
    public int Power
    {
        get { return power; }
    }
    public int Accuracy
    {
        get { return Accuracy; }
    }
    public int PP
    {
        get { return pp; }
    }
}

