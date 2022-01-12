using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHelper : MonoBehaviour
{


    //float playerDamage;

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
