using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public GameObject player ;
    public Vector3 offset;
    public Vector3 newPosition;

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        offset = transform.position - player.transform.position;
    }

    public void UPStart()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        offset = transform.position - player.transform.position;
    }
    void LateUpdate()
    {
        if(GlobalVariables.StageClearFlag == false)
        {
//            player = GameObject.FindGameObjectWithTag("Player");
//            offset = transform.position - player.transform.position;
            Vector3 newPosition = transform.position;
            newPosition.x = player.transform.position.x + offset.x;
            newPosition.y = player.transform.position.y + offset.y;
            newPosition.z = player.transform.position.z + offset.z;
            transform.position = Vector3.Lerp(transform.position, newPosition, 5.0f * Time.deltaTime);
        }
    }
}
