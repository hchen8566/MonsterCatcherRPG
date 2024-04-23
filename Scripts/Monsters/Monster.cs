using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster
{
    MonsterBase basic;
    int level;

    public List<Move> Moves {  get; set; }
    public int currentHP {  get; set; }

    public Monster (MonsterBase mBasic, int mLevel)
    {
        basic = mBasic;
        level = mLevel;
        currentHP = basic.MaxHP;


        //Generating and giving moves to monster
        Moves = new List<Move> ();
        foreach (var move in basic.LearnableMoves)
        {
            if (move.Level <= level)
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
        get { return Mathf.FloorToInt((basic.PAttack * level) / 100f) + 10; }
    }

    public int MaxHP
    {
        get { return Mathf.FloorToInt((basic.MaxHP * level) / 100f) + 25; }
    }
    public int PDefense
    {
        get { return Mathf.FloorToInt((basic.PDefense * level) / 100f) + 10; }
    }
    public int RAttack
    {
        get { return Mathf.FloorToInt((basic.RAttack * level) / 100f) + 10; }
    }
    public int RDefense
    {
        get { return Mathf.FloorToInt((basic.RDefense * level) / 100f) + 10; }
    }
    public int Speed
    {
        get { return Mathf.FloorToInt((basic.Speed * level) / 100f) + 10; }
    }

}
