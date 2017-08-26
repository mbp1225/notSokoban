using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameManager : MonoBehaviour {

    public GameObject commandsHelp;

    public List<GameObject> enemies;

    public GameObject enemySeeker;
    public Vector3[] enemyPos;

    void Start ()
    {
        foreach(Vector3 pos in enemyPos)
        {
            Instantiate(enemySeeker,pos,transform.rotation,transform);
            enemies.Add(enemySeeker);
            //Debug.Log("Added enemy to list");
        }
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

    //This function is called every turn to do turn things.
    public void Step()
    {
        foreach(GameObject enemy in enemies)
        {
            enemy.GetComponent<EnemyFollow>().Move();
        }
    }
}
