using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class Score : MonoBehaviour
{

    //Totalscore addscore = gameObject.AddComponent<Totalscore>();

    //Totalscore Addscore = new Totalscore();

    public int smallstarscore;
    public int largestarscore;
    public int cloudscore;
    void OnCollisionEnter(Collision other)
    {

        if (tag == "SmallStarTag")
        {
            //scorestorage(10);
            //totalscore += 10;
            smallstarscore += 10;

        }


        else if (tag == "LargeStarTag")
        {
            //scorestorage(20);
            //totalscore += 20;
            largestarscore += 10;

        }


        else if (tag == "SmallCloudTag" || tag == "LargeCloudTag")
        {
            //scorestorage(30);
            //totalscore += 30;
            cloudscore += 10;

        }
    }





}