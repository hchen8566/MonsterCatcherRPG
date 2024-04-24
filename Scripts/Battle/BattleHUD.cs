using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHUD : MonoBehaviour
{
    [SerializeField] Text nameText;
    [SerializeField] Text levelText;
    [SerializeField] HPBar hpBar;

    public void SetData(Monster monster)
    {
        nameText.text = monster.Basic.Name;
        Debug.Log(monster.Basic.Name);
        levelText.text = "Level: " + monster.Level;
        hpBar.SetHP((float)monster.currentHP / monster.MaxHP);

    }
}
