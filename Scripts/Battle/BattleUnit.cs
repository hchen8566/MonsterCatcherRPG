using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BattleUnit : MonoBehaviour
{
    [SerializeField] MonsterBase basic;
    [SerializeField] int level;
    [SerializeField] bool isPlayerMonster;

    public Monster monster { get; set; }
    public void Setup()
    {
        monster = new Monster(basic, level);

        if (isPlayerMonster)
        {
            GetComponent<Image>().sprite = monster.Basic.BackSprite;
        }
        else
        {
            GetComponent<Image>().sprite = monster.Basic.FrontSprite;
        }
    }
}
