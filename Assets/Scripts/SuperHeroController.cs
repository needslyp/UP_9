using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SuperHeroController : MonoBehaviour
{
    public float power = 1f;
    public float speed = 5f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 0, 30), speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision){
        Debug.Log("Collided with " + collision.gameObject.name);
        if (collision.gameObject.GetComponent<Rigidbody>() != null){
            collision.gameObject.GetComponent<Rigidbody>().AddForce(power * new Vector3(0, 2, 1), ForceMode.Impulse);
        };
    }
}
