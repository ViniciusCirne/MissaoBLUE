using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumAraras : MonoBehaviour
{
	public GameObject canvasNum;
	public Text num;
	public static int minAraras;
	public static bool canStartNum;
	public static bool canAdd;


    // Start is called before the first frame update
    void Start()
    {

		Scene cena = SceneManager.GetActiveScene();
		
		canvasNum.SetActive(false);
		//minAraras = 3;
		//num = GetComponent<Text> ();
		//canvasNum.SetActive (false);
		//StartCoroutine(TempoCanvas());
		if (Tutorial.tutorialDone == false) {
			canvasNum.SetActive(false);
		}

		if (Tutorial.tutorialDone == true && cena.name == "Gameplay") {
			canvasNum.SetActive(true);
		}

    }

    // Update is called once per frame
    void Update()
    {
		if (canStartNum == true) {
			Debug.Log("começa a corotina");
			canvasNum.SetActive(true);
			StartCoroutine(TempoCanvas());
			canStartNum = false;
		}
			

	    if (canAdd == true) {
			Debug.Log("adicionou");
			minAraras += 5;
			Debug.Log(minAraras);
			canAdd = false;
		}

		num.text = " " + minAraras;
    }

	IEnumerator TempoCanvas()
	{
		AraraMovement.speed = 0.0f;
		canvasNum.SetActive (true);
		yield return new WaitForSeconds(4);
		canvasNum.SetActive (false);
		AraraMovement.speed = 10.0f;

	}


}
