using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonGameOver : MonoBehaviour
{
    public AudioSource buttonplay;

    // Start is called before the first frame update
    void Start()
    {

    buttonplay = GetComponent<AudioSource>();   

    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void Restart()
	{
        buttonplay.Play();
		SceneManager.LoadScene("Gameplay");        
	}
}
