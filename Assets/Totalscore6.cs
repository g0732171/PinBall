using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Totalscore6 : MonoBehaviour
{
    public int totalscore;
    public int smallstarscore;
    public int largestarscore;
    public int cloudscore;
    private GameObject TotalScoreText;


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag")
        {

            smallstarscore += 10;

        }
        

        else if (other.gameObject.tag == "LargeStarTag") 
        {

            largestarscore += 20;

        }


        else if (other.gameObject.tag == "SmallCloudTag" || other.gameObject.tag == "LargeCloudTag")
        {

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

        if (this.totalscore >= 0)
        {

            this.TotalScoreText.GetComponent<Text>().text = ("Score=" + this.totalscore);
        }

    }
}