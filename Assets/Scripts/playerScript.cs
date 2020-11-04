using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    Rigidbody2D rb;
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        anim.SetBool("walk-down", false);
        anim.SetBool("walk-up", false);
        anim.SetBool("walk-right", false);
        anim.SetBool("walk-left", false);
    }

    // Update is called once per frame
    void Update()
    {
        float xVelocity = 0;
        float yVelocity = 0;
        float speed = 17;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("walk-left", true);
            xVelocity = -speed;
        }
        else
        {
            anim.SetBool("walk-left", false);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("walk-right", true);
            xVelocity = speed;
        }
        else
        {
            anim.SetBool("walk-right", false);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("walk-up", true);
            yVelocity = speed;
        }
        else
        {
            anim.SetBool("walk-up", false);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("walk-down", true);
            yVelocity = -speed;
        }
        else
        {
            anim.SetBool("walk-down", false);
        }
    }
}
