using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnEnemy : BaseEnemyScript
{
    public override void Start()
    {
        maxHP = 3;
        base.Start();
    }
}
