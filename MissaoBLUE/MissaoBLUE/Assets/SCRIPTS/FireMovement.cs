using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FireMovement : MonoBehaviour
{
    public int speed; 
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		if (AraraMovement.speed > 0.0f) {
			rb.velocity = transform.forward * speed;
       }
		else {
			rb.velocity = transform.forward * 0;
		}
       
    }
}
