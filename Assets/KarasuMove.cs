using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarasuMove : MonoBehaviour {

    public int Direction;
    public GameObject Image;
    public GameObject Screen1;
    public GameObject Screen2;
    public GameObject Screen3;
    public GameObject Screen4;

    public int count;
    public float Hanten;
    public bool HantenFlag;

    // Use this for initialization
    void Start () {
        Direction = -1;
        Hanten = 180.0f;
        HantenFlag = false;

    }

    // Update is called once per frame
    void Update () {
        count = count + 1;
/*
        if (Direction == 1){
            this.transform.Translate(0.05f * Direction, 0, 0);
        }
*/
//        if (Direction == -1){
            this.transform.Translate(0.05f * Direction, 0, 0);

//        }

        /*
                if ((count % 2 == 0) && (Direction == 1))
                {
                    Screen1.transform.Translate(0.05f * Direction, 0, 0);

                }
                if ((count % 2 == 1) && (Direction == 1))
                {
                    Screen2.transform.Translate(0.05f * Direction, 0, 0);

                }
                if ((count % 2 == 0) && (Direction == -1))
                {
                    Screen3.transform.Translate(0.05f * Direction, 0, 0);

                }
                if ((count % 2 == 1) && (Direction == -1))
                {
                    Screen4.transform.Translate(0.05f * Direction, 0, 0);

                }
        */
    }

    public void OnCollisionEnter2D(Collision2D c)
    {
        string tag = c.gameObject.tag;

        if ((tag == "ob_wall")|| (tag == "Karasu"))
        {
//            Direction = Direction * -1;

            HantenFlag = true;

            if (HantenFlag == true)
            {
                this.transform.Rotate(0.0f, Hanten, 0.0f);
            }
            /*            if (HantenFlag == true)
                        {
            //                    Image = Instantiate(Screen3);
            //                      this.transform.Rotate(0.0f, Hanten, 0.0f);
                            HantenFlag = false;
                        }
                        /*            else if (Direction == -1)
                                    {
                        //                this.transform.Rotate(0.0f, Hanten, 0.0f);
                        //                this.transform.rotation = Quaternion.Euler(0.0f,Hanten, 0.0f);
                                    }*/
        }
        if (tag == "Player")
        {
            Direction = Direction;
        }

    }
}
