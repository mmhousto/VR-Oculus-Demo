using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakStud : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Saw")
        {
            transform.SetParent(null);
            var rb = GetComponent<Rigidbody>();
            rb.useGravity = true;
            rb.isKinematic = false;
        }
    }

    /*void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Saw")
        {
            transform.SetParent(null);
            var rb = GetComponent<Rigidbody>();
            rb.useGravity = true;
            rb.isKinematic = false;
        }
    }*/
}
