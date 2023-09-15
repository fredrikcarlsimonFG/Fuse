using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class PatrollingEnemy : MonoBehaviour
{
    [SerializeField] private NavMeshAgent patrollingEnemy;
    [SerializeField] private Transform position1;
    [SerializeField] private Transform position2;

    private Vector3 currentTarget;


    void Start()
    {
        patrollingEnemy.SetDestination(position1.position);
        currentTarget = position1.position;
    }

    void Update()
    {
        if(patrollingEnemy.remainingDistance < 0.35f)
        {
            if(currentTarget == position1.position)
            {
                    currentTarget = position2.position;
            }
            else
            {
                    currentTarget = position1.position;
            }
            patrollingEnemy.SetDestination(currentTarget);
        }
    }
}
