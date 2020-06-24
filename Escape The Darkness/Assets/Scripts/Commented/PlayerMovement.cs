using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //This changes the speed of the player
    public float speed = 5.0f;

    private Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    //This function bellow checks if the player has pressed a specfic key every frame
    //Then does something e.g. move left or right or jump
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.A))
        {
            rigid.velocity = new Vector3(0, 0, -7);
        }

        if(Input.GetKeyDown (KeyCode.D))
        {
            rigid.velocity = new Vector3(0, 0, 7);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            rigid.velocity = new Vector3(0, 8, 0);
        }


        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    public void SetSpeed(float modifier)
    {
        speed = 5.0f + modifier;
    }
}
