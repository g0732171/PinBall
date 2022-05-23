using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frippertap4 : MonoBehaviour
{

    //HingeJointコンポーネントを入れる
    private HingeJoint myHingeJoint;

    //初期の傾き
    private float defaultAngle = 20;
    //弾いた時の傾き
    private float flickAngle = -20;

    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }


    // Start is called before the first frame update
    void Start()
    {
        //HingeJointコンポーネント取得
        this.myHingeJoint = GetComponent<HingeJoint>();

        //フリッパーの傾きを設定
        SetAngle(this.defaultAngle);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            //Touch touch = Input.GetTouch(0);
            // Touch touch2 = Input.GetTouch(1);
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                if (Input.GetTouch(0).position.x < 540)
                {

                    if (tag == "leftfrippertag")
                    { SetAngle(this.flickAngle); }

                }
                else if (Input.GetTouch(0).position.x >= 540)
                {
                    if (tag == "rightfrippertag")
                    { SetAngle(this.flickAngle); }

                }

            }


            if (Input.GetTouch(0).phase == TouchPhase.Began && Input.GetTouch(1).phase == TouchPhase.Began)
            {
                if (Input.GetTouch(0).position.x < 540 && Input.GetTouch(1).position.x >= 540)
                {

                    if (tag == "leftfrippertag" || tag == "rightfrippertag")
                    { SetAngle(this.flickAngle); }

                }
                else if (Input.GetTouch(0).position.x >= 540 && Input.GetTouch(1).position.x < 540)
                {
                    if (tag == "leftfrippertag" || tag == "rightfrippertag")
                    { SetAngle(this.flickAngle); }

                }

            }




            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                if (Input.GetTouch(0).position.x < 540)
                {

                    if (tag == "leftfrippertag")
                    { SetAngle(this.defaultAngle); }


                }
                if (Input.GetTouch(0).position.x >= 540)
                {
                    if (tag == "rightfrippertag")
                    { SetAngle(this.defaultAngle); }


                }
            }

            if (Input.GetTouch(0).phase == TouchPhase.Ended && Input.GetTouch(1).phase == TouchPhase.Ended)
            {
                if (Input.GetTouch(0).position.x < 540 && Input.GetTouch(1).position.x >= 540)
                {

                    if (tag == "leftfrippertag" || tag == "rightfrippertag")
                    { SetAngle(this.defaultAngle); }

                }
                else if (Input.GetTouch(0).position.x >= 540 && Input.GetTouch(1).position.x < 540)
                {
                    if (tag == "leftfrippertag" || tag == "rightfrippertag")
                    { SetAngle(this.defaultAngle); }

                }

            }

        }




    }
}
