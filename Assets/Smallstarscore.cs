using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smallstarscore: MonoBehaviour
{ 
    public int smallstarscore;
    void OnCollisionEnter(Collision other)
    {

        if (tag == "SmallStarTag")
        {
            //scorestorage(10);
            //totalscore += 10;
            smallstarscore += 10;

        }
    }
}