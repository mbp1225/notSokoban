using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraSpin : MonoBehaviour {

    private Transform camPos;

    int rotationStep = 90;

    [Range(0f,2f)]
    public float rotationDuration;

    private float curPos, lastPos;

    void Start ()
    {
        camPos = this.GetComponent<Transform>();
	}
	
	void Update ()
    {
        curPos = camPos.eulerAngles.y;

        //Code to do the spinning.
        if (curPos == lastPos)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                camPos.DOLocalRotate(new Vector3(0, camPos.eulerAngles.y + rotationStep, 0), rotationDuration);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                camPos.DOLocalRotate(new Vector3(0, camPos.eulerAngles.y - rotationStep, 0), rotationDuration);
            }
        }


        lastPos = curPos;
    }
}
