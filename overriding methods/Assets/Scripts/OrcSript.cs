using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcSript : EnemyBase
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AttackPlayer();
    }
    protected override void AttackPlayer()
    {
        print("Orc is attacking player");
    }

}
