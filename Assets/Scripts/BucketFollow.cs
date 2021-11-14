using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BucketFollow : MonoBehaviour
{
    private Transform player;
    private NavMeshAgent ai;

    private bool isHit = false;

    // Start is called before the first frame update
    void Start()
    {
        isHit = false;
        player = GameObject.FindWithTag("Player").transform;
        ai = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isHit == false)
        {
            Follow();
        }
    }

    void Follow()
    {
        ai.SetDestination(player.position);
    }

    public void Stop()
    {
        isHit = true;
        ai.isStopped = true;
    }

}
