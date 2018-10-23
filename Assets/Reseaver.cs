using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reseaver : MonoBehaviour
{
    public GameObject gameobject;
    public GameObject gameobject2;

    public int number = 1000;
    public void ReturnAccess()
    {
        Debug.Log("アクセス成功！！");
    }

    void Start()
    {

    }

    public void Update()
    {
        if(GlobalVariables.RetryFlag == true)
        {
            GlobalVariables.target1.SetActive(false);
            GameObject[] cubes = GameObject.FindGameObjectsWithTag("ob_wall");
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
            //tag = "";

            GlobalVariables.StageWriteFlag = true;

            gameobject2.GetComponent<MakeStage>().SetStage();
        }
    }
}