using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : PlayerHelper
{
    public float x;
    public float y;
    public float speed;
    public Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        

        Movement();
    }

    public void Movement()
    {
        x = ReadX();
        y = ReadY();
        rb2d.velocity = new Vector3(x, y,0) * speed;
    }


}
