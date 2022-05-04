using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Run : MonoBehaviour
{
    public GameObject Player;

    UnityEngine.AI.NavMeshAgent enemyAgent;

    [SerializeField]
    float Distance;

    // Start is called before the first frame update
    void Start()
    {
        enemyAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);

        if (distance < Distance)
        {
            Vector3 toPlayer = transform.position - Player.transform.position;
            Vector3 newPosition = transform.position + toPlayer;
            enemyAgent.SetDestination(newPosition);
        }
    }
}