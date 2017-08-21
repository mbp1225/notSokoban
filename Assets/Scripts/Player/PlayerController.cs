using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerController : MonoBehaviour {

    private Transform player;
    public GameObject cam;

    public float moveSpeed;

    private Vector3 upOff;

    private Vector3 curPos, lastPos;

    public RaycastHit hit;

    void Start ()
    {
        player = GetComponent<Transform>();
        upOff = new Vector3(0, 0.5f, 0);
    }

    void Update ()
    {
        curPos = player.transform.position;

        //This part calls the Move() funtion that, you guessed it, moves the player and does other things.
        if (curPos == lastPos)
        {
            if (cam.transform.eulerAngles.y > 40f && cam.transform.eulerAngles.y < 50f)
            {
                if (Input.GetKeyDown(KeyCode.W))
                {
                    Move(Vector3.forward);
                }
                if (Input.GetKeyDown(KeyCode.S))
                {
                    Move(-Vector3.forward);
                }
                if (Input.GetKeyDown(KeyCode.A))
                {
                    Move(-Vector3.right);
                }
                if (Input.GetKeyDown(KeyCode.D))
                {
                    Move(Vector3.right);
                }
            }
            else if (cam.transform.eulerAngles.y > 130f && cam.transform.eulerAngles.y < 140f)
            {
                if (Input.GetKeyDown(KeyCode.A))
                {
                    Move(Vector3.forward);
                }
                if (Input.GetKeyDown(KeyCode.D))
                {
                    Move(-Vector3.forward);
                }
                if (Input.GetKeyDown(KeyCode.S))
                {
                    Move(-Vector3.right);
                }
                if (Input.GetKeyDown(KeyCode.W))
                {
                    Move(Vector3.right);
                }
            }
            else if (cam.transform.eulerAngles.y > 220f && cam.transform.eulerAngles.y < 230f)
            {
                if (Input.GetKeyDown(KeyCode.W))
                {
                    Move(-Vector3.forward);
                }
                if (Input.GetKeyDown(KeyCode.S))
                {
                    Move(Vector3.forward);
                }
                if (Input.GetKeyDown(KeyCode.A))
                {
                    Move(Vector3.right);
                }
                if (Input.GetKeyDown(KeyCode.D))
                {
                    Move(-Vector3.forward);
                }
            }
            else if (cam.transform.eulerAngles.y > 310f && cam.transform.eulerAngles.y < 320f)
            {
                if (Input.GetKeyDown(KeyCode.A))
                {
                    Move(-Vector3.forward);
                }
                if (Input.GetKeyDown(KeyCode.D))
                {
                    Move(Vector3.forward);
                }
                if (Input.GetKeyDown(KeyCode.S))
                {
                    Move(Vector3.right);
                }
                if (Input.GetKeyDown(KeyCode.W))
                {
                    Move(-Vector3.right);
                }
            }
        }

        lastPos = curPos;
	}

    void Move(Vector3 dir)
    {
        if (dir == Vector3.forward || dir == -Vector3.forward)
        {
            if (!(Physics.Raycast(transform.position + upOff, dir, 1)))
            {
                player.transform.DOLocalMoveZ(player.transform.position.z + dir.z, moveSpeed, false);
            }
            else if ((Physics.Raycast(transform.position + upOff, dir, out hit, 1)) && hit.transform.tag == "Movable")
            {
                //Debug.Log("Movable");
                hit.collider.GetComponent<MovableProp>().Move(0, -dir.z, moveSpeed);
                player.transform.DOLocalMoveZ(player.transform.position.z + dir.z, moveSpeed, false);

            }
        }
        else if (dir == Vector3.right || dir == -Vector3.right)
        {
            if (!(Physics.Raycast(transform.position + upOff, dir, 1)))
            {
                player.transform.DOLocalMoveX(player.transform.position.x + dir.x, moveSpeed, false);
            }
            else if ((Physics.Raycast(transform.position + upOff, dir, out hit, 1)) && hit.transform.tag == "Movable")
            {
                //Debug.Log("Movable");
                hit.collider.GetComponent<MovableProp>().Move(-dir.x, 0, moveSpeed);
                player.transform.DOLocalMoveX(player.transform.position.x + dir.x, moveSpeed, false);

            }
        }
    }
}
