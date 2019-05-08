using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FireMovement : MonoBehaviour
{
    public int speed; 
    Rigidbody aaa;

    // Start is called before the first frame update
    void Start()
    {
        aaa = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       aaa.velocity = transform.forward * speed;
    }
}
