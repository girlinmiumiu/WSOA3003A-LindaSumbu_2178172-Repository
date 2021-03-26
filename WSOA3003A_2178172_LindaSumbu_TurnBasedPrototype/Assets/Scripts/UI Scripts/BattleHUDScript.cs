using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHUDScript : MonoBehaviour
{
    public Text nameText;
    public Text levelText;
    public Slider enemySlider;
    public MCHUD2 mcHealth;
   public void SetHUD(UnitScript unit)
    {
        nameText.text = unit.unitName;
        levelText.text = "Lvl" + unit.unitName;
        enemySlider.maxValue = unit.maxHP;
        enemySlider.value = unit.currentHP;
        mcHealth.health = unit.maxHP;
        mcHealth.health = unit.currentHP;
    }

    public void SetHP(int hp)
    {
        enemySlider.value = hp;
        mcHealth.health = hp;
    }
}
