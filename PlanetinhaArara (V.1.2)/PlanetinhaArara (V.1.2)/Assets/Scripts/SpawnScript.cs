using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
	public GameObject prefab;


    // Start is called before the first frame update
    void Start()
    {
		//prefab.transform.position.x += 3;
		Instantiate (prefab, new Vector3(prefab.transform.position.x -10, prefab.transform.position.y, prefab.transform.position.z+10), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
