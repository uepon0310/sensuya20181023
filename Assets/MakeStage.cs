﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


static class GlobalVariables
{
    static public int  StageNumber;
    static public bool StageWriteFlag;
    static public bool ResetTimeFlag;
    static public float HusenGravityX;
    static public bool AnimationLeftFlag;
    static public bool AnimationRightFlag;
    static public bool AnimationIdleFlag;
    static public bool AnimationDownFlag;
    static public GameObject target1;
    static public Vector2 HusenPosition;
    static public bool RetryFlag;
    static public bool BombFlag;
    static public bool ReadyFlag =  false;


}

public class MakeStage : MonoBehaviour
{

    public GameObject Player;
    public GameObject GameScreen1;
    public GameObject GameScreen2;
    public GameObject GameScreen3;
    public GameObject GameScreen4;
    public GameObject GameScreen5;
    public GameObject GameScreen6;
    public GameObject GameScreen7;
    public GameObject GameScreen8;
    public GameObject GameScreen9;
    public GameObject GameScreen10;

    
    public float GameObjectHight;
    public float GameObjectWight;

    public GameObject target1;
//    public bool StageWriteFlag;

    public int StageDataX, StageDataY;
    public int Stage;

//    public int StageNumber;
//    public int Stage;

    enum StageNumbering
    {
        Stage_1 = 1,
        Stage_2,
        Stage_3,
        Stage_4,
        Stage_5,
        Stage_6,
        Stage_7,
        Stage_8,
        Stage_9,
        Stage_10,
        Stage_11,
        Stage_12,
        Stage_13,
        Stage_14,
        Stage_15,
        Stage_16,
        Stage_17,
        Stage_18

    }


    public int[,] StageData1 = new int[,]{
            //0 1 2 3 4 5 6 7 8 9
            { 1,1,1,1,1,1,1,1,1,1 },//0
            { 1,0,0,0,0,0,0,0,0,1 },//1
            { 1,0,12,0,0,0,0,0,0,1 },//2
            { 1,0,0,0,0,4,0,0,0,1 },//3
            { 1,0,0,0,0,0,0,0,0,1 },//4
            { 1,0,0,0,0,0,0,4,0,1 },//5
            { 1,0,0,0,0,0,0,0,0,1 },//6
            { 1,0,0,0,0,0,0,0,0,1 },//7
            { 1,0,0,0,0,0,0,0,0,1 },//8
            { 1,0,0,0,0,0,0,0,0,1 },//9
            { 1,0,0,0,0,0,0,0,0,1 },//10
            { 1,0,0,0,0,0,0,0,0,1 },//11
            { 1,0,0,0,0,0,0,0,0,1 },//12
            { 1,0,0,0,0,0,0,0,0,1 },//13
            { 1,0,0,0,0,0,0,0,0,1 },//14
            { 1,0,0,0,0,0,0,0,0,1 },//15
            { 1,0,0,0,0,0,0,0,0,1 },//16
            { 1,0,0,0,0,0,0,0,0,1 },//17
            { 1,0,0,0,0,0,0,0,0,1 },//18
            { 1,0,0,0,0,0,0,0,0,1 },//19
            { 1,0,0,0,0,0,0,0,0,1 },//20
            { 1,0,0,0,0,0,0,0,0,1 },//21
            { 1,1,1,0,0,0,0,1,1,1 },//22
            { 9,9,9,9,9,9,9,9,9,9 },//23
        };



    public int[,] StageData2 = new int[,]{
            //0 1 2 3 4 5 6 7 8 9
            { 1,1,1,1,1,1,1,1,1,1 },//0
            { 1,0,0,0,0,0,0,0,0,1 },//1
            { 1,0,12,0,0,0,0,0,0,1 },//2
            { 1,0,0,0,0,0,0,0,0,1 },//3
            { 1,0,0,0,0,0,0,0,0,1 },//4
            { 1,0,0,0,0,0,0,0,0,1 },//5
            { 1,0,0,0,4,0,0,0,0,1 },//6
            { 1,0,0,0,0,0,0,0,0,1 },//7
            { 1,0,0,0,0,0,0,0,0,1 },//8
            { 1,0,0,0,0,0,0,0,0,1 },//9
            { 1,0,0,0,0,0,0,0,0,1 },//9
            { 1,0,0,0,4,0,0,0,0,1 },//10
            { 1,0,0,0,0,0,0,0,0,1 },//11
            { 1,0,0,0,0,0,0,0,0,1 },//12
            { 1,0,0,0,0,0,0,0,0,1 },//13
            { 1,0,0,0,0,0,0,0,0,1 },//14
            { 1,0,0,0,0,0,0,0,0,1 },//15
            { 1,0,0,0,0,0,0,0,0,1 },//16
            { 1,0,0,0,4,0,0,0,0,1 },//17
            { 1,0,0,0,0,0,0,0,0,1 },//18
            { 1,0,0,0,0,0,0,0,0,1 },//19
            { 1,0,0,0,0,0,0,0,0,1 },//20
            { 1,0,0,0,0,0,0,0,0,1 },//21
            { 1,1,1,0,0,0,0,1,1,1 },//22
            { 9,9,9,9,9,9,9,9,9,9 },//23
        };

    public int[,] StageData3 = new int[,]{
            //0 1 2 3 4 5 6 7 8 9
            { 1,1,1,1,1,1,1,1,1,1 },//0
            { 1,0,0,0,0,0,0,0,0,1 },//1
            { 1,0,12,0,0,0,0,0,0,1 },//2
            { 1,0,0,0,0,0,0,0,0,1 },//3
            { 1,0,0,0,0,0,0,0,0,1 },//4
            { 1,0,0,0,0,0,0,0,0,1 },//5
            { 1,0,0,0,0,10,0,0,0,1 },//6
            { 1,0,0,0,0,0,0,0,0,1 },//7
            { 1,0,0,0,0,0,0,0,0,1 },//8
            { 1,0,0,0,0,0,0,0,0,1 },//9
            { 1,0,0,0,0,0,0,0,0,1 },//9
            { 1,0,0,0,10,0,0,0,0,1 },//10
            { 1,0,0,0,0,0,0,0,0,1 },//11
            { 1,0,0,0,0,0,0,0,0,1 },//12
            { 1,0,0,0,0,0,0,0,0,1 },//13
            { 1,0,0,0,0,0,0,0,0,1 },//14
            { 1,0,0,0,0,0,0,0,0,1 },//15
            { 1,0,0,0,0,0,0,0,0,1 },//16
            { 1,0,0,0,10,0,0,0,0,1 },//17
            { 1,0,0,0,0,0,0,0,0,1 },//18
            { 1,0,0,0,0,0,0,0,0,1 },//19
            { 1,0,0,0,0,0,0,0,0,1 },//20
            { 1,0,0,0,0,0,0,0,0,1 },//21
            { 1,1,1,0,0,0,0,1,1,1 },//22
            { 9,9,9,9,9,9,9,9,9,9 },//23
        };

    public int[,] StageData4 = new int[,]{
            //0 1 2 3 4 5 6 7 8 91011121314151617 
            { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },//0
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//1
            { 1,0,12,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//2
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//3
            { 1,0,0,0,0,0,0,0,0,5,0,0,0,0,0,0,0,1 },//4
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//5
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//6
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//7
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//8
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//9
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//10
            { 1,0,0,0,0,0,0,0,5,0,0,0,0,0,0,0,0,1 },//11
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//12
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//13
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//14
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//15
            { 1,1,1,1,1,1,1,0,0,0,0,1,1,1,1,1,1,1 },//16
            { 9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9 },//17
        };

    public int[,] StageData5 = new int[,]{
            //0 1 2 3 4 5 6 7 8 91011121314151617 
            { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },//0
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//1
            { 1,0,12,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//2
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//3
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//4
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//5
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//6
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//7
            { 1,0,0,0,6,0,0,0,0,6,0,0,0,0,6,0,0,1 },//8
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//9
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//10
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//11
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//12
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//13
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//14
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//15
            { 1,1,1,1,1,1,1,0,0,0,0,1,1,1,1,1,1,1 },//16
            { 9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9 },//17
        };

    public int[,] StageData6 = new int[,]{
            //0 1 2 3 4 5 6 7 8 91011121314151617 
            { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },//0
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//1
            { 1,0,12,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//2
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//3
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//4
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//5
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//6
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//7
            { 1,0,0,0,0,0,0,0,0,7,0,0,0,0,0,0,0,1 },//8
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//9
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//10
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//11
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//12
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//13
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//14
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//15
            { 1,1,1,1,1,1,1,0,0,0,0,1,1,1,1,1,1,1 },//16
            { 9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9 },//17
        };

    public int[,] StageData7 = new int[,]{
            //0 1 2 3 4 5 6 7 8 91011121314151617 
            { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },//0
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//1
            { 1,0,12,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//2
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//3
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//4
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//5
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//6
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//7
            { 1,0,0,0,0,0,0,0,0,8,0,0,0,0,0,0,0,1 },//8
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//9
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//10
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//11
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//12
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//13
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//14
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//15
            { 1,1,1,1,1,1,1,0,0,0,0,1,1,1,1,1,1,1 },//16
            { 9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9 },//17
        };

    public int[,] StageData8 = new int[,]{
            //0 1 2 3 4 5 6 7 8 91011121314151617 
            { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },//0
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//1
            { 1,0,12,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//2
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//3
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//4
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//5
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//6
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//7
            { 1,0,0,0,0,0,0,0,0,10,0,0,0,0,0,0,0,1 },//8
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//9
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//10
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//11
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//12
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//13
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//14
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//15
            { 1,1,1,1,1,1,1,0,0,0,0,1,1,1,1,1,1,1 },//16
            { 9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9 },//17
        };

    public int[,] StageData9 = new int[,]{
            //0 1 2 3 4 5 6 7 8 91011121314151617 
            { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },//0
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//1
            { 1,0,12,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//2
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//3
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//4
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//5
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//6
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//7
            { 1,0,0,0,0,0,0,0,0,11,0,0,0,0,0,0,0,1 },//8
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//9
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//10
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//11
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//12
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//13
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//14
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//15
            { 1,1,1,1,1,1,1,0,0,0,0,1,1,1,1,1,1,1 },//16
            { 9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9 },//17
        };

    public int[,] StageData10 = new int[,]{
            //0 1 2 3 4 5 6 7 8 9
            { 1,1,1,1,1,1,1,1,1,1 },//0
            { 1,0,0,0,0,0,0,0,0,1 },//1
            { 1,0,0,0,12,0,0,0,0,1 },//2
            { 1,0,0,0,0,0,0,0,0,1 },//3
            { 1,0,0,0,0,0,0,0,0,1 },//4
            { 1,0,0,0,0,0,0,0,0,1 },//5
            { 1,0,0,0,1,1,1,1,1,1 },//6
            { 1,0,0,0,0,0,0,0,0,1 },//7
            { 1,0,0,0,0,0,0,0,0,1 },//8
            { 1,0,0,0,0,0,0,0,0,1 },//9
            { 1,0,0,0,0,0,0,0,0,1 },//9
            { 1,0,0,0,0,0,0,0,0,1 },//10
            { 1,0,0,0,0,0,0,0,0,1 },//11
            { 1,1,1,1,1,1,0,0,0,1 },//12
            { 1,0,0,0,0,0,0,0,0,1 },//13
            { 1,0,0,0,0,0,0,0,0,1 },//14
            { 1,0,0,0,0,0,0,0,0,1 },//15
            { 1,0,0,0,0,0,0,0,0,1 },//16
            { 1,0,0,0,0,0,0,0,0,1 },//17
            { 1,0,0,0,0,0,0,0,0,1 },//18
            { 1,0,0,0,0,0,0,0,0,1 },//19
            { 1,0,0,0,0,0,0,0,0,1 },//20
            { 1,1,1,0,0,0,0,1,1,1 },//21
            { 9,9,9,9,9,9,9,9,9,9 },//22
        };

    public int[,] StageData11 = new int[,]{
            //0 1 2 3 4 5 6 7 8 9
            { 1,1,1,1,1,1,1,1,1,1 },//0
            { 1,0,0,0,0,0,0,0,0,1 },//1
            { 1,0,12,0,0,0,0,0,0,1 },//2
            { 1,0,0,0,0,0,0,0,0,1 },//3
            { 1,0,0,0,0,0,0,0,0,1 },//4
            { 1,1,1,1,1,0,0,0,0,1 },//5
            { 1,0,0,0,0,0,0,0,0,1 },//6
            { 1,0,0,0,0,0,0,0,0,1 },//7
            { 1,0,0,0,0,0,0,0,0,1 },//8
            { 1,0,0,0,0,0,0,0,0,1 },//9
            { 1,0,0,0,0,0,1,0,0,1 },//10
            { 1,0,0,0,0,0,1,0,0,1 },//11
            { 1,0,0,0,0,0,1,0,0,1 },//12
            { 1,0,0,1,1,1,1,1,1,1 },//13
            { 1,0,0,0,0,0,0,0,0,1 },//14
            { 1,0,0,0,0,0,0,0,0,1 },//15
            { 1,0,0,0,0,0,0,0,0,1 },//16
            { 1,0,0,1,1,1,1,0,0,1 },//17
            { 1,0,0,0,0,0,0,0,0,1 },//18
            { 1,0,0,0,0,0,0,0,0,1 },//19
            { 1,0,0,0,0,0,0,0,0,1 },//20
            { 1,0,0,0,0,0,0,0,0,1 },//21
            { 1,1,1,0,0,0,0,1,1,1 },//22
            { 9,9,9,9,9,9,9,9,9,9 },//23
        };


    public int[,] StageData12 = new int[,]{

//0 1 2 3 4 5 6 7 8 9101112131415161718192021 
{ 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },//0
{ 1,0,12,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//1
{ 1,0,0,0,0,0,0,0,0,0,5,0,0,0,0,0,0,0,0,0,0,1 },//2
{ 1,0,4,0,0,0,0,0,0,0,10,0,0,0,0,0,0,0,0,4,0,1 },//3
{ 1,0,0,0,0,5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//4
{ 1,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,1 },//5
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//6
{ 1,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,1 },//7
{ 1,0,0,0,0,0,0,0,0,0,5,0,0,0,0,0,0,0,5,0,0,1 },//8
{ 1,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,1 },//9
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//10
{ 1,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,1 },//11
{ 1,0,0,0,0,6,0,0,0,0,6,0,0,0,0,0,6,0,0,0,0,1 },//12
{ 1,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,1 },//13
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//14
{ 1,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,1 },//15
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//16
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//17
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//18
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//19
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//20
{ 1,2,0,0,0,0,0,0,0,0,0,11,0,0,0,0,0,0,0,0,2,1 },//21
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//22
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//23
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//24
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//25
{ 1,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,2,1 },//26
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//27
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//28
{ 1,0,0,0,0,0,0,0,0,0,0,8,0,0,0,0,0,0,0,0,0,1 },//29
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//30
{ 1,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,2,2,2,1 },//31
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//32
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//33
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//34
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//35
{ 1,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,2,2,2,2,1 },//36
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//37
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//38
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//39
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//40
{ 1,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,2,2,2,2,2,1 },//41
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//42
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//43
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//44
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//45
{ 1,2,2,2,2,2,2,2,0,0,0,0,0,0,0,2,2,2,2,2,2,1 },//46
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//47
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//48
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//49
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//50
{ 1,2,2,2,2,2,2,2,2,0,0,0,0,2,2,2,2,2,2,2,2,1 },//51
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//52
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//53
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//54
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//55
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,1 },//56
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//57
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//58
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//59
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//60
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//61
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//62
{ 1,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0,0,0,0,0,0,1 },//63
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//64
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//65
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//66
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//67
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//68
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//69
{ 1,0,0,0,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//70
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//71
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//72
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//73
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//74
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//75
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//76
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//77
{ 1,1,1,1,1,1,1,1,1,0,0,0,0,1,1,1,1,1,1,1,1,1 },//78
{ 9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9 }//79

    };
    public void Start()
    {
        if (GlobalVariables.ReadyFlag == false)
        {
            StageDataX = 10;
            StageDataY = 23;
            GlobalVariables.StageNumber = (int)StageNumbering.Stage_1;
            GlobalVariables.StageWriteFlag = true;
            CreateStage(StageData1, StageDataX, StageDataY);
//            GlobalVariables.ReadyFlag = true;
        }
        /*
                StageDataX = 18;
                StageDataY = 17;
                GlobalVariables.StageNumber = (int)StageNumbering.Stage_6;
                GlobalVariables.StageWriteFlag = true;
                CreateStage(StageData6, StageDataX, StageDataY);
        */



        /*
        StageDataX = 22;
        StageDataY = 79;
        GlobalVariables.StageNumber = (int)StageNumbering.Stage_2;
        GlobalVariables.StageWriteFlag = true;
        CreateStage(StageData2, StageDataX, StageDataY);
        */
    }

    public void Update()
    {
        if (GlobalVariables.ReadyFlag == false)
        {
            SetStage();
            GlobalVariables.ReadyFlag = true;

        }
    }

    public void SetStage()
    {
        Stage = GlobalVariables.StageNumber;
        //        if (GlobalVariables.StageWriteFlag == true)
        //        {

        if (GlobalVariables.StageNumber == (int)StageNumbering.Stage_1)
        {
            StageDataX = 10;
            StageDataY = 23;
            CreateStage(StageData1, StageDataX, StageDataY);
            //                CreateStage(StageData2, StageDataX, StageDataY);//22,79
        }

        if (GlobalVariables.StageNumber == (int)StageNumbering.Stage_2)
        {
            StageDataX = 10;
            StageDataY = 24;
            CreateStage(StageData2, StageDataX, StageDataY);
            //                CreateStage(StageData2, StageDataX, StageDataY);//22,79
        }

        if (GlobalVariables.StageNumber == (int)StageNumbering.Stage_3)
        {
            StageDataX = 10;
            StageDataY = 24;
            CreateStage(StageData3, StageDataX, StageDataY);
            //                CreateStage(StageData2, StageDataX, StageDataY);//22,79
        }

        if (GlobalVariables.StageNumber == (int)StageNumbering.Stage_4)
        {
            StageDataX = 18;
            StageDataY = 17;
            CreateStage(StageData4, StageDataX, StageDataY);
            //                CreateStage(StageData2, StageDataX, StageDataY);//22,79
        }

        if (GlobalVariables.StageNumber == (int)StageNumbering.Stage_5)
        {
            StageDataX = 18;
            StageDataY = 17;
            CreateStage(StageData5, StageDataX, StageDataY);
            //                CreateStage(StageData2, StageDataX, StageDataY);//22,79
        }
        if (GlobalVariables.StageNumber == (int)StageNumbering.Stage_6)
        {
            StageDataX = 18;
            StageDataY = 17;
            CreateStage(StageData6, StageDataX, StageDataY);
            //                CreateStage(StageData2, StageDataX, StageDataY);//22,79
        }

        if (GlobalVariables.StageNumber == (int)StageNumbering.Stage_7)
        {
            StageDataX = 18;
            StageDataY = 17;
            CreateStage(StageData7, StageDataX, StageDataY);
            //                CreateStage(StageData2, StageDataX, StageDataY);//22,79
        }

        if (GlobalVariables.StageNumber == (int)StageNumbering.Stage_8)
        {
            StageDataX = 18;
            StageDataY = 17;
            CreateStage(StageData8, StageDataX, StageDataY);
            //                CreateStage(StageData2, StageDataX, StageDataY);//22,79
        }

        if (GlobalVariables.StageNumber == (int)StageNumbering.Stage_9)
        {
            StageDataX = 18;
            StageDataY = 17;
            CreateStage(StageData9, StageDataX, StageDataY);
            //                CreateStage(StageData2, StageDataX, StageDataY);//22,79
        }

        if (GlobalVariables.StageNumber == (int)StageNumbering.Stage_10)
        {
            StageDataX = 10;
            StageDataY = 23;
            CreateStage(StageData10, StageDataX, StageDataY);
            //                CreateStage(StageData2, StageDataX, StageDataY);//22,79
        }

        if (GlobalVariables.StageNumber == (int)StageNumbering.Stage_11)
        {
            StageDataX = 10;
            StageDataY = 23;
            CreateStage(StageData11, StageDataX, StageDataY);
            //                CreateStage(StageData2, StageDataX, StageDataY);//22,79
        }

        if (GlobalVariables.StageNumber == (int)StageNumbering.Stage_12)
        {
            StageDataX = 22;
            StageDataY = 79;
            GlobalVariables.StageNumber = (int)StageNumbering.Stage_12;
            GlobalVariables.StageWriteFlag = true;
            CreateStage(StageData12, StageDataX, StageDataY);
        }

    }

    public void CreateStage(int[,] data, int x, int y)
    {

        if (GlobalVariables.StageWriteFlag == true)
        {
            GameObjectWight = GameScreen1.GetComponent<SpriteRenderer>().bounds.size.x;
        GameObjectHight = GameScreen1.GetComponent<SpriteRenderer>().bounds.size.y;

            target1.transform.position = new Vector2(GameObjectHight, GameObjectWight);
            //target1.transform.position = new Vector2(GameObjectHight, GameObjectWight);
            //            for (int i = 0; i < x; i++)
            for (int i = 0  ; i < x ; i++)
                {
                    for (int j = y; j >= 0; j--)
                {
                    if (data[j, i] == 1)
                    {
                        //       GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        GameObject obj = Instantiate(GameScreen1);
                        obj.tag = "ob_wall";
                        obj.transform.localScale = new Vector2(1, 1);
                        obj.transform.position = new Vector2(GameObjectHight * i, GameObjectWight * j);
                    }
                    if (data[j, i] == 2)
                    {
                        //       GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        GameObject obj3 = Instantiate(GameScreen3);
                        obj3.tag = "ob_wall";
                        obj3.transform.localScale = new Vector2(1, 1);
                        obj3.transform.position = new Vector2(GameObjectHight * i, GameObjectWight * j);
                    }
                    if (data[j, i] == 9)
                    {
                        GameObject obj2 = Instantiate(GameScreen2); ;
                        obj2.tag = "goal";
                        obj2.transform.localScale = new Vector2(1, 1);
                        obj2.transform.position = new Vector2(GameObjectHight * i, GameObjectWight * j);
                    }
                    if (data[j, i] == 4)
                    {
                        GameObject obj4 = Instantiate(GameScreen4); ;
                        obj4.tag = "Karasu";
                        obj4.transform.localScale = new Vector2(1, 1);
                        obj4.transform.position = new Vector2(GameObjectHight * i, GameObjectWight * j);
                    }
                    if (data[j, i] == 5)
                    {
                        GameObject obj5 = Instantiate(GameScreen5); ;
                        obj5.tag = "Togetoge";
                        obj5.transform.localScale = new Vector2(1, 1);
                        obj5.transform.position = new Vector2(GameObjectHight * i, GameObjectWight * j);
                    }
                    if (data[j, i] == 6)
                    {
                        GameObject obj6 = Instantiate(GameScreen6); ;
                        obj6.tag = "Togetoge";
                        obj6.transform.localScale = new Vector2(1, 1);
                        obj6.transform.position = new Vector2(GameObjectHight * i, GameObjectWight * j);
                    }
                    if (data[j, i] == 7)
                    {
                        GameObject obj7 = Instantiate(GameScreen7); ;
                        obj7.tag = "Togetoge";
                        obj7.transform.localScale = new Vector2(1, 1);
                        obj7.transform.position = new Vector2(GameObjectHight * i, GameObjectWight * j);
                    }
                    if (data[j, i] == 8)
                    {
                        GameObject obj8 = Instantiate(GameScreen8); ;
                        obj8.tag = "Togetoge";
                        obj8.transform.localScale = new Vector2(1, 1);
                        obj8.transform.position = new Vector2(GameObjectHight * i, GameObjectWight * j);
                    }
                    if (data[j, i] == 10)
                    {
                        GameObject obj9 = Instantiate(GameScreen9); ;
                        obj9.tag = "Togetoge";
                        obj9.transform.localScale = new Vector2(1, 1);
                        obj9.transform.position = new Vector2(GameObjectHight * i, GameObjectWight * j);
                    }
                    if (data[j, i] == 11)
                    {
                        GameObject obj10 = Instantiate(GameScreen10); ;
                        obj10.tag = "Togetoge";
                        obj10.transform.localScale = new Vector2(1, 1);
                        obj10.transform.position = new Vector2(GameObjectHight * i, GameObjectWight * j);
                    }
                    if (data[j, i] == 12)
                    {
                        GameObject obj11 = Instantiate(Player); ;
                        obj11.tag = "Player";
                        obj11.transform.localScale = new Vector2(1, 1);
                        obj11.transform.position = new Vector2(GameObjectHight * i, GameObjectWight * j);
                        
                    }
                }

            }
            GlobalVariables.StageWriteFlag = false;
            GlobalVariables.ResetTimeFlag = true;

        }
    }




}

