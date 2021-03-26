using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCHUD2 : MonoBehaviour
{
    public ButtonHealthScript buttons;

    public int health = 5;
    public void Damage()
    {
        health--;
        MinusOneHealth();

    }

    public void MinusOneHealth()
    {
        buttons.buttonNum = health;
    }


}
