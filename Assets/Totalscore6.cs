using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Totalscore6 : MonoBehaviour
{
    int totalscore;
    private GameObject TotalScoreText;


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag")
        {
            totalscore += 10;
        }
        

        else if (other.gameObject.tag == "LargeStarTag") 
        {
            totalscore += 20;
        }


        else if (other.gameObject.tag == "SmallCloudTag" || other.gameObject.tag == "LargeCloudTag")
        {
            totalscore += 30;
        }
               
    }


    // Start is called before the first frame update
    void Start()
    {
        this.TotalScoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {

        if (this.totalscore >= 0)
        {
            this.TotalScoreText.GetComponent<Text>().text = ("Score=" + this.totalscore);
        }

    }
}