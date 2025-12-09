using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class EnemyPatrol : MonoBehaviour
{
    public LayerMask groundMask; 
    public Transform[] patrolPoints;
    public int targetPoint;
    public float speed;
    NavMeshAgent agent;
    public GameObject Player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        targetPoint = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == patrolPoints[targetPoint].position)
        {
              increaseTargetint();
        }
        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[targetPoint].position, speed * Time.deltaTime);
    }

    void increaseTargetint()
    {
        targetPoint++;
        if (targetPoint >= patrolPoints.Length)
        {
            targetPoint = 0;
        }
    }

}
