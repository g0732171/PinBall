using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Totalscore2 : MonoBehaviour
{
    
    public int totalscore;
    private GameObject TotalScoreText;

    
    // Start is called before the first frame update
    void Start()
    {
        //smallstarscore = gameObject.AddComponent<Smallstarscore>();
        //smallstarscore = Instantiate(smallstarscore);
        Smallstarscore smallstarscore = gameObject.AddComponent<Smallstarscore>();
        this.totalscore = smallstarscore.smallstarscore;
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
