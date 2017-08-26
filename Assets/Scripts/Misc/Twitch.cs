using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Twitch : MonoBehaviour {



	void Start ()
    {
		
	}
	
	void Update ()
    {
        transform.DOShakePosition(1f, 0.01f, 1, 90, false, false);
        transform.DOShakeRotation(0.1f,0.1f,1,90,false);
        //transform.DOShakeScale(0.25f, 0.1f, 1, 90, false);
    }
}
