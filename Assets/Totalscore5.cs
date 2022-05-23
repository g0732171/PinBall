using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Addscore : MonoBehaviour
{
   
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
    

  

       else if (tag == "SmallStarTag")


        {
            //scorestorage(10);
            //totalscore += 10;
            largestarscore += 10;

        }
    

   

        else if (tag == "SmallStarTag")


        {
            //scorestorage(10);
            //totalscore += 10;
            smallstarscore += 10;

        }
    }

}


public class Totalscore5 : MonoBehaviour
{
    private GameObject TotalScoreText;
    public int totalscore;

    // Start is called before the first frame update
    Addscore _addsco = new Addscore();
    
    void Start()
    {
        this.TotalScoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        this.totalscore = _addsco.cloudscore + _addsco.smallstarscore + _addsco.largestarscore;
        if (this.totalscore >= 0)
        { 

            this.TotalScoreText.GetComponent<Text>().text = ("Score=" + this.totalscore);
        }

    }
}
