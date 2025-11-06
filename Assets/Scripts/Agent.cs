using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem.Android;

[RequireComponent(typeof(NavMeshAgent))]


public class Agent : MonoBehaviour
{
    public LayerMask groundMask;
    NavMeshAgent agent;
    public GameObject Player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }


    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(Player.transform.position); 
    }
}
