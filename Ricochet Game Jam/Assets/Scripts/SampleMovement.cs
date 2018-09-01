using UnityEngine;
using System.Collections;
using UnityEngine.AI;

//this is a sample movement script
public class SampleMovement : MonoBehaviour
{
    public Transform goal;

    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.destination = goal.position;
    }
}
