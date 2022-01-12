using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : PlayerHelper
{

    // Start is called before the first frame update
    void Start()
    {
        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        x = ReadX();
        y = ReadY();

        Movement();
    }

    public void Movement()
    {
        rb2d.velocity = new Vector3(x, y,0) * speed;
    }


}
