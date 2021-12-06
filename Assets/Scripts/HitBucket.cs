using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBucket : MonoBehaviour
{

    private bool hasHit;

    // Start is called before the first frame update
    void Start()
    {
        hasHit = false;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy") && !hasHit)
        {
            hasHit = true;
            ScoreManager.AddScore();
            collision.gameObject.GetComponent<BucketFollow>().Stop();
            //collision.gameObject.GetComponent<Rigidbody>().AddExplosionForce(500f, collision.transform.position, 2f, 500f);
            collision.gameObject.GetComponent<Rigidbody>().AddForce(-collision.transform.forward * 20f + Vector3.up * 50f, ForceMode.Impulse);
            collision.gameObject.GetComponent<AudioSource>().Play();
            Destroy(collision.gameObject, 1f);
            Invoke(nameof(ResetBool), 0.2f);
        }
    }

    private void ResetBool()
    {
        hasHit = false;
    }
}
