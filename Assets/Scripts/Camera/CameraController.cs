using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraController : MonoBehaviour {

    //This script get both the player's and the camera controller's transform and, if the distance between them goes beyond a given value, lerps the camera to the player;

    public GameObject player;
    private Transform playerPos;
    private Transform camPos;

    public float maxDis;
    public float lerpDuration;

    float xDis, zDis;

	void Start ()
    {
        playerPos = player.GetComponent<Transform>();
        camPos = this.GetComponent<Transform>();
	}
	
	void Update ()
    {
        xDis = Mathf.Abs(playerPos.position.x - camPos.position.x);
        zDis = Mathf.Abs(playerPos.position.z - camPos.position.z);

        if (xDis > maxDis || zDis > maxDis)
        {
            camPos.DOMove(playerPos.transform.position, lerpDuration, false);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            camPos.DOMove(playerPos.transform.position, lerpDuration, false);
        }
    }
}
