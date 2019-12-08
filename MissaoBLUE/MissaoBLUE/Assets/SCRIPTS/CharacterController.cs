using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 3.0f;
    public float jump = 3.0f;
    public float gravity = 9.8f;

    private Vector3 characterMove =  Vector3.zero;
    
    private CharacterController ccontroller;



    // Start is called before the first frame update
    void Start()
    {
        ccontroller = GetComponent<CharacterController>();        
    }

    // Update is called once per frame
    void Update()
    {
        characterMove = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        characterMove = transform.TransformDirection(characterMove);
        characterMove = characterMove * speed;

//        ccontroller.Move(characterMove * Time.deltaTime);

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
		transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
        
    }
}
