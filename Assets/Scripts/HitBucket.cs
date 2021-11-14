using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBucket : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            ScoreManager.AddScore();
            collision.gameObject.GetComponent<BucketFollow>().Stop();
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 20f + Vector3.forward * -50f);
            collision.gameObject.GetComponent<AudioSource>().Play();
            Destroy(collision.gameObject);
            
        }
    }
}
