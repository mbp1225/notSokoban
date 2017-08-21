using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {

    public RaycastHit hit;
    bool isPressed;
    Vector3 upOff;
    public GameObject wireOn, wireOff;

    public GameObject door;

	void Start ()
    {
        upOff = new Vector3(0, 0.5f, 0);
    }
	
	void Update ()
    {
        if (isPressed)
        {
            wireOn.SetActive(true);
            wireOff.SetActive(false);
        }
        if (!isPressed)
        {
            wireOn.SetActive(false);
            wireOff.SetActive(true);
        }

        //Checks if there's something above it.
        if ((Physics.Raycast(transform.localPosition - upOff, Vector3.up, 20f)))
        {
            //Debug.Log("Just has been pressed");
            Press(true);
        }
        else
        {
            Press(false);
        }
        //Debug.DrawRay(transform.localPosition - upOff, Vector3.up,Color.cyan,100);
	}

    void Press(bool pressed)
    {
        if((pressed != isPressed) && !(isPressed))
        {
            isPressed = true;
            door.GetComponent<DoorController>().buttonsPressed += 1;
        }
        else if ((pressed != isPressed) && (isPressed))
        {
            isPressed = false;
            door.GetComponent<DoorController>().buttonsPressed -= 1;
        }
    }
}
