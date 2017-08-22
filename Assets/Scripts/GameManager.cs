using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameManager : MonoBehaviour {

    public GameObject commandsHelp;

    void Start ()
    {

	}
	
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.H))
        {
            commandsHelp.SetActive(!commandsHelp.activeInHierarchy);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(0);
        }
    }
}
