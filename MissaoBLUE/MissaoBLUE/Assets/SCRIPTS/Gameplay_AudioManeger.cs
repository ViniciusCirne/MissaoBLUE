using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameplay_AudioManeger : MonoBehaviour
{
    public AudioSource backgroundsource;
       
    void Start()
    {

        backgroundsource = GetComponent<AudioSource>();   

    }

    public void PlayBackground()
    {
        Scene cena = SceneManager.GetActiveScene();

		if (cena.name == "Gameplay")  //playPressed == true
		{
			backgroundsource.Play();
			
		}

    }



}
