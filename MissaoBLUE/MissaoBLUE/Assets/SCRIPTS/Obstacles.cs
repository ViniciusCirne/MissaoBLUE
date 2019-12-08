using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public float fallSpeed = 40.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeForFall();
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
    }

    IEnumerator TimeForFall()
    {
        yield return new WaitForSeconds(5f);
    }
}
