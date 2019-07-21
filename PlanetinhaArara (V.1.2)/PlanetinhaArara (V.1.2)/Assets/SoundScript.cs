using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SoundScript : MonoBehaviour
{
	public static bool playPressed;
	public static bool gameStarded;
	public bool canStartCrtn;
	public AudioSource musicaInicio;
	public AudioSource musicaAcao;
	public static AudioSource musInicio;
	public static AudioSource musAcao;

    // Start is called before the first frame update
    void Start()
    {
		musInicio = musicaInicio;
		musAcao = musicaAcao;
		//DontDestroyOnLoad(musicaInicio);
		//DontDestroyOnLoad(musicaAcao);
		playPressed = false;
		canStartCrtn = true;
    }

    // Update is called once per frame
    void Update()
    {
		Debug.Log("nao fui destruidoo");

		if (canStartCrtn == true) {
			
			StartCoroutine("VerificacaoPlay");
			canStartCrtn = false;
		}


    }

	IEnumerator VerificacaoPlay()
	{
		Scene cena = SceneManager.GetActiveScene();

		if (cena.name == "Gameplay")  //playPressed == true
		{
			musInicio.Stop();
			musAcao.Play();
		}

		else if (cena.name == "Menu2") 
		{
			Debug.Log("começa a musica");
			musInicio.Play();
			musAcao.Stop();
		}

		yield return new WaitForSeconds(40 );
		Debug.Log("esperouu");

		canStartCrtn = true;
	}
}
