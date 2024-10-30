using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolController : MonoBehaviour
{
    // Start is called before the first frame update
    public float power = 5f;

    void Start()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(-1, 0, 0) * power, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
