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

		GameObject[] objs = GameObject.FindGameObjectsWithTag("Sound Manager");

		if (objs.Length > 1)
		{
			Destroy(gameObject);
			Debug.Log ("bora meu fi destrua");
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void Awake()
	{
		

		//DontDestroyOnLoad(this.gameObject);
	}
}