using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Totalscore3 : MonoBehaviour
{
    public int totalscore;
    public int smallstarscore;
    public int largestarscore;
    public int cloudscore;
    private GameObject TotalScoreText;

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
            largestarscore += 20;

        }


        else if (tag == "SmallCloudTag" || tag == "LargeCloudTag")
        {
            //scorestorage(30);
            //totalscore += 30;
            cloudscore += 30;

        }
        this.totalscore = this.smallstarscore + this.largestarscore + this.cloudscore;
    }



    // Start is called before the first frame update
    void Start()
    {

        this.TotalScoreText = GameObject.Find("ScoreText");
        
        
    }

    // Update is called once per frame
    void Update()
    {

        if (this.totalscore > 0)
        {
            this.TotalScoreText.GetComponent<Text>().text = ("Score=" + this.totalscore);
        }

    }
}

