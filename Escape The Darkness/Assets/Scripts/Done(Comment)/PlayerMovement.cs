using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;

    private Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.A))
        {
            rigid.velocity = new Vector3(0, 0, -8);
        }

        if(Input.GetKeyDown (KeyCode.D))
        {
            rigid.velocity = new Vector3(0, 0, 8);
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
