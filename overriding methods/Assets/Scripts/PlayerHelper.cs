using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHelper : MonoBehaviour
{
    public float x;
    public float y;
    public float speed;

    public Rigidbody2D rb2d;

    float playerDamage;

    protected virtual void PlayerDamage()
    {

    }

    protected virtual float ReadX()
    {
       return Input.GetAxis("Horizontal");        
    }
    protected virtual float ReadY()
    {
        return Input.GetAxis("Vertical");        
    }
}
