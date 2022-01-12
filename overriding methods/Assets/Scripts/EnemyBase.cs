using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{

    protected virtual void AttackPlayer()
    {
        print("Enemy is attacking player");
    }
}
