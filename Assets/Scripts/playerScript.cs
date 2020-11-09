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
        float speed = 5;

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a"))
        {
            
            xVelocity = -speed;
            rb.velocity = new Vector2(xVelocity, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d"))
        {
            
            xVelocity = speed;
            rb.velocity = new Vector2(xVelocity, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w"))
        {

            yVelocity = speed;
            rb.velocity = new Vector2(0, yVelocity);
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s"))
        {

            yVelocity = -speed;
            rb.velocity = new Vector2(0, yVelocity);
        }

        if (xVelocity>0) //Moving Right
        {
            anim.SetBool("walk-right", true);
        }
        else
        {
            anim.SetBool("walk-right", false);
        }

        if (xVelocity<0) //Moving Left
        {
            anim.SetBool("walk-left", true);
        }
        else
        {
            anim.SetBool("walk-left", false);
        }

        if(yVelocity>0) //Moving Up
        {
            anim.SetBool("walk-up", true);
        }
        else
        {
            anim.SetBool("walk-up", false);
        }

        if(yVelocity<0) //Moving Down
        {
            anim.SetBool("walk-down", true);
        }
        else
        {
            anim.SetBool("walk-down", false);
        }
    }
}
