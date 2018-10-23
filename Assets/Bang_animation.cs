using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bang_animation : MonoBehaviour {

    public int AnimationCounter;
    public int AnimationSecCounter;

//    public GameObject gameObjectRetryStage;
//    public GameObject gameobject2;
    //    RetryScript script;

    // Use this for initialization
    void Start () {
        AnimationCounter = 0;
        AnimationSecCounter = 0;
//        gameobject2.GetComponent<Retry>().ReturnAccess();
        //        gameObjectRetryStage = GameObject.Find("Retry");

        //        GlobalVariables.BombFlag = false;
    }

    // Update is called once per frame
    public void Update()
    {

        if (GlobalVariables.BombFlag == true)
        {
            if (AnimationSecCounter == 60)
            {
                if (AnimationCounter == 0)
                {
                    iTween.RotateTo(gameObject, iTween.Hash("z", 540f, "islocal", true));
                    iTween.ScaleTo(gameObject, iTween.Hash("x", 5, "y", 5, "delay", 0.5f));
                }
                if (AnimationCounter == 1)
                {
                    iTween.RotateTo(gameObject, iTween.Hash("z", 720f, "islocal", true));
                    //                iTween.RotateBy (gameObject, iTween.Hash("z", 180f, "islocal", true));
                    //                iTween.RotateTo(gameObject, iTween.Hash("z", 180f, "islocal", true));
                    iTween.ScaleTo(gameObject, iTween.Hash("x", 5, "y", 5, "delay", 1f));
                }
                if (AnimationCounter == 2)
                {
                    iTween.RotateTo(gameObject, iTween.Hash("z", 0f, "islocal", true));
                    iTween.ScaleTo(gameObject, iTween.Hash("x", 7.5, "y", 7.5, "delay", 2f));
                }
                if (AnimationCounter == 3)
                {
                    iTween.RotateTo(gameObject, iTween.Hash("z", 540f, "islocal", true));
                    iTween.ScaleTo(gameObject, iTween.Hash("x", 7.5, "y", 7.5, "delay", 2f));
                }
                if (AnimationCounter == 4)
                {
                    iTween.RotateTo(gameObject, iTween.Hash("z", 720f, "islocal", true));
                    iTween.ScaleTo(gameObject, iTween.Hash("x", 7.5, "y", 7.5, "delay", 2f));
                }
                if (AnimationCounter == 5)
                {
                    iTween.RotateTo(gameObject, iTween.Hash("z", 0f, "islocal", true));
                    iTween.ScaleTo(gameObject, iTween.Hash("x", 10, "y", 10, "delay", 2f));
                }
                if (AnimationCounter == 6)
                {
                    iTween.RotateTo(gameObject, iTween.Hash("z", 540f, "islocal", true));
                    iTween.ScaleTo(gameObject, iTween.Hash("x", 10, "y", 10, "delay", 2f));
                }
                if (AnimationCounter == 7)
                {
                    iTween.RotateTo(gameObject, iTween.Hash("z", 720f, "islocal", true));
                    iTween.ScaleTo(gameObject, iTween.Hash("x", 10, "y", 10, "delay", 2f));
                }
                if (AnimationCounter == 8)
                {
                    //                    iTween.RotateTo(gameObject, iTween.Hash("z", 540f, "islocal", true));
                    iTween.ScaleTo(gameObject, iTween.Hash("x", 10, "y", 10, "delay", 2f));
                }
                AnimationCounter = AnimationCounter + 1;
                           Debug.Log("AnimationCounter:" + AnimationCounter);
            }

            if (AnimationCounter >= 9)
            {
                 AnimationCounter = 9;
                ChangeSceen();
            }
            if (AnimationSecCounter >= 60)
            {
                 AnimationSecCounter = 0;
            }
            else
            {
                AnimationSecCounter = AnimationSecCounter + 1;
            }
        }

    }

    public void ChangeSceen()
    {
            GlobalVariables.RetryFlag = true;
        //            gameObjectRetryStage.GetComponent<Retry>().ClearStage();
//        Retry r1 = GetComponent<Retry>();
//        r1.ClearStage();
        /*
        Retry r1 = GetComponent<Retry>();
        r1.ClearStage();
        */
        //                    gameObjectRetryStage = GameObject.Find("Retry");
        //                    script = gameObjectRetryStage.GetComponent<RetryScript>();
        //                    gameObjectRetryStage.GetComponent<Retry>().Update();
        

    }

}
