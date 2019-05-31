using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
	public GameObject prefab;

    Vector3 lastPosi;
    Vector3 nextPosi; 

    // Start is called before the first frame update
    void Start()
    {
        lastPosi = new Vector3(0, 0, 0);
        nextPosi = new Vector3(0, 0, 0);
		//prefab.transform.position.x += 3;
		Instantiate (prefab, lastPosi, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
              SpawnTrees(nextPosi, lastPosi); 	//Instantiate (prefab, new Vector3(30, 0, 0), Quaternion.identity);
        }
    }

    void SpawnTrees(Vector3 nextPosiii, Vector3 lastPosiii)
    {
       
       nextPosiii = new Vector3 (0, 0, lastPosiii.z + 30);
       lastPosi = nextPosiii;
       Instantiate (prefab, nextPosiii, Quaternion.identity);
    }
       
    
}
