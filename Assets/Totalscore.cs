using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Totalscore : MonoBehaviour
{

    public int totalscore;
    //int addscore;
    private GameObject TotalCcoreText;
    // Use this for initialization
    /*
        public Totalscore()
        { }

        public void SetTotalscore(int totalscore)
        {
            this.totalscore = totalscore;
            //this.addscore = addscore;
        }



        public Totalscore(int totalscore)
        {
            this.totalscore = totalscore;
            this.addscore = addscore;
        }
       
    
    public void scorestorage(int addscore)
    {
        this.totalscore = this.totalscore + addscore;
    }
     */


    // public void _totsco(int totalscore)
    //{
    //totalscore = _sco.cloudscore + _sco.smallstarscore + _sco.largestarscore;
    //}

    public class Collisi
    {
        public int smallstarscore;
        public int largestarscore;
        public int cloudscore;
        private string tag;

        public void OnCollisionEnter(Collision other)
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

    void Start()
    {
        Collisi _sco = new Collisi();
        
        this.totalscore = _sco.cloudscore + _sco.smallstarscore + _sco.largestarscore;
        this.TotalCcoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {

        if (this.totalscore > 0)
        {
            this.TotalCcoreText.GetComponent<Text>().text = ("Score=" + this.totalscore);
        }

    }
}
