using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BucketFollow : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent ai;
    // Start is called before the first frame update
    void Start()
    {
        ai = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        ai.SetDestination(player.position);
    }
}
