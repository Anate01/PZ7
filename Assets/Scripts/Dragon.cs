using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : Person
{
    public override void TakeDamage(int damageValue)   /////////// PZ 7_4
    {
        Debug.Log("I, the mighty dragon, have lost: " + damageValue + " hit points from a hunter's shot.");
    }
}
