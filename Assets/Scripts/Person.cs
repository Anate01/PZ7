using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Person : MonoBehaviour
{
    private string _name = "Tom";
    private int health = 78;

    public string Name
    {
        get
        {
            return _name;
        }
        private set
        {
            _name = value; 
        }
    }

    public int Health
    {
        get
        {
            return health;
        }

        set
        {
            if (value < 0 || value > 100) Debug.Log("value is out of range!");
            else health = value; 
        }
    }

    public virtual void ShowStat()   /////////// PZ 7_3
    {
        Debug.Log("******** Stat: " + _name);
    }

    public abstract void TakeDamage (int damageValue);
    
}
