using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xVelocity = 0;
        float yVelocity = 0;
        float speed = 17;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.setBool("walk-left", true);
            xVelocity = -speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.setBool("walk-left", true);
            xVelocity = speed;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.setBool("walk-left", true);
            yVelocity = speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.setBool("walk-left", true);
            yVelocity = -speed;
        }
    }
}
