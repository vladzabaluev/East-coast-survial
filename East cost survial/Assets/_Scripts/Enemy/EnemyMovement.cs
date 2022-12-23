using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform Player;

    private NavMeshAgent _agent;

    private void Start()
    {
        _agent = transform.GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        _agent.SetDestination(Player.position);
    }
}
