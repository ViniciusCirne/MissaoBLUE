using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
	public GameObject soundManager;
	public GameObject musicas;

    // Start is called before the first frame update
    void Start()
    {
		DontDestroyOnLoad(soundManager);
		DontDestroyOnLoad(musicas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
