using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
	public GameObject objeto;

    // Start is called before the first frame update
    void Start()
    {
		DontDestroyOnLoad(objeto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
