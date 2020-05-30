using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyStates : MonoBehaviour
{
    public Transform[] wayPoints;
    public int patrolRange;
    public Transform vision;
    public float viewAngle;

    public LayerMask raycastMask;

    [HideInInspector]
    public PatrolState patrolState;
    [HideInInspector]
    public IEnemyAI currentState;
    [HideInInspector]
    public Transform chaseTarget;
    [HideInInspector]
    public NavMeshAgent navMeshAgent;

    private void Awake()
    {
        patrolState = new PatrolState(this);
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    //private void Start()
    //{
    //    currentState = patrolState;
    //}
    private void Update()
    {
        currentState.UpdateActions();
    }
   public bool EnemySpotted()
    {
        Vector3 direction = GameObject.FindWithTag("Player").transform.position - transform.position;
        float angle = Vector3.Angle(direction, vision.forward);

        if(angle<viewAngle*10f)
        {
            Debug.Log("Widze");
            RaycastHit hit;
            if(Physics.Raycast(vision.transform.position,direction.normalized,out hit,patrolRange,raycastMask))
            {
                if(hit.collider.CompareTag("Player"))
                {
                    chaseTarget = hit.transform;
                    return true;
                }
            }
        }
        return false;
    }
   
}
