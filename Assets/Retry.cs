using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Retry : MonoBehaviour {
//    public GameObject target2;
//    public float GameObjectHight;
//    public float GameObjectWight;
//    public GameObject GameScreen100;

 //   //    public GameObject MakeStageObj;
//    public GameObject gameObjectMakeStage2;

//    public GameObject Player;
    // Use this for initialization
    void Start () {
//        GlobalVariables.RtryFlag = false;

    }

    // Update is called once per frame
//    public void Update()
//    {
        public void ClearStage()
        {

            if (GlobalVariables.RetryFlag==true)
        {
        GlobalVariables.target1.SetActive(false);
        //                HussenController Ms = MakeStageObj.GetComponent<HussenController>();
        //                Ms.DeleteStage(t);
        string tag = gameObject.tag;
        GlobalVariables.StageWriteFlag = true;
        //            CreateStage(StageData2, 21, 57);
/*        GameObject[] cubes = GameObject.FindGameObjectsWithTag("ob_wall");
        foreach (GameObject cube in cubes)
        {
            // 消す！
            cube.SetActive(false);
        }
        GameObject[] cubes2 = GameObject.FindGameObjectsWithTag("goal");
        foreach (GameObject cube in cubes2)
        {
            // 消す！
            cube.SetActive(false);
        }
        GameObject[] cubes3 = GameObject.FindGameObjectsWithTag("Karasu");
        foreach (GameObject cube in cubes3)
        {
            // 消す！
            cube.SetActive(false);
        }
        GameObject[] cubes4 = GameObject.FindGameObjectsWithTag("Togetoge");
        foreach (GameObject cube in cubes4)
        {
            // 消す！
            cube.SetActive(false);
        }
        tag = "";
/*
        GameObjectWight = GameScreen100.GetComponent<SpriteRenderer>().bounds.size.x;
        GameObjectHight = GameScreen100.GetComponent<SpriteRenderer>().bounds.size.y;


        GlobalVariables.target1 = GameObject.Find("huusen");
        GlobalVariables.target1.transform.position = new Vector2(GameObjectHight, GameObjectWight);
        //                GlobalVariables.target1 = Instantiate(Player);
        //        target1 = GameObject.Find("huusen_animator");
        GlobalVariables.HusenPosition = GlobalVariables.target1.transform.position;
        gameObjectMakeStage.GetComponent<MakeStage>().Update();
    */
    }
    }

}
