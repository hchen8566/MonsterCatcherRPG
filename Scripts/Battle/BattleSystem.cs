using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    [SerializeField] BattleUnit playerMonster;
    [SerializeField] BattleHUD playerHUD;
    [SerializeField] BattleUnit enemyMonster;
    [SerializeField] BattleHUD enemyHUD;
    [SerializeField] BattleDialogBox dialogBox;

    private void Start()
    {
        SetupBattle();
    }

    public void SetupBattle()
    {
        playerMonster.Setup();
        playerHUD.SetData(playerMonster.monster);
        enemyMonster.Setup();
        enemyHUD.SetData(enemyMonster.monster);

        StartCoroutine(dialogBox.TypeDialog($"An untamed {enemyMonster.monster.Basic.Name} has appeared!"));
    }
}
