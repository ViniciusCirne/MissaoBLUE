using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{

    public static int scoreValue = 0;
    Text score;

    void Start()
    {
		score = GetComponent<Text> ();

		Scene cena = SceneManager.GetActiveScene();

		if (cena.name == "Gameplay") {

			scoreValue = 0;
		}

       

    }

    // Update is called once per frame
    void Update()
    {
        score.text = " " + scoreValue;
    }
}
