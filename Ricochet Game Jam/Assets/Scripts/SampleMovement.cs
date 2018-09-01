using UnityEngine;
using System.Collections;
using UnityEngine.AI;

//this is a sample movement script
public class SampleMovement : MonoBehaviour
{
    private Transform goal;
    private NavMeshAgent agent;

    void Start()
    {
        goal = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.destination = goal.position;
    }
}
