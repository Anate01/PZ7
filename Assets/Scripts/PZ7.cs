using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PZ7 : MonoBehaviour
{
    //private Person myPers = new Person();
    //private Player myPlayer = new Player();
    //[SerializeField] private Person myPers;
    [SerializeField] private Player myPlayer;

    void Start()
    {
        //////// 1
        
        //Debug.Log("My Person health " + myPers.Health);
        //myPers.Health = 30;
        //Debug.Log("Change my Person health to " + myPers.Health);
        //myPers.Health = 300;
        //myPers.Health = -300;
        //Debug.Log("My Person health still " + myPers.Health);

        //Debug.Log("My Person name " + myPers.Name);

        //////// 2
        Debug.Log("My Player health " + myPlayer.Health);
        Debug.Log("My Player exp " + myPlayer.Exp);

        //////// 3
        myPlayer.ShowStat();
    }


}
