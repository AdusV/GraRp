using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : MonoBehaviour
{
    EnemyStates enemy;
    public PatrolState(EnemyStates enemy)
    {
        this.enemy = enemy;
    }
}
