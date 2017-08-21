using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoorController : MonoBehaviour {

    [SerializeField]
    private bool isOpen;

    [SerializeField]
    private int buttonsToOpen;
    public int buttonsPressed = 0;
    

    void Start ()
    {
		
	}
	
	void Update ()
    {
		if (buttonsPressed == buttonsToOpen)
        {
            Open();
        }
        else
        {
            Close();
        }
	}

    void Open()
    {
        if (transform.position.y == 0)
        {
            transform.DOLocalMoveY(1, 1, false);
        }
        
    }

    void Close()
    {
        if (transform.position.y == 1)
        {
            transform.DOLocalMoveY(0, 1, false);
        }
    }
}
