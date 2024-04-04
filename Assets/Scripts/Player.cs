using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Person
{
    private int exp = 1;

    public int Exp
    {
        get
        {
            return exp;
        }
        private set
        {
            exp = value; 
        }
    }

    public override void ShowStat()   /////////// PZ 7_3
    {
        base.ShowStat();
        Debug.Log("******** Stat: " + exp);
    }

    public override void TakeDamage(int damageValue)   /////////// PZ 7_4
    {
        Debug.Log("My name is " + Name + " : After hitting with force: " + damageValue + " I have health: " + (Health - damageValue));
    }




}
