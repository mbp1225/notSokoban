using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MovableProp : MonoBehaviour {

    private Transform prop;

    void Start ()
    {
        prop = GetComponent<Transform>();
	}
	
	void Update ()
    {
		
	}

    public void Move(float directionX,float directionZ,float speed)
    {
        if      (directionZ != 0)
        {
            prop.transform.DOMoveZ(prop.transform.position.z - directionZ, speed, false);
        }
        else if (directionX != 0)
        {
            prop.transform.DOMoveX(prop.transform.position.x - directionX, speed, false);
        }
    }
}
