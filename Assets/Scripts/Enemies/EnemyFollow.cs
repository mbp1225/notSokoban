using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyFollow : MonoBehaviour {

    GameObject player;

    [SerializeField]
    [Range(3, 10)]
    int range;

	void Start ()
    {
        player = GameObject.FindWithTag("Player");
        //Debug.Log(player.transform);
	}

    void Update ()
    {
		
	}

    public void Move()
    {
        player = GameObject.FindWithTag("Player");
        Vector3 dist = player.transform.position - transform.position;
        print("Distance to other: " + dist.x);
        //if ((player.transform.position.x - transform.position.x)<range) || (player.transform.position.z - transform.position.z) < range))
        //if (Vector3.Distance(player.transform.position,transform.position)<=range)
        if ((Mathf.Ceil(Mathf.Abs(player.transform.localPosition.x-transform.localPosition.x))<range) && (Mathf.Ceil(Mathf.Abs(player.transform.localPosition.y - transform.localPosition.y)) < range))
        {
            if ((Mathf.Abs(transform.position.x - player.transform.position.x)) < (Mathf.Abs(transform.position.z - player.transform.position.z)))
            {
                Debug.Log("in X range");
                if (player.transform.position.x > transform.position.x)
                {
                    Debug.Log("Moving");
                    //transform.DOMoveX(1, 1,true);
                    transform.DOLocalMoveX(transform.position.x + 1, 1f, false);
                }
                else
                {
                    Debug.Log("Moving");
                    //transform.DOMoveX(-1, 1, true);
                    transform.DOLocalMoveX(transform.position.x - 1, 1f, false);
                }
            }
            else
            {
                Debug.Log("in Y range");
                if (player.transform.position.z > transform.position.z)
                {
                    Debug.Log("Moving");
                    //transform.DOMoveZ(1, 1, true);
                    transform.DOLocalMoveZ(transform.position.z + 1, 1f, false);
                }
                else
                {
                    Debug.Log("Moving");
                    //transform.DOMoveZ(-1, 1, true);
                    transform.DOLocalMoveZ(transform.position.z + 1, 1f, false);
                }
            }
        }
    }


}
