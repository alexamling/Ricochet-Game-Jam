using UnityEngine;
using System.Collections;
using UnityEngine.AI;

//this is a sample movement script
public class SampleMovement : MonoBehaviour
{
    public Transform goal;
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }
}
