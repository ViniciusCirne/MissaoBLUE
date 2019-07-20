using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
		playPressed = false;
		canStartCrtn = true;
    }

    // Update is called once per frame
    void Update()
    {
		if (canStartCrtn == true) {
			
			StartCoroutine("VerificacaoPlay");
			//canStartCrtn = false;
		}


    }

	IEnumerator VerificacaoPlay()
	{
		if (playPressed == true) 
		{
			musicaInicio.Stop();
			musicaAcao.Play();
		}

		else if (playPressed == false) 
		{
			Debug.Log("começa a musica");
			musicaInicio.Play();
		}

		yield return new WaitForSeconds(42);

		canStartCrtn = true;
	}
}
