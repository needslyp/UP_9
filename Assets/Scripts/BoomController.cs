using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomController : MonoBehaviour
{
    public float TimeToExplosion = 3f;
    public float power = 10f;
    public float radius = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeToExplosion -= Time.deltaTime;
        if (TimeToExplosion <= 0)
        {
            Boom();
        }
    }

    void Boom(){
        Rigidbody[] rigidBodies = FindObjectsOfType<Rigidbody>();
        foreach (Rigidbody rigidBody in rigidBodies){
            float distance = Vector3.Distance(rigidBody.transform.position, transform.position);
            if (distance < radius){
                Vector3 direction = rigidBody.transform.position - transform.position;
                rigidBody.AddForce((radius - distance) * power * direction.normalized, ForceMode.Impulse);
        }

        TimeToExplosion = 3f;
        }
    }
}
