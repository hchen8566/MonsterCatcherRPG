using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster
{
    public MonsterBase Basic { get; set; }
    public int Level { get; set;}

    public List<Move> Moves {  get; set; }
    public int currentHP {  get; set; }

    public Monster (MonsterBase mBasic, int mLevel)
    {
        Basic = mBasic;
        Level = mLevel;
        currentHP = MaxHP;


        //Generating and giving moves to monster
        Moves = new List<Move> ();
        foreach (var move in Basic.LearnableMoves)
        {
            if (move.Level <= Level)
            {
                Moves.Add(new Move(move.basic));
            }
            if (Moves.Count >= 4)
            {
                break;
            }
        }
    }

    public int PAttack
    {
        get { return Mathf.FloorToInt((Basic.PAttack * Level) / 100f) + 10; }
    }

    public int MaxHP
    {
        get { return Mathf.FloorToInt((Basic.MaxHP * Level) / 100f) + 25; }
    }
    public int PDefense
    {
        get { return Mathf.FloorToInt((Basic.PDefense * Level) / 100f) + 10; }
    }
    public int RAttack
    {
        get { return Mathf.FloorToInt((Basic.RAttack * Level) / 100f) + 10; }
    }
    public int RDefense
    {
        get { return Mathf.FloorToInt((Basic.RDefense * Level) / 100f) + 10; }
    }
    public int Speed
    {
        get { return Mathf.FloorToInt((Basic.Speed * Level) / 100f) + 10; }
    }

}
