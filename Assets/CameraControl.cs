using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    private GameObject player = null;
    private Vector3 offset = Vector3.zero;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        offset = transform.position - player.transform.position;
        //offset = transform.position - GlobalVariables.target1.transform.position;
    }

    public void ReStart()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        offset = transform.position - player.transform.position;
        //offset = transform.position - GlobalVariables.target1.transform.position;
    }

    void LateUpdate()
    {
        Vector3 newPosition = transform.position;
//        newPosition.x = player.transform.position.x + offset.x;
//        newPosition.y = player.transform.position.y + offset.y;
//        newPosition.z = player.transform.position.z + offset.z;
        newPosition.x = GlobalVariables.HusenPosition.x + offset.x;
        newPosition.y = GlobalVariables.HusenPosition.y + offset.y;
//        newPosition.z = GlobalVariables.HusenPosition.z + offset.z;
        transform.position = Vector3.Lerp(GlobalVariables.HusenPosition, newPosition, 5.0f * Time.deltaTime);
    }
}
