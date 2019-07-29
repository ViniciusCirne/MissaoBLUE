using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
	public static int canStartTutorial;
	public Text texto;
	public string[] frases;
	public int index;
	public float velocidade;
	public GameObject painelTutorial;
	public static bool tutorialDone;
	private static int contador;



    // Start is called before the first frame update
    void Start()
    {  


		if (contador == 0) {
			tutorialDone = false;
			NumAraras.canStartNum = false;
			canStartTutorial+=1;
			StartCoroutine(Digitar());
    }

		else if (contador >= 1) {
			tutorialDone = true;
			NumAraras.canStartNum = true;
			painelTutorial.SetActive(false);
		}
		//tutorialDone = false;
		//NumAraras.canStartNum = false;
		//canStartTutorial+=1;
		//StartCoroutine(Digitar());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	IEnumerator Digitar()
	{
		
		AraraMovement.speed = 0.0f;

		foreach(char letra in frases[index].ToCharArray())
		{
			texto.text += letra;
			yield return new WaitForSeconds(velocidade);
		}

		yield return new WaitForSeconds(5);
		texto.text = "";
		index++;

		foreach(char letra in frases[index].ToCharArray())
		{
			texto.text += letra;
			yield return new WaitForSeconds(velocidade);
		}

		yield return new WaitForSeconds(2);

		NumAraras.canStartNum = true;
		//AraraMovement.speed = 10.0f;
		painelTutorial.SetActive(false);
		tutorialDone = true;
		contador++;


	}
}
