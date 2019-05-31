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
		Instantiate (prefab, new Vector3(0, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
              SpawnTrees(); 	//Instantiate (prefab, new Vector3(30, 0, 0), Quaternion.identity);
        }
    }

    public void SpawnTrees(Vector3 lastPos)
    {
       Instantiate (prefab, new Vector3(lastPos + 30, 0, 0), Quaternion.identity);
    }
}
